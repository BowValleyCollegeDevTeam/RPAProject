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
            this.TableNumberLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TableNumberLabel
            // 
            this.TableNumberLabel.AutoSize = true;
            this.TableNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableNumberLabel.Location = new System.Drawing.Point(5, 0);
            this.TableNumberLabel.Name = "TableNumberLabel";
            this.TableNumberLabel.Size = new System.Drawing.Size(233, 39);
            this.TableNumberLabel.TabIndex = 20;
            this.TableNumberLabel.Text = "Table Number";
            // 
            // TableOrderMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TableNumberLabel);
            this.Name = "TableOrderMainMenu";
            this.Size = new System.Drawing.Size(243, 235);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TableNumberLabel;
    }
}
