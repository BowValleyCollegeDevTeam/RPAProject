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
            string str = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kara\Source\Repos\RPAProject\BarPointOfSaleSystem\BarPOSSystemData.mdf;Integrated Security=True";
            using (TableSelection getTable = new TableSelection())
            using (StaffLogin staff =new StaffLogin())
            using (SqlConnection myconnection = new SqlConnection(str))
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
                        //price = (decimal)Math.Round(price, 2);
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
            decimal totalBill = 0;
            for(int c = 0; c < mName.Count; c++)
            {
                billrtb.Text += (mName[c] +"   $" + menuprice[c] + Environment.NewLine);
            }
            //foreach (string n in mName)
            //{
            //    billrtb.Text += (n);
            //}
            foreach (decimal c in menuprice)
            {
                totalBill += c;
            }

            TotalNumberLBL.Text = totalBill.ToString();

            //GrabOrder();
            TotalPerBillNumberLBL.Text = "$" + TotalNumberLBL.Text;
            // sets the 2 totals the same until the bill spliter is used
            //MenuAddOn.checkedOption.Add(BillListBox.Items);
            foreach (var items in MenuAddOn.CheckedOption)
            {
                //BillListBox.Items.Add(items);
                using (SqlConnection myconnection = new SqlConnection(str))
                using (SqlDataAdapter receipt = new SqlDataAdapter($"SELECT * FROM Options JOIN Menu ON Menu.MenuId = Options.MenuId WHERE Options.[Name] = '{items}' AND Menu.menuName = '{menu.fooditem}'", myconnection))
                {
                    DataTable grabOrder = new DataTable();

                    myconnection.Open();
                    receipt.Fill(grabOrder);
                    myconnection.Close();

                    //for (int r = 0; r < grabOrder.Rows.Count; r++)
                    //{
                    //    decimal price = (decimal)grabOrder.Rows[r]["Price"];
                    //    price = (decimal)Math.Round(price,2);
                    //    billrtb.Text += ("   -" +items + "   $" + price + Environment.NewLine);
                        
                    //}


                }
            }

            
        }

        private void paybtn_Click(object sender, EventArgs e)
        {
            int i = 0;
            string str = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kara\Source\Repos\RPAProject\BarPointOfSaleSystem\BarPOSSystemData.mdf;Integrated Security=True";
            using (TableSelection getTable = new TableSelection())
            using (StaffLogin staff = new StaffLogin())
            using (SqlConnection myConnection = new SqlConnection(str))
            using (SqlDataAdapter tables = new SqlDataAdapter($"SELECT * FROM Tables WHERE TableNumber = '{getTable.tble}'", myConnection))
            using (SqlDataAdapter employees = new SqlDataAdapter($"SELECT * FROM Employees WHERE PIN = {staff.pin}", myConnection))

            {
                DataTable grabTables = new DataTable();
                DataTable grabEmployees = new DataTable();

                myConnection.Open();
                tables.Fill(grabTables);
                employees.Fill(grabEmployees);


                int employeesId = (int)grabEmployees.Rows[i]["EmployeeId"];
                int tableId = (int)grabTables.Rows[i]["TableId"];
                string employeeName = (string)grabEmployees.Rows[i]["FName"];
                using (SqlDataAdapter orders = new SqlDataAdapter($"SELECT * FROM Orders WHERE TableId = '{tableId}' AND EmployeeId = '{employeesId}'", myConnection))
                {
                    DataTable grabOrders = new DataTable();
                    orders.Fill(grabOrders);
                    for (int r = 0; r < grabOrders.Rows.Count; r++)
                    {
                        int orderid = (int)grabOrders.Rows[r]["OrderId"];


                        SqlCommand deleteOrders = new SqlCommand("DELETE FROM Orders WHERE OrderId = "+ orderid +";", myConnection);
                        deleteOrders.ExecuteNonQuery();
                    }
                    myConnection.Close();

                }
                
            }
            this.Close();
            
        }
    }
}
