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
            this.AddCustBTN = new System.Windows.Forms.Button();
            this.AddOrderBTN = new System.Windows.Forms.Button();
            this.PrintBillBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddCustBTN
            // 
            this.AddCustBTN.Location = new System.Drawing.Point(59, 68);
            this.AddCustBTN.Name = "AddCustBTN";
            this.AddCustBTN.Size = new System.Drawing.Size(106, 23);
            this.AddCustBTN.TabIndex = 21;
            this.AddCustBTN.Text = "Add Customer";
            this.AddCustBTN.UseVisualStyleBackColor = true;
            // 
            // AddOrderBTN
            // 
            this.AddOrderBTN.Location = new System.Drawing.Point(59, 114);
            this.AddOrderBTN.Name = "AddOrderBTN";
            this.AddOrderBTN.Size = new System.Drawing.Size(106, 23);
            this.AddOrderBTN.TabIndex = 22;
            this.AddOrderBTN.Text = "Add Order";
            this.AddOrderBTN.UseVisualStyleBackColor = true;
            // 
            // PrintBillBTN
            // 
            this.PrintBillBTN.Location = new System.Drawing.Point(59, 157);
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
            this.Controls.Add(this.AddCustBTN);
            this.Name = "TableOrderMainMenu";
            this.Size = new System.Drawing.Size(243, 235);
            this.Load += new System.EventHandler(this.TableOrderMainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button AddCustBTN;
        private System.Windows.Forms.Button AddOrderBTN;
        private System.Windows.Forms.Button PrintBillBTN;
    }
}
