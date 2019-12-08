namespace BarPointOfSaleSystem
{
    partial class TableOrderMainMenu
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
            this.AddOrderBTN = new System.Windows.Forms.Button();
            this.PrintBillBTN = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddOrderBTN
            // 
            this.AddOrderBTN.Location = new System.Drawing.Point(59, 70);
            this.AddOrderBTN.Name = "AddOrderBTN";
            this.AddOrderBTN.Size = new System.Drawing.Size(106, 23);
            this.AddOrderBTN.TabIndex = 22;
            this.AddOrderBTN.Text = "Add Order";
            this.AddOrderBTN.UseVisualStyleBackColor = true;
            // 
            // PrintBillBTN
            // 
            this.PrintBillBTN.Location = new System.Drawing.Point(59, 99);
            this.PrintBillBTN.Name = "PrintBillBTN";
            this.PrintBillBTN.Size = new System.Drawing.Size(106, 23);
            this.PrintBillBTN.TabIndex = 23;
            this.PrintBillBTN.Text = "Print Bill";
            this.PrintBillBTN.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Close Order Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // TableOrderMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PrintBillBTN);
            this.Controls.Add(this.AddOrderBTN);
            this.Name = "TableOrderMainMenu";
            this.Size = new System.Drawing.Size(243, 235);
            this.Load += new System.EventHandler(this.TableOrderMainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button AddOrderBTN;
        private System.Windows.Forms.Button PrintBillBTN;
        private System.Windows.Forms.Button button1;
    }
}
