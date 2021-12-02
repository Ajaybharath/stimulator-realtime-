
namespace stimulator_realtime_
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbldeviceid = new System.Windows.Forms.Label();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblRecievedTime = new System.Windows.Forms.Label();
            this.lblSetPoint = new System.Windows.Forms.Label();
            this.lblRoomTemp = new System.Windows.Forms.Label();
            this.lblcompStat = new System.Windows.Forms.Label();
            this.lbldefroStat = new System.Windows.Forms.Label();
            this.lblevapTemp = new System.Windows.Forms.Label();
            this.lblDevstat = new System.Windows.Forms.Label();
            this.lblauxStat = new System.Windows.Forms.Label();
            this.lblevpStat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbldeviceid
            // 
            this.lbldeviceid.AutoSize = true;
            this.lbldeviceid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldeviceid.Location = new System.Drawing.Point(51, 60);
            this.lbldeviceid.Name = "lbldeviceid";
            this.lbldeviceid.Size = new System.Drawing.Size(53, 13);
            this.lbldeviceid.TabIndex = 54;
            this.lbldeviceid.Text = "Device Id";
            // 
            // btnsubmit
            // 
            this.btnsubmit.Location = new System.Drawing.Point(351, 352);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(75, 23);
            this.btnsubmit.TabIndex = 53;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(314, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 25);
            this.label3.TabIndex = 52;
            this.label3.Text = "Data Simulator";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblRecievedTime
            // 
            this.lblRecievedTime.AutoSize = true;
            this.lblRecievedTime.Location = new System.Drawing.Point(141, 60);
            this.lblRecievedTime.Name = "lblRecievedTime";
            this.lblRecievedTime.Size = new System.Drawing.Size(76, 13);
            this.lblRecievedTime.TabIndex = 55;
            this.lblRecievedTime.Text = "RecievedTime";
            // 
            // lblSetPoint
            // 
            this.lblSetPoint.AutoSize = true;
            this.lblSetPoint.Location = new System.Drawing.Point(355, 60);
            this.lblSetPoint.Name = "lblSetPoint";
            this.lblSetPoint.Size = new System.Drawing.Size(47, 13);
            this.lblSetPoint.TabIndex = 57;
            this.lblSetPoint.Text = "SetPoint";
            // 
            // lblRoomTemp
            // 
            this.lblRoomTemp.AutoSize = true;
            this.lblRoomTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomTemp.Location = new System.Drawing.Point(241, 60);
            this.lblRoomTemp.Name = "lblRoomTemp";
            this.lblRoomTemp.Size = new System.Drawing.Size(95, 13);
            this.lblRoomTemp.TabIndex = 56;
            this.lblRoomTemp.Text = "RoomTemperature";
            // 
            // lblcompStat
            // 
            this.lblcompStat.AutoSize = true;
            this.lblcompStat.Location = new System.Drawing.Point(588, 60);
            this.lblcompStat.Name = "lblcompStat";
            this.lblcompStat.Size = new System.Drawing.Size(52, 13);
            this.lblcompStat.TabIndex = 61;
            this.lblcompStat.Text = "compStat";
            // 
            // lbldefroStat
            // 
            this.lbldefroStat.AutoSize = true;
            this.lbldefroStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldefroStat.Location = new System.Drawing.Point(532, 60);
            this.lbldefroStat.Name = "lbldefroStat";
            this.lbldefroStat.Size = new System.Drawing.Size(50, 13);
            this.lbldefroStat.TabIndex = 60;
            this.lbldefroStat.Text = "defroStat";
            // 
            // lblevapTemp
            // 
            this.lblevapTemp.AutoSize = true;
            this.lblevapTemp.Location = new System.Drawing.Point(468, 60);
            this.lblevapTemp.Name = "lblevapTemp";
            this.lblevapTemp.Size = new System.Drawing.Size(58, 13);
            this.lblevapTemp.TabIndex = 59;
            this.lblevapTemp.Text = "evapTemp";
            // 
            // lblDevstat
            // 
            this.lblDevstat.AutoSize = true;
            this.lblDevstat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevstat.Location = new System.Drawing.Point(409, 60);
            this.lblDevstat.Name = "lblDevstat";
            this.lblDevstat.Size = new System.Drawing.Size(44, 13);
            this.lblDevstat.TabIndex = 58;
            this.lblDevstat.Text = "Devstat";
            // 
            // lblauxStat
            // 
            this.lblauxStat.AutoSize = true;
            this.lblauxStat.Location = new System.Drawing.Point(701, 60);
            this.lblauxStat.Name = "lblauxStat";
            this.lblauxStat.Size = new System.Drawing.Size(43, 13);
            this.lblauxStat.TabIndex = 63;
            this.lblauxStat.Text = "auxStat";
            // 
            // lblevpStat
            // 
            this.lblevpStat.AutoSize = true;
            this.lblevpStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblevpStat.Location = new System.Drawing.Point(645, 60);
            this.lblevpStat.Name = "lblevpStat";
            this.lblevpStat.Size = new System.Drawing.Size(44, 13);
            this.lblevpStat.TabIndex = 62;
            this.lblevpStat.Text = "evpStat";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblauxStat);
            this.Controls.Add(this.lblevpStat);
            this.Controls.Add(this.lblcompStat);
            this.Controls.Add(this.lbldefroStat);
            this.Controls.Add(this.lblevapTemp);
            this.Controls.Add(this.lblDevstat);
            this.Controls.Add(this.lblSetPoint);
            this.Controls.Add(this.lblRoomTemp);
            this.Controls.Add(this.lblRecievedTime);
            this.Controls.Add(this.lbldeviceid);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbldeviceid;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblRecievedTime;
        private System.Windows.Forms.Label lblSetPoint;
        private System.Windows.Forms.Label lblRoomTemp;
        private System.Windows.Forms.Label lblcompStat;
        private System.Windows.Forms.Label lbldefroStat;
        private System.Windows.Forms.Label lblevapTemp;
        private System.Windows.Forms.Label lblDevstat;
        private System.Windows.Forms.Label lblauxStat;
        private System.Windows.Forms.Label lblevpStat;
    }
}

