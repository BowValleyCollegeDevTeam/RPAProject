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
            //GrabOrder();
            TotalPerBillNumberLBL.Text = "$" + TotalNumberLBL.Text;
            // sets the 2 totals the same until the bill spliter is used
            
            
        }

        private void GrabOrder()
        {
            dbconnectionstring = ConfigurationManager.ConnectionStrings["BarPointOfSaleSystem.Properties.Settings.BarPOSSystemDataConnectionString"].ConnectionString;
            using (SqlConnection myconnection = new SqlConnection(dbconnectionstring))
            using (SqlDataAdapter receipt = new SqlDataAdapter("SELECT Category, [Name], Price, TableNumber, FName + ' ' + LName As FullName FROM Menu Join Orders ON Menu.MenuId = Orders.MenuId Join Employees on Employees.EmployeeId = Orders.EmployeeId join[Tables] on[Tables].TableId = Orders.TableId join Customers on Customers.CustomerId = Orders.CustomerId WHERE Orders.TableId = 10; ", myconnection))
            {
                DataTable grabOrder = new DataTable();

                myconnection.Open();
                receipt.Fill(grabOrder);
                myconnection.Close();

                string EmployeeName;
                List<decimal> prices = new List<decimal>();
                for (int i = 0; i < grabOrder.Rows.Count; i++)
                {
                    string name = (string)grabOrder.Rows[i]["Name"];
                    string cat = (string)grabOrder.Rows[i]["Category"];
                    decimal price = (decimal)grabOrder.Rows[i]["Price"];
                    string tab = (string)grabOrder.Rows[i]["TableNumber"];
                    string empname = (string)grabOrder.Rows[i]["FullName"];

                    
                    BillListBox.Items.Add($"{name,-5} {cat,-5} {price,-5}");
                    
                    EmployeeNameLBL.Text = "Served By: " + empname;


                    TableNumberForBillLBL.Text = $"{tab}";

                    prices.Add(price);
                   


                }
                //EmployeeNameLBL.Text = "Served By: " + EmployeeName;

                // go into the database and grab the selected items for the certain table number
                var totalamount = prices.Sum();
                totalamount = Math.Round(totalamount, 2);

                TotalNumberLBL.Text = totalamount.ToString();
            }

        }

        
    }
}
