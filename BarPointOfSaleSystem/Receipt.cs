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
            List<decimal> menuprice = new List<decimal>();
            List<string> mName = new List<string>();
            int i = 0;
            Menu menu = new Menu();
            dbconnectionstring = ConfigurationManager.ConnectionStrings["BarPointOfSaleSystem.Properties.Settings.BarPOSSystemDataConnectionString"].ConnectionString;
            using (TableSelection getTable = new TableSelection())
            using (StaffLogin staff =new StaffLogin())
            using (SqlConnection myconnection = new SqlConnection(dbconnectionstring))
            using (SqlDataAdapter tables = new SqlDataAdapter($"SELECT * FROM Tables WHERE TableNumber = '{getTable.tble}'", myconnection))
            using (SqlDataAdapter employees = new SqlDataAdapter($"SELECT * FROM Employees WHERE PIN = {staff.pin}", myconnection))

            {
                DataTable grabTables = new DataTable();
                DataTable grabEmployees = new DataTable();

                myconnection.Open();
                tables.Fill(grabTables);
                employees.Fill(grabEmployees);


                int employeesId = (int)grabEmployees.Rows[i]["EmployeeId"];
                int tableId = (int)grabTables.Rows[i]["TableId"];
                string employeeName = (string)grabEmployees.Rows[i]["FName"];
                using (SqlDataAdapter orders = new SqlDataAdapter($"SELECT * FROM Orders JOIN Menu ON Orders.MenuId = Menu.MenuId WHERE TableId = '{tableId}' AND EmployeeId = '{employeesId}'", myconnection))
                {
                    DataTable grabOrders = new DataTable();
                    orders.Fill(grabOrders);
                    for (int r = 0; r < grabOrders.Rows.Count; r++)
                    {
                        string menuname = (string)grabOrders.Rows[r]["menuName"];
                        decimal price = (decimal)grabOrders.Rows[r]["Price"];
                        price = (decimal)Math.Round(price, 2);
                        menuprice.Add(price);
                        mName.Add(menuname);

                        
                        //menuprice.Add(price);
                        //mName.Add(menu.fooditem);
                        //billrtb.Text += (menu.fooditem + "   $" + price + Environment.NewLine);
                    }

                    EmployeeNameLBL.Text = "Served By: " + employeeName;
                }
                myconnection.Close();
            }
            
            foreach (string n in mName)
            {
                foreach (decimal c in menuprice)
                {
                    billrtb.Text += (Environment.NewLine +  n + "   $" + c + Environment.NewLine);
                }
            }
            //GrabOrder();
            TotalPerBillNumberLBL.Text = "$" + TotalNumberLBL.Text;
            // sets the 2 totals the same until the bill spliter is used
            //MenuAddOn.checkedOption.Add(BillListBox.Items);
            foreach (var items in MenuAddOn.CheckedOption)
            {
                //BillListBox.Items.Add(items);

                dbconnectionstring = ConfigurationManager.ConnectionStrings["BarPointOfSaleSystem.Properties.Settings.BarPOSSystemDataConnectionString"].ConnectionString;
                using (SqlConnection myconnection = new SqlConnection(dbconnectionstring))
                using (SqlDataAdapter receipt = new SqlDataAdapter($"SELECT * FROM Options JOIN Menu ON Menu.MenuId = Options.MenuId WHERE Options.[Name] = '{items}' AND Menu.menuName = '{menu.fooditem}'", myconnection))
                {
                    DataTable grabOrder = new DataTable();

                    myconnection.Open();
                    receipt.Fill(grabOrder);
                    myconnection.Close();

                    for (int r = 0; r < grabOrder.Rows.Count; r++)
                    {
                        decimal price = (decimal)grabOrder.Rows[r]["Price"];
                        price = (decimal)Math.Round(price,2);
                        billrtb.Text += ("   -" +items + "   $" + price + Environment.NewLine);
                        
                    }


                }
            }

            
        }

        private void GrabOrder()
        {
            dbconnectionstring = ConfigurationManager.ConnectionStrings["BarPointOfSaleSystem.Properties.Settings.BarPOSSystemDataConnectionString"].ConnectionString;
            using (SqlConnection myconnection = new SqlConnection(dbconnectionstring))
            using (SqlDataAdapter receipt = new SqlDataAdapter("SELECT Category, [Name], Price FROM Menu Join Orders ON Menu.MenuId = Orders.MenuId Join Employees on Employees.EmployeeId = Orders.EmployeeId join[Tables] on[Tables].TableId = Orders.TableId join Customers on Customers.CustomerId = Orders.CustomerId WHERE Orders.TableId = 10; ", myconnection))
            {
                DataTable grabOrder = new DataTable();

                myconnection.Open();
                receipt.Fill(grabOrder);
                myconnection.Close();


                List<decimal> prices = new List<decimal>();
                for (int i = 0; i < grabOrder.Rows.Count; i++)
                {
                    string name = (string)grabOrder.Rows[i]["Name"];
                    string cat = (string)grabOrder.Rows[i]["Category"];
                    decimal price = (decimal)grabOrder.Rows[i]["Price"];

                    billrtb.Text += ($"{name,-5} {cat,-5} {price,-5}");

                    prices.Add(price);
                   


                }
                // go into the database and grab the selected items for the certain table number
                var totalamount = prices.Sum();
                totalamount = Math.Round(totalamount, 2);

                TotalNumberLBL.Text = totalamount.ToString();
            }

        }
    }
}
