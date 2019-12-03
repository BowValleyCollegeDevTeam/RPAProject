using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarPointOfSaleSystem
{
    public partial class TableSelection : Form
    {

        public TableSelection()
        {
            InitializeComponent();
        }

        private void FormCenterToScreen()
        {
            //Repositions The Form To The Center Of The Screen With The New Width.
            Location = new Point((Screen.PrimaryScreen.Bounds.Size.Width / 2) - (Size.Width / 2), (Screen.PrimaryScreen.Bounds.Size.Height / 2) - (Size.Height / 2));
        }

        private void TableSelection_Load(object sender, EventArgs e)
        {

        }

        private void TableSelectionClosing(object sender, FormClosingEventArgs e)
        {
            var StaffLogin = new StaffLogin();
            this.Hide();
            StaffLogin.Show();
        }

        private void TableSelectionClick(object sender, EventArgs e)
        {
            //Changes The Width Of The Form When A Table Is Selected
            Width = 1500;
            FormCenterToScreen();

            Panel TableOrderMenuPanel = new Panel();
            TableOrderMenuPanel.Width = 300;
            TableOrderMenuPanel.Dock = DockStyle.Right;
            TableOrderMenuPanel.BorderStyle = BorderStyle.Fixed3D;

            this.Controls.Add(TableOrderMenuPanel);

            var tableOrderMainMenu = new TableOrderMainMenu();
            tableOrderMainMenu.Dock = DockStyle.Fill;
            TableOrderMenuPanel.Controls.Add(tableOrderMainMenu);

        }

        private void TableSelectionMouseHover(object sender, EventArgs e)
        {
            if (sender == Table1PictureBox)
            {
                Table1PictureBox.Image = Properties.Resources.TableActive;
            }

            else if (sender == Table2PictureBox)
            {
                Table2PictureBox.Image = Properties.Resources.TableActive;
            }

            else if (sender == Table3PictureBox)
            {
                Table3PictureBox.Image = Properties.Resources.TableActive;
            }

            else if (sender == Table4PictureBox)
            {
                Table4PictureBox.Image = Properties.Resources.TableActive;
            }

            else if (sender == Table5PictureBox)
            {
                Table5PictureBox.Image = Properties.Resources.TableActive;
            }

            else if (sender == Table6PictureBox)
            {
                Table6PictureBox.Image = Properties.Resources.TableActive;
            }

            else if (sender == Table7PictureBox)
            {
                Table7PictureBox.Image = Properties.Resources.TableActive;
            }

            else if (sender == Table8PictureBox)
            {
                Table8PictureBox.Image = Properties.Resources.TableActive;
            }

            else if (sender == Table9PictureBox)
            {
                Table9PictureBox.Image = Properties.Resources.TableActive;
            }

            else if (sender == BarStool1PictureBox)
            {
                BarStool1PictureBox.Image = Properties.Resources.BarStoolActive;
            }

            else if (sender == BarStool2PictureBox)
            {
                BarStool2PictureBox.Image = Properties.Resources.BarStoolActive;
            }

            else if (sender == BarStool3PictureBox)
            {
                BarStool3PictureBox.Image = Properties.Resources.BarStoolActive;
            }

            else if (sender == BarStool4PictureBox)
            {
                BarStool4PictureBox.Image = Properties.Resources.BarStoolActive;
            }

        }

        private void TableSelcetionMouseLeave(object sender, EventArgs e)
        {
            if (sender == Table1PictureBox)
            {
                Table1PictureBox.Image = Properties.Resources.TableInActive;
            }
            else if (sender == Table2PictureBox)
            {
                Table2PictureBox.Image = Properties.Resources.TableInActive;
            }

            else if (sender == Table3PictureBox)
            {
                Table3PictureBox.Image = Properties.Resources.TableInActive;
            }

            else if (sender == Table4PictureBox)
            {
                Table4PictureBox.Image = Properties.Resources.TableInActive;
            }

            else if (sender == Table5PictureBox)
            {
                Table5PictureBox.Image = Properties.Resources.TableInActive;
            }

            else if (sender == Table6PictureBox)
            {
                Table6PictureBox.Image = Properties.Resources.TableInActive;
            }

            else if (sender == Table7PictureBox)
            {
                Table7PictureBox.Image = Properties.Resources.TableInActive;
            }

            else if (sender == Table8PictureBox)
            {
                Table8PictureBox.Image = Properties.Resources.TableInActive;
            }

            else if (sender == Table9PictureBox)
            {
                Table9PictureBox.Image = Properties.Resources.TableInActive;
            }

            else if (sender == BarStool1PictureBox)
            {
                BarStool1PictureBox.Image = Properties.Resources.BarStoolInActive;
            }

            else if (sender == BarStool2PictureBox)
            {
                BarStool2PictureBox.Image = Properties.Resources.BarStoolInActive;
            }

            else if (sender == BarStool3PictureBox)
            {
                BarStool3PictureBox.Image = Properties.Resources.BarStoolInActive;
            }

            else if (sender == BarStool4PictureBox)
            {
                BarStool4PictureBox.Image = Properties.Resources.BarStoolInActive;
            }
        }
    }
}
