using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace BarPointOfSaleSystem
{
    public partial class Receipt : Form
    {
        string dbconnectionstring;
        public Receipt()
        {
            InitializeComponent();
        }


        private void Billsplitways_ValueChanged(object sender, EventArgs e)
        {
            var splitways = Billsplitways.Value + 1;
            // each number on the num up down bar  will add one because if the bar is at one you'll be spliting with another person etc.
            var total = Convert.ToDecimal(TotalNumberLBL.Text);

            var eachbill = total / splitways;
            eachbill = Math.Round(eachbill, 2);

            if (splitways > 0)
            {
                TotalPerBillNumberLBL.Text = "$"+ eachbill.ToString();
            }
            else
            {
                TotalPerBillNumberLBL.Text = TotalNumberLBL.Text;
            }
            // this if statement is incase num updown is set to zero
        }

        private void Receipt_Load(object sender, EventArgs e)
        {
            GrabOrder();
            TotalPerBillNumberLBL.Text = "$" + TotalNumberLBL.Text;
            // sets the 2 totals the same until the bill spliter is used
            
            
        }

        private void GrabOrder()
        {
            dbconnectionstring = ConfigurationManager.ConnectionStrings["BarPointOfSaleSystem.Properties.Settings.BarPOSSystemDataConnectionString"].ConnectionString;
            using (SqlConnection myconnection = new SqlConnection(dbconnectionstring))
            using (SqlDataAdapter receipt = new SqlDataAdapter("SELECT * FROM Orders", myconnection))
            {
                DataTable grabOrder = new DataTable();

                myconnection.Open();
                receipt.Fill(grabOrder);
                myconnection.Close();

                for(int i = 0; i < grabOrder.Rows.Count; i++)
                {
                    BillListBox.Items.Add(grabOrder);
                }
            }

            // go into the database and grab the selected items for the certain table number
            var totalamount = 65.55 + 36.75;
            totalamount = Math.Round(totalamount, 2);

            TotalNumberLBL.Text = totalamount.ToString();
        }
    }
}
