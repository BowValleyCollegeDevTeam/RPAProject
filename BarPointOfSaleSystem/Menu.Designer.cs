namespace BarPointOfSaleSystem
{
    partial class Menu
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
            this.label1 = new System.Windows.Forms.Label();
            this.foodPanel = new System.Windows.Forms.Panel();
            this.drinksPanel = new System.Windows.Forms.Panel();
            this.bindingSourceMenu = new System.Windows.Forms.BindingSource(this.components);
            this.barPOSSystemDataDataSet = new BarPointOfSaleSystem.BarPOSSystemDataDataSet();
            this.menuTableAdapter = new BarPointOfSaleSystem.BarPOSSystemDataDataSetTableAdapters.MenuTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barPOSSystemDataDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(317, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bar Name";
            // 
            // foodPanel
            // 
            this.foodPanel.AutoScroll = true;
            this.foodPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.foodPanel.Location = new System.Drawing.Point(21, 124);
            this.foodPanel.Name = "foodPanel";
            this.foodPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.foodPanel.Size = new System.Drawing.Size(841, 155);
            this.foodPanel.TabIndex = 16;
            // 
            // drinksPanel
            // 
            this.drinksPanel.AutoScroll = true;
            this.drinksPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drinksPanel.Location = new System.Drawing.Point(21, 364);
            this.drinksPanel.Name = "drinksPanel";
            this.drinksPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.drinksPanel.Size = new System.Drawing.Size(841, 155);
            this.drinksPanel.TabIndex = 19;
            // 
            // bindingSourceMenu
            // 
            this.bindingSourceMenu.DataMember = "Menu";
            this.bindingSourceMenu.DataSource = this.barPOSSystemDataDataSet;
            // 
            // barPOSSystemDataDataSet
            // 
            this.barPOSSystemDataDataSet.DataSetName = "BarPOSSystemDataDataSet";
            this.barPOSSystemDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuTableAdapter
            // 
            this.menuTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Food";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "Drinks";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 543);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.drinksPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.foodPanel);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barPOSSystemDataDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel foodPanel;
        private System.Windows.Forms.Panel drinksPanel;
        private System.Windows.Forms.BindingSource bindingSourceMenu;
        private BarPOSSystemDataDataSet barPOSSystemDataDataSet;
        private BarPOSSystemDataDataSetTableAdapters.MenuTableAdapter menuTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}