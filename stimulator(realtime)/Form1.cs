using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Newtonsoft.Json;


namespace stimulator_realtime_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        bool check = false;
        string deviceid = "DX_CSC6548";
        int devStat, defroStat, compStat, evapStat, auxStat;
        double minTemp, maxTemp, minsetPoint, maxsetPoint, round, rn, roomTemp, setPoint, evapTemp, minevapTemp, maxevapTemp;
 
        public void inputs()
        {
            //simulator
                var Timestamp = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();
                DateTime dateTime = DateTime.Now;
                lbldeviceid.Text = deviceid;
                lblRecievedTime.Text = Timestamp.ToString();
                Random rand = new Random();
                minTemp = 10;
                maxTemp = 40;
                roomTemp = Math.Round((rand.NextDouble() * (maxTemp - minTemp)) + minTemp, 1);
                lblRoomTemp.Text = roomTemp.ToString();
                minsetPoint = -10;
                maxsetPoint = 10;
                setPoint = Math.Round((rand.NextDouble() * (maxsetPoint - minsetPoint)) + minsetPoint, 1);
                lblSetPoint.Text = setPoint.ToString();
                minevapTemp = 60;
                maxevapTemp = 80;
                evapTemp = Math.Round((rand.NextDouble() * (maxevapTemp - minevapTemp)) + minevapTemp, 1);
                lblevapTemp.Text = evapTemp.ToString();
                int result = new Random().Next(0, 2);
                lblDevstat.Text = result.ToString();
                lbldefroStat.Text = new Random().Next(0, 2).ToString();
                lblauxStat.Text = new Random().Next(0, 2).ToString();
                lblcompStat.Text = new Random().Next(0, 2).ToString();
                lblevpStat.Text = new Random().Next(0, 2).ToString();
                string shortcode = deviceid.Split('_')[0].ToString() + "_";
               //sensors
                string[] sensoridARR = {"tms","roomTemp","setPoint","devStat","evapTemp","defroStat","compStat","evapStat","auxStat"};
                List<string> sensorvalueARR = new List<string>();
                sensorvalueARR.Add(Timestamp.ToString());
                sensorvalueARR.Add(roomTemp.ToString());
                sensorvalueARR.Add(setPoint.ToString());
                sensorvalueARR.Add(result.ToString());
                sensorvalueARR.Add(evapTemp.ToString());
                sensorvalueARR.Add(lbldefroStat.Text);
                sensorvalueARR.Add(lblcompStat.Text);
                sensorvalueARR.Add(lblevpStat.Text);
                sensorvalueARR.Add(lblauxStat.Text);
            //raw data
                SqlConnection cn = new SqlConnection("uid=sa;pwd=Ide@123;database=AB;server=AJAYBHARATH\\SQLEXPRESS");
                cn.Open();
                SqlCommand cm = new SqlCommand("proc_devicedata", cn);//timing,deviceid,temperature
                cm.CommandType = CommandType.StoredProcedure;
                SqlParameter receivedtime, devicedata;
                devicedata d = new devicedata();
                //List<devicedata> devicelst = new List<devicedata>();
                d.deviceId = deviceid;
                d.tms = Timestamp.ToString();
                d.roomTemp = roomTemp.ToString();
                d.setPoint = setPoint.ToString();
                d.devStat = lblDevstat.Text;
                d.evapTemp = evapTemp.ToString();
                d.defroStat = lbldefroStat.Text;
                d.compStat = lblcompStat.Text;
                d.evapStat = lblevpStat.Text;
                d.auxStat = lblauxStat.Text;
                //devicelst.Add(d);
                string jsondata = JsonConvert.SerializeObject(d);
                devicedata = new SqlParameter("devicedata", SqlDbType.VarChar);
                devicedata.Value = jsondata;
                cm.Parameters.Add(devicedata);
                receivedtime = new SqlParameter("receivedtime", SqlDbType.VarChar);
                receivedtime.Value = DateTime.Now;
                cm.Parameters.Add(receivedtime);
                cm.ExecuteNonQuery();
                cn.Close();
                cn.Open();
            //live data
                for (int i = 0; i < sensoridARR.Count(); i++)
                {
                    SqlCommand cm1 = new SqlCommand("proc_devicelivedata", cn);
                    cm1.CommandType = CommandType.StoredProcedure;
                    SqlParameter DeviceId1, SensorId, SensorValue, ReceivedTime, ShortCode, SensorTime, ShowLive, IfTrue, IfFalse, Dif_In_Mins, SENSORTYPE, uom, inserted;
                    DeviceId1 = new SqlParameter("DeviceId", SqlDbType.VarChar);
                    DeviceId1.Value = deviceid;
                    cm1.Parameters.Add(DeviceId1);
                    SensorId = new SqlParameter("SensorId", SqlDbType.VarChar);
                    SensorId.Value = sensoridARR[i].ToString();
                    cm1.Parameters.Add(SensorId);
                    SensorValue = new SqlParameter("SensorValue",SqlDbType.VarChar);
                    SensorValue.Value = sensorvalueARR[i].ToString();
                    cm1.Parameters.Add(SensorValue);
                    ReceivedTime = new SqlParameter("ReceivedTime",SqlDbType.DateTime);
                    ReceivedTime.Value = dateTime;
                    cm1.Parameters.Add(ReceivedTime);
                    ShortCode = new SqlParameter("ShortCode",SqlDbType.VarChar);
                    ShortCode.Value = shortcode;
                    cm1.Parameters.Add(ShortCode);
                    SensorTime = new SqlParameter("SensorTime",SqlDbType.VarChar);
                    SensorTime.Value = Timestamp.ToString();
                    cm1.Parameters.Add(SensorTime);
                    ShowLive = new SqlParameter("ShowLive", SqlDbType.VarChar);
                    ShowLive.Value = "null";
                    cm1.Parameters.Add(ShowLive);
                    IfTrue = new SqlParameter("IfTrue", SqlDbType.VarChar);
                    IfTrue.Value = "null";
                    cm1.Parameters.Add(IfTrue);
                    IfFalse = new SqlParameter("IfFalse", SqlDbType.VarChar);
                    IfFalse.Value = "null";
                    cm1.Parameters.Add(IfFalse);
                    Dif_In_Mins = new SqlParameter("Dif_In_Mins", SqlDbType.VarChar);
                    Dif_In_Mins.Value = "null";
                    cm1.Parameters.Add(Dif_In_Mins);
                    SENSORTYPE = new SqlParameter("SENSORTYPE", SqlDbType.VarChar);
                    SENSORTYPE.Value = "null";
                    cm1.Parameters.Add(SENSORTYPE);
                    uom = new SqlParameter("uom", SqlDbType.VarChar);
                    uom.Value = "null";
                    cm1.Parameters.Add(uom);
                    inserted = new SqlParameter("inserted", SqlDbType.VarChar);
                    inserted.Value = "null";
                    cm1.Parameters.Add(inserted);
                    cm1.ExecuteNonQuery();
                }
            cn.Close();
            //hisData
            cn.Open();
            SqlCommand cm2 = new SqlCommand("select distinct deviceid from tbl_devicedata",cn);
            SqlDataReader dr = cm2.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            cn.Close();
            cn.Open();
            for (int j = 0; j < dt.Rows.Count; j++)
            {
                for (int i = 0; i < sensoridARR.Count(); i++)
                {
                    SqlCommand cm3 = new SqlCommand("proc_hisTable", cn);
                    cm3.CommandType = CommandType.StoredProcedure;
                    SqlParameter hisDeviceId, hisSensorId, hisSensorValue, hisReceivedTime, hisShortCode, hisSensorTime, hisShowLive, hisIfTrue, hisIfFalse, hisDif_In_Mins, hisSENSORTYPE, hisuom, hisinserted,histablename;
                    hisDeviceId = new SqlParameter("DeviceId", SqlDbType.VarChar);
                    hisDeviceId.Value = deviceid;
                    cm3.Parameters.Add(hisDeviceId);
                    hisSensorId = new SqlParameter("SensorId", SqlDbType.VarChar);
                    hisSensorId.Value = sensoridARR[i].ToString();
                    cm3.Parameters.Add(hisSensorId);
                    hisSensorValue = new SqlParameter("SensorValue", SqlDbType.VarChar);
                    hisSensorValue.Value = sensorvalueARR[i].ToString();
                    cm3.Parameters.Add(hisSensorValue);
                    hisReceivedTime = new SqlParameter("ReceivedTime", SqlDbType.DateTime);
                    hisReceivedTime.Value = dateTime;
                    cm3.Parameters.Add(hisReceivedTime);
                    hisShortCode = new SqlParameter("ShortCode", SqlDbType.VarChar);
                    hisShortCode.Value = shortcode;
                    cm3.Parameters.Add(hisShortCode);
                    hisSensorTime = new SqlParameter("SensorTime", SqlDbType.VarChar);
                    hisSensorTime.Value = Timestamp.ToString();
                    cm3.Parameters.Add(hisSensorTime);
                    hisShowLive = new SqlParameter("ShowLive", SqlDbType.VarChar);
                    hisShowLive.Value = "null";
                    cm3.Parameters.Add(hisShowLive);
                    hisIfTrue = new SqlParameter("IfTrue", SqlDbType.VarChar);
                    hisIfTrue.Value = "null";
                    cm3.Parameters.Add(hisIfTrue);
                    hisIfFalse = new SqlParameter("IfFalse", SqlDbType.VarChar);
                    hisIfFalse.Value = "null";
                    cm3.Parameters.Add(hisIfFalse);
                    hisDif_In_Mins = new SqlParameter("Dif_In_Mins", SqlDbType.VarChar);
                    hisDif_In_Mins.Value = "null";
                    cm3.Parameters.Add(hisDif_In_Mins);
                    hisSENSORTYPE = new SqlParameter("SENSORTYPE", SqlDbType.VarChar);
                    hisSENSORTYPE.Value = "null";
                    cm3.Parameters.Add(hisSENSORTYPE);
                    hisuom = new SqlParameter("uom", SqlDbType.VarChar);
                    hisuom.Value = "null";
                    cm3.Parameters.Add(hisuom);
                    hisinserted = new SqlParameter("inserted", SqlDbType.VarChar);
                    hisinserted.Value = "null";
                    cm3.Parameters.Add(hisinserted);
                    histablename = new SqlParameter("tablename",SqlDbType.VarChar);
                    histablename.Value = dt.Rows[j]["deviceid"].ToString();
                    cm3.Parameters.Add(histablename);
                    cm3.ExecuteNonQuery();
                } 
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            inputs();
            timer1.Enabled = true;
        }
        private void btnsubmit_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 10000;
        }
    }
}
