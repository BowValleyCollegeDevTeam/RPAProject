namespace BarPointOfSaleSystem
{
    partial class TopInfoBar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.StaffNameLabel = new System.Windows.Forms.Label();
            this.TimeTimerTicker = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.TimeLabel);
            this.panel1.Controls.Add(this.StaffNameLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(680, 34);
            this.panel1.TabIndex = 3;
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.Location = new System.Drawing.Point(534, 0);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.TimeLabel.Size = new System.Drawing.Size(144, 21);
            this.TimeLabel.TabIndex = 3;
            this.TimeLabel.Text = "00/00/0000 0:00:00 AM";
            // 
            // StaffNameLabel
            // 
            this.StaffNameLabel.AutoSize = true;
            this.StaffNameLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.StaffNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffNameLabel.Location = new System.Drawing.Point(0, 0);
            this.StaffNameLabel.Name = "StaffNameLabel";
            this.StaffNameLabel.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.StaffNameLabel.Size = new System.Drawing.Size(116, 21);
            this.StaffNameLabel.TabIndex = 1;
            this.StaffNameLabel.Text = "Name: Cole Tucker";
            // 
            // TimeTimerTicker
            // 
            this.TimeTimerTicker.Tick += new System.EventHandler(this.TimeTimerTicker_Tick_1);
            // 
            // TopInfoBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "TopInfoBar";
            this.Size = new System.Drawing.Size(680, 32);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TimeLabel;
        public System.Windows.Forms.Label StaffNameLabel;
        private System.Windows.Forms.Timer TimeTimerTicker;
    }
}
