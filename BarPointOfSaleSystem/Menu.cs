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
    public partial class Menu : Form
    {
        private string dbConnectionString;
        public static string dfooditem;

        public Menu()
        {
            InitializeComponent();
        }
        public string fooditem
        {
            get { return dfooditem; }
        }



        //Creates multiple buttons based on the foods table
        private void GetFood()
        {
            using (SqlConnection myConnection = new SqlConnection(dbConnectionString))
            using (SqlDataAdapter menuFood = new SqlDataAdapter($"SELECT * FROM Menu WHERE Category = 'Food'", myConnection))
            {
                DataTable getFood = new DataTable();

                myConnection.Open();
                menuFood.Fill(getFood);
                myConnection.Close();
                List<string> foodList = new List<string>();
                for (int f = 0; f < getFood.Rows.Count; f++)
                {
                    string foodName = (string)getFood.Rows[f]["menuName"];
                    foodList.Add(foodName);



                }

                for (int i = 0; i < foodList.Count; i++)
                {
                    Button foodButton = new Button();
                    foodButton.Text = foodList[i];
                    foodPanel.Controls.Add(foodButton);
                    foodButton.Dock = DockStyle.Left;
                    foodButton.Click += new EventHandler(foodButton_Click);
                    
                }
               

            }
        }



        //When a certain menu is clicked, the Menu add on will appear otherwise, the button will display 'added to order'
        private void foodButton_Click(object sender, EventArgs e)
        {
            int tableId;
            int employeeId;
            int menuId;
            string str = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lemon\source\repos\RPAProject\BarPointOfSaleSystem\BarPOSSystemData.mdf;Integrated Security=True";
            using (StaffLogin login = new StaffLogin())
            using (TableSelection selection = new TableSelection())
            using (SqlConnection myConnection = new SqlConnection(str))
            using (SqlDataAdapter menuFood = new SqlDataAdapter($"SELECT * FROM Menu WHERE Category = 'Food' AND Type != 'Starter' AND menuName = '{dfooditem}'", myConnection))
            using (SqlDataAdapter tableloc = new SqlDataAdapter($"SELECT * FROM [Tables] WHERE TableNumber = '{selection.tble}'", myConnection))
            using (SqlDataAdapter employee = new SqlDataAdapter($"SELECT * FROM Employees WHERE  PIN = {login.pin}", myConnection))
            {
                DataTable getFood = new DataTable();
                DataTable getDrinks = new DataTable();
                DataTable getemployees = new DataTable();



                myConnection.Open();
                menuFood.Fill(getFood);
                tableloc.Fill(getDrinks);
                employee.Fill(getemployees); 

                
                Button btn = (Button)sender;
                dfooditem = btn.Text;
                for (int f = 0; f < getFood.Rows.Count; f++)
                {
                    string foodName = (string)getFood.Rows[f]["menuName"];
                    if (dfooditem == foodName)
                    {
                        MenuAddOn mao = new MenuAddOn();
                        mao.Show();
                        mao.foodNamelbl.Text = dfooditem;

                        tableId = (int)getDrinks.Rows[f]["TableId"];
                        employeeId = (int)getemployees.Rows[f]["EmployeeId"];
                        menuId = (int)getFood.Rows[f]["MenuId"];

                        //MessageBox.Show(tableId.ToString());
                        //MessageBox.Show(employeeId.ToString());
                        //MessageBox.Show(menuId.ToString());


                        SqlCommand insertdrinks = new SqlCommand("INSERT INTO Orders (TableId,EmployeeId,MenuId) VALUES ('" + tableId + "' , '" + employeeId + "', '" + menuId + "');", myConnection);
                        insertdrinks.ExecuteNonQuery();

                        myConnection.Close();
                        MessageBox.Show(dfooditem + " has been added to Order");
                        // mao.foodNamelbl.TextAlign = ContentAlignment.TopCenter;
                        // mao.foodNamelbl.Location = new Point((Screen.PrimaryScreen.Bounds.Size.Width / 2) - (Size.Width / 2), (Screen.PrimaryScreen.Bounds.Size.Height / 2) - (Size.Height / 2));
                    }
      

                }

                //Button btn = (Button)sender;
                //string foodClicked = btn.Text;
                //MessageBox.Show(foodClicked);
            }
            
            using (StaffLogin login = new StaffLogin())
            using (TableSelection selection = new TableSelection())
            using (SqlConnection myConnection = new SqlConnection(str))
            using (SqlDataAdapter menuFood = new SqlDataAdapter($"SELECT * FROM Menu WHERE Category = 'Food' AND Type = 'Starter' AND menuName = '{dfooditem}'", myConnection))
            using (SqlDataAdapter tableloc = new SqlDataAdapter($"SELECT * FROM [Tables] WHERE TableNumber = '{selection.tble}'", myConnection))
            using (SqlDataAdapter employee = new SqlDataAdapter($"SELECT * FROM Employees WHERE  PIN = {login.pin}", myConnection))
            {
                DataTable getFood = new DataTable();
                DataTable getDrinks = new DataTable();
                DataTable getemployees = new DataTable();
                


                myConnection.Open();
                menuFood.Fill(getFood);
                tableloc.Fill(getDrinks);
                employee.Fill(getemployees);
              
                Button btn = (Button)sender;
                string foodClicked = btn.Text;
                for (int f = 0; f < getFood.Rows.Count; f++)
                {
                    string foodName = (string)getFood.Rows[f]["menuName"];
                    if (foodClicked == foodName)
                    {
                        tableId = (int)getDrinks.Rows[f]["TableId"];
                        employeeId = (int)getemployees.Rows[f]["EmployeeId"];
                        menuId = (int)getFood.Rows[f]["MenuId"];

                        //MessageBox.Show(tableId.ToString());
                        //MessageBox.Show(employeeId.ToString());
                        //MessageBox.Show(menuId.ToString());


                        SqlCommand insertdrinks = new SqlCommand("INSERT INTO Orders (TableId,EmployeeId,MenuId) VALUES ('" + tableId + "' , '" + employeeId + "', '" + menuId + "');", myConnection);
                        insertdrinks.ExecuteNonQuery();

                        myConnection.Close();
                        MessageBox.Show(foodClicked + " has been added to Order");
                    }

                }

            }
        }



        //Creates multiple buttons based on the drinks table
        private void GetDrinks()
        {
            using (SqlConnection myConnection = new SqlConnection(dbConnectionString))
            using (SqlDataAdapter menuDrinks = new SqlDataAdapter($"SELECT * FROM Menu WHERE Category = 'Drinks'", myConnection))
            {
                DataTable getDrinks = new DataTable();

                myConnection.Open();
                menuDrinks.Fill(getDrinks);
                myConnection.Close();
                List<string> drinksList = new List<string>();
                for (int f = 0; f < getDrinks.Rows.Count; f++)
                {
                    string drinksName = (string)getDrinks.Rows[f]["menuName"];
                    drinksList.Add(drinksName);



                }

                for (int i = 0; i < drinksList.Count; i++)
                {
                    Button drinksButton = new Button();
                    drinksButton.Text = drinksList[i];
                    drinksPanel.Controls.Add(drinksButton);
                    drinksButton.Dock = DockStyle.Left;
                    drinksButton.Click += new EventHandler(drinksButton_Click);

                }


            }
        }


        //Takes the selected drink and stores it into a new table
        private void drinksButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string drinkClicked = btn.Text;
            MessageBox.Show(drinkClicked + " has been added to order");

            int tableId;
            int employeeId;
            int menuId;
            string str = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lemon\source\repos\RPAProject\BarPointOfSaleSystem\BarPOSSystemData.mdf;Integrated Security=True";
            using (StaffLogin login = new StaffLogin())
            using (TableSelection section = new TableSelection())
            using (SqlConnection myConnection = new SqlConnection(str))
            using (SqlDataAdapter menuDrinks = new SqlDataAdapter($"SELECT * FROM [Tables] WHERE TableNumber = '{section.tble}'", myConnection))
            using (SqlDataAdapter employee = new SqlDataAdapter($"SELECT * FROM Employees WHERE  PIN = {login.pin}", myConnection))
            using (SqlDataAdapter menu = new SqlDataAdapter($"SELECT * FROM Menu WHERE  menuName = '{drinkClicked}'", myConnection))
            {

                DataTable getDrinks = new DataTable();
                DataTable getemployees = new DataTable();
                DataTable getmenu = new DataTable();


                myConnection.Open();
                menuDrinks.Fill(getDrinks);
                employee.Fill(getemployees);
                menu.Fill(getmenu);





                for (int row = 0; row < getDrinks.Rows.Count; row++)
                {

                    tableId = (int)getDrinks.Rows[row]["TableId"];
                    employeeId = (int)getemployees.Rows[row]["EmployeeId"];
                    menuId = (int)getmenu.Rows[row]["MenuId"];

                    //MessageBox.Show(tableId.ToString());
                    //MessageBox.Show(employeeId.ToString());
                    //MessageBox.Show(menuId.ToString());


                    SqlCommand insertdrinks = new SqlCommand("INSERT INTO Orders (TableId,EmployeeId,MenuId) VALUES ('" + tableId+ "' , '" + employeeId + "', '" + menuId + "');", myConnection);
                    insertdrinks.ExecuteNonQuery();

                    myConnection.Close();
                    //insertdrinks();
                }


                
                

            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'barPOSSystemDataDataSet.Menu' table. You can move, or remove it, as needed.
           // this.menuTableAdapter.Fill(this.barPOSSystemDataDataSet.Menu);
            // TODO: This line of code loads data into the 'barPOSSystemDataDataSet.Menu' table. You can move, or remove it, as needed.
            //this.menuTableAdapter.Fill(this.barPOSSystemDataDataSet.Menu);
            // TODO: This line of code loads data into the 'barPOSSystemDataDataSet.Menu' table. You can move, or remove it, as needed.
            // this.menuTableAdapter.Fill(this.barPOSSystemDataDataSet.Menu);
            dbConnectionString = ConfigurationManager.ConnectionStrings["BarPointOfSaleSystem.Properties.Settings.BarPOSSystemDataConnectionString"].ConnectionString;

            GetFood();
            GetDrinks();
          

        }


    }
}
