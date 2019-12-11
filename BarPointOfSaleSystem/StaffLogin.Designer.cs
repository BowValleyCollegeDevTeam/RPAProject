namespace BarPointOfSaleSystem
{
    partial class StaffLogin
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
            this.PasscodeLabel = new System.Windows.Forms.Label();
            this.StaffPasscodeInputBox = new System.Windows.Forms.TextBox();
            this.EmployeePasscodeLabel = new System.Windows.Forms.Label();
            this.Button7 = new System.Windows.Forms.Button();
            this.Button8 = new System.Windows.Forms.Button();
            this.Button9 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button5 = new System.Windows.Forms.Button();
            this.Button6 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.Button0 = new System.Windows.Forms.Button();
            this.EnterButton = new System.Windows.Forms.Button();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barPOSSystemDataDataSet1 = new BarPointOfSaleSystem.BarPOSSystemDataDataSet();
            this.employeesTableAdapter1 = new BarPointOfSaleSystem.BarPOSSystemDataDataSetTableAdapters.EmployeesTableAdapter();
            this.tableAdapterManager1 = new BarPointOfSaleSystem.BarPOSSystemDataDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barPOSSystemDataDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // PasscodeLabel
            // 
            this.PasscodeLabel.AutoSize = true;
            this.PasscodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasscodeLabel.Location = new System.Drawing.Point(12, 9);
            this.PasscodeLabel.Name = "PasscodeLabel";
            this.PasscodeLabel.Size = new System.Drawing.Size(157, 37);
            this.PasscodeLabel.TabIndex = 0;
            this.PasscodeLabel.Text = "Passcode";
            // 
            // StaffPasscodeInputBox
            // 
            this.StaffPasscodeInputBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.StaffPasscodeInputBox.Enabled = false;
            this.StaffPasscodeInputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffPasscodeInputBox.Location = new System.Drawing.Point(228, 64);
            this.StaffPasscodeInputBox.Name = "StaffPasscodeInputBox";
            this.StaffPasscodeInputBox.ReadOnly = true;
            this.StaffPasscodeInputBox.Size = new System.Drawing.Size(285, 31);
            this.StaffPasscodeInputBox.TabIndex = 1;
            this.StaffPasscodeInputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EmployeePasscodeLabel
            // 
            this.EmployeePasscodeLabel.AutoSize = true;
            this.EmployeePasscodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeePasscodeLabel.Location = new System.Drawing.Point(15, 68);
            this.EmployeePasscodeLabel.Name = "EmployeePasscodeLabel";
            this.EmployeePasscodeLabel.Size = new System.Drawing.Size(184, 24);
            this.EmployeePasscodeLabel.TabIndex = 3;
            this.EmployeePasscodeLabel.Text = "Employee Passcode";
            // 
            // Button7
            // 
            this.Button7.Location = new System.Drawing.Point(228, 101);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(91, 75);
            this.Button7.TabIndex = 4;
            this.Button7.Text = "7";
            this.Button7.UseVisualStyleBackColor = true;
            this.Button7.Click += new System.EventHandler(this.PasscodeButtonClick);
            this.Button7.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NumPadKeyDown);
            // 
            // Button8
            // 
            this.Button8.Location = new System.Drawing.Point(325, 101);
            this.Button8.Name = "Button8";
            this.Button8.Size = new System.Drawing.Size(91, 75);
            this.Button8.TabIndex = 5;
            this.Button8.Text = "8";
            this.Button8.UseVisualStyleBackColor = true;
            this.Button8.Click += new System.EventHandler(this.PasscodeButtonClick);
            this.Button8.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NumPadKeyDown);
            // 
            // Button9
            // 
            this.Button9.Location = new System.Drawing.Point(422, 101);
            this.Button9.Name = "Button9";
            this.Button9.Size = new System.Drawing.Size(91, 75);
            this.Button9.TabIndex = 6;
            this.Button9.Text = "9";
            this.Button9.UseVisualStyleBackColor = true;
            this.Button9.Click += new System.EventHandler(this.PasscodeButtonClick);
            this.Button9.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NumPadKeyDown);
            // 
            // Button4
            // 
            this.Button4.Location = new System.Drawing.Point(228, 182);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(91, 75);
            this.Button4.TabIndex = 7;
            this.Button4.Text = "4";
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Click += new System.EventHandler(this.PasscodeButtonClick);
            this.Button4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NumPadKeyDown);
            // 
            // Button5
            // 
            this.Button5.Location = new System.Drawing.Point(325, 182);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(91, 75);
            this.Button5.TabIndex = 8;
            this.Button5.Text = "5";
            this.Button5.UseVisualStyleBackColor = true;
            this.Button5.Click += new System.EventHandler(this.PasscodeButtonClick);
            this.Button5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NumPadKeyDown);
            // 
            // Button6
            // 
            this.Button6.Location = new System.Drawing.Point(422, 182);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(91, 75);
            this.Button6.TabIndex = 9;
            this.Button6.Text = "6";
            this.Button6.UseVisualStyleBackColor = true;
            this.Button6.Click += new System.EventHandler(this.PasscodeButtonClick);
            this.Button6.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NumPadKeyDown);
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(228, 263);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(91, 75);
            this.Button1.TabIndex = 10;
            this.Button1.Text = "1";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.PasscodeButtonClick);
            this.Button1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NumPadKeyDown);
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(325, 263);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(91, 75);
            this.Button2.TabIndex = 11;
            this.Button2.Text = "2";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.PasscodeButtonClick);
            this.Button2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NumPadKeyDown);
            // 
            // Button3
            // 
            this.Button3.Location = new System.Drawing.Point(422, 263);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(91, 75);
            this.Button3.TabIndex = 12;
            this.Button3.Text = "3";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.PasscodeButtonClick);
            this.Button3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NumPadKeyDown);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(228, 344);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(91, 75);
            this.DeleteButton.TabIndex = 13;
            this.DeleteButton.Text = "DEL";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            this.DeleteButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NumPadKeyDown);
            // 
            // Button0
            // 
            this.Button0.Location = new System.Drawing.Point(325, 344);
            this.Button0.Name = "Button0";
            this.Button0.Size = new System.Drawing.Size(91, 75);
            this.Button0.TabIndex = 14;
            this.Button0.Text = "0";
            this.Button0.UseVisualStyleBackColor = true;
            this.Button0.Click += new System.EventHandler(this.PasscodeButtonClick);
            this.Button0.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NumPadKeyDown);
            // 
            // EnterButton
            // 
            this.EnterButton.Location = new System.Drawing.Point(422, 344);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(91, 75);
            this.EnterButton.TabIndex = 0;
            this.EnterButton.Text = "Enter";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            this.EnterButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NumPadKeyDown);
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Employees";
            this.tableBindingSource.DataSource = this.barPOSSystemDataDataSet1;
            // 
            // barPOSSystemDataDataSet1
            // 
            this.barPOSSystemDataDataSet1.DataSetName = "BarPOSSystemDataDataSet";
            this.barPOSSystemDataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesTableAdapter1
            // 
            this.employeesTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.CustomersTableAdapter = null;
            this.tableAdapterManager1.EmployeesTableAdapter = this.employeesTableAdapter1;
            this.tableAdapterManager1.MenuTableAdapter = null;
            this.tableAdapterManager1.OptionsTableAdapter = null;
            this.tableAdapterManager1.OrdersTableAdapter = null;
            this.tableAdapterManager1.TablesTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = BarPointOfSaleSystem.BarPOSSystemDataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // StaffLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 430);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.Button0);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Button6);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.Button9);
            this.Controls.Add(this.Button8);
            this.Controls.Add(this.Button7);
            this.Controls.Add(this.EmployeePasscodeLabel);
            this.Controls.Add(this.StaffPasscodeInputBox);
            this.Controls.Add(this.PasscodeLabel);
            this.Name = "StaffLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StaffSignClosing);
            this.Load += new System.EventHandler(this.StaffLogin_Load_1);
            this.Click += new System.EventHandler(this.PasscodeButtonClick);
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barPOSSystemDataDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PasscodeLabel;
        private System.Windows.Forms.TextBox StaffPasscodeInputBox;
        private System.Windows.Forms.Label EmployeePasscodeLabel;
        private System.Windows.Forms.Button Button7;
        private System.Windows.Forms.Button Button8;
        private System.Windows.Forms.Button Button9;
        private System.Windows.Forms.Button Button4;
        private System.Windows.Forms.Button Button5;
        private System.Windows.Forms.Button Button6;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Button Button3;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button Button0;
        private System.Windows.Forms.Button EnterButton;
        private BarPOSSystemDataDataSet barPOSSystemDataDataSet1;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private BarPOSSystemDataDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter1;
        private BarPOSSystemDataDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
    }
}

