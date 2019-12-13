namespace BarPointOfSaleSystem
{
    partial class Receipt
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
            this.TableNumberForBillLBL = new System.Windows.Forms.Label();
            this.TotalLBL = new System.Windows.Forms.Label();
            this.TotalNumberLBL = new System.Windows.Forms.Label();
            this.splitbillLBL = new System.Windows.Forms.Label();
            this.Billsplitways = new System.Windows.Forms.NumericUpDown();
            this.TotalPerBillNumberLBL = new System.Windows.Forms.Label();
            this.totalaftersplitLBL = new System.Windows.Forms.Label();
            this.EmployeeNameLBL = new System.Windows.Forms.Label();
            this.billrtb = new System.Windows.Forms.RichTextBox();
            this.paybtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Billsplitways)).BeginInit();
            this.SuspendLayout();
            // 
            // TableNumberForBillLBL
            // 
            this.TableNumberForBillLBL.AutoSize = true;
            this.TableNumberForBillLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableNumberForBillLBL.Location = new System.Drawing.Point(306, 26);
            this.TableNumberForBillLBL.Name = "TableNumberForBillLBL";
            this.TableNumberForBillLBL.Size = new System.Drawing.Size(147, 25);
            this.TableNumberForBillLBL.TabIndex = 1;
            this.TableNumberForBillLBL.Text = "Table Number";
            // 
            // TotalLBL
            // 
            this.TotalLBL.AutoSize = true;
            this.TotalLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLBL.Location = new System.Drawing.Point(396, 177);
            this.TotalLBL.Name = "TotalLBL";
            this.TotalLBL.Size = new System.Drawing.Size(66, 25);
            this.TotalLBL.TabIndex = 2;
            this.TotalLBL.Text = "Total:";
            // 
            // TotalNumberLBL
            // 
            this.TotalNumberLBL.AutoSize = true;
            this.TotalNumberLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalNumberLBL.Location = new System.Drawing.Point(483, 177);
            this.TotalNumberLBL.Name = "TotalNumberLBL";
            this.TotalNumberLBL.Size = new System.Drawing.Size(66, 25);
            this.TotalNumberLBL.TabIndex = 3;
            this.TotalNumberLBL.Text = "65.50";
            // 
            // splitbillLBL
            // 
            this.splitbillLBL.AutoSize = true;
            this.splitbillLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitbillLBL.Location = new System.Drawing.Point(396, 240);
            this.splitbillLBL.Name = "splitbillLBL";
            this.splitbillLBL.Size = new System.Drawing.Size(95, 25);
            this.splitbillLBL.TabIndex = 4;
            this.splitbillLBL.Text = "Bill Split:";
            // 
            // Billsplitways
            // 
            this.Billsplitways.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Billsplitways.Location = new System.Drawing.Point(519, 238);
            this.Billsplitways.Name = "Billsplitways";
            this.Billsplitways.Size = new System.Drawing.Size(47, 31);
            this.Billsplitways.TabIndex = 5;
            this.Billsplitways.ValueChanged += new System.EventHandler(this.Billsplitways_ValueChanged);
            // 
            // TotalPerBillNumberLBL
            // 
            this.TotalPerBillNumberLBL.AutoSize = true;
            this.TotalPerBillNumberLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPerBillNumberLBL.Location = new System.Drawing.Point(551, 299);
            this.TotalPerBillNumberLBL.Name = "TotalPerBillNumberLBL";
            this.TotalPerBillNumberLBL.Size = new System.Drawing.Size(139, 25);
            this.TotalPerBillNumberLBL.TabIndex = 7;
            this.TotalPerBillNumberLBL.Text = "Total Amount";
            // 
            // totalaftersplitLBL
            // 
            this.totalaftersplitLBL.AutoSize = true;
            this.totalaftersplitLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalaftersplitLBL.Location = new System.Drawing.Point(396, 299);
            this.totalaftersplitLBL.Name = "totalaftersplitLBL";
            this.totalaftersplitLBL.Size = new System.Drawing.Size(140, 25);
            this.totalaftersplitLBL.TabIndex = 6;
            this.totalaftersplitLBL.Text = "Total Per Bill:";
            // 
            // EmployeeNameLBL
            // 
            this.EmployeeNameLBL.AutoSize = true;
            this.EmployeeNameLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeNameLBL.Location = new System.Drawing.Point(44, 500);
            this.EmployeeNameLBL.Name = "EmployeeNameLBL";
            this.EmployeeNameLBL.Size = new System.Drawing.Size(76, 25);
            this.EmployeeNameLBL.TabIndex = 8;
            this.EmployeeNameLBL.Text = "label1";
            // 
            // billrtb
            // 
            this.billrtb.Enabled = false;
            this.billrtb.Location = new System.Drawing.Point(42, 80);
            this.billrtb.Name = "billrtb";
            this.billrtb.Size = new System.Drawing.Size(287, 447);
            this.billrtb.TabIndex = 9;
            this.billrtb.Text = "";
            // 
            // paybtn
            // 
            this.paybtn.Location = new System.Drawing.Point(680, 641);
            this.paybtn.Name = "paybtn";
            this.paybtn.Size = new System.Drawing.Size(108, 23);
            this.paybtn.TabIndex = 10;
            this.paybtn.Text = "Pay For Order";
            this.paybtn.UseVisualStyleBackColor = true;
            this.paybtn.Click += new System.EventHandler(this.paybtn_Click);
            // 
            // Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 676);
            this.Controls.Add(this.paybtn);
            this.Controls.Add(this.EmployeeNameLBL);
            this.Controls.Add(this.TotalPerBillNumberLBL);
            this.Controls.Add(this.totalaftersplitLBL);
            this.Controls.Add(this.Billsplitways);
            this.Controls.Add(this.splitbillLBL);
            this.Controls.Add(this.TotalNumberLBL);
            this.Controls.Add(this.TotalLBL);
            this.Controls.Add(this.TableNumberForBillLBL);
            this.Controls.Add(this.billrtb);
            this.Name = "Receipt";
            this.Text = "Reciept";
            this.Load += new System.EventHandler(this.Receipt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Billsplitways)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TableNumberForBillLBL;
        private System.Windows.Forms.Label TotalLBL;
        private System.Windows.Forms.Label TotalNumberLBL;
        private System.Windows.Forms.Label splitbillLBL;
        private System.Windows.Forms.NumericUpDown Billsplitways;
        private System.Windows.Forms.Label TotalPerBillNumberLBL;
        private System.Windows.Forms.Label totalaftersplitLBL;
        private System.Windows.Forms.Label EmployeeNameLBL;
        private System.Windows.Forms.RichTextBox billrtb;
        private System.Windows.Forms.Button paybtn;
    }
}