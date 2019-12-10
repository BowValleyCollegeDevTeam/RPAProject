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
            this.SuspendLayout();
            // 
            // AddOrderBTN
            // 
            this.AddOrderBTN.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AddOrderBTN.Location = new System.Drawing.Point(49, 31);
            this.AddOrderBTN.Name = "AddOrderBTN";
            this.AddOrderBTN.Size = new System.Drawing.Size(106, 23);
            this.AddOrderBTN.TabIndex = 22;
            this.AddOrderBTN.Text = "Add Order";
            this.AddOrderBTN.UseVisualStyleBackColor = true;
            this.AddOrderBTN.Click += new System.EventHandler(this.AddOrderBTN_Click);
            // 
            // PrintBillBTN
            // 
            this.PrintBillBTN.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.PrintBillBTN.Location = new System.Drawing.Point(49, 60);
            this.PrintBillBTN.Name = "PrintBillBTN";
            this.PrintBillBTN.Size = new System.Drawing.Size(106, 23);
            this.PrintBillBTN.TabIndex = 23;
            this.PrintBillBTN.Text = "Print Bill";
            this.PrintBillBTN.UseVisualStyleBackColor = true;
            // 
            // TableOrderMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PrintBillBTN);
            this.Controls.Add(this.AddOrderBTN);
            this.Name = "TableOrderMainMenu";
            this.Size = new System.Drawing.Size(200, 235);
            this.Load += new System.EventHandler(this.TableOrderMainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button AddOrderBTN;
        private System.Windows.Forms.Button PrintBillBTN;
    }
}
