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
    public partial class Menu : Form
    {
       
        public Menu()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            FoodBtns Fbtns = new FoodBtns();
            Fbtns.Dock = DockStyle.Top;
            panel1.Controls.Add(Fbtns);

            bool BtnClicked = true;
            //If Food Button is clicked again, the panel will be cleared.
            if (BtnClicked)
            {
                BtnClicked = false;
            }
            else
            {
                BtnClicked = true;
                panel1.Controls.Clear();
            }

        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            DrinksBtns Dbtns = new DrinksBtns();
            Dbtns.Dock = DockStyle.Top;
            panel2.Controls.Add(Dbtns);

            bool BtnClicked2 = true;
            //If Drink Button is clicked again, the panel will be cleared.
            if (BtnClicked2)
            {
                BtnClicked2 = false;
            }
            else
            {
                BtnClicked2 = true;
                panel2.Controls.Clear();
            }

        }

        private void CloseMenu(object sender, FormClosingEventArgs e)
        {
           
        }
    }
}
