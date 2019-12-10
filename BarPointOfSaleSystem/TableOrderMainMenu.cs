using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarPointOfSaleSystem
{
    public partial class TableOrderMainMenu : UserControl
    {
        
        public TableOrderMainMenu()
        {
            InitializeComponent();
       
        }

        private void TableOrderMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void AddOrderBTN_Click(object sender, EventArgs e)
        {

        }


        private void AddOrderBTN_Click(object sender, EventArgs e)
        {
            new Menu().Show();
        }

        private void PrintBillBTN_Click(object sender, EventArgs e)
        {
            new Receipt().Show();
        }
    }
}
