﻿using System;
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

        private void button1_Click(object sender, EventArgs e)
        {
            FoodBtns Fbtns = new FoodBtns();
            Fbtns.Dock = DockStyle.Top;
            foodPanel.Controls.Add(Fbtns);

            bool BtnClicked = true;
            //If Food Button is clicked again, the panel will be cleared.
            if (BtnClicked)
            {
                BtnClicked = false;
            }
            else
            {
                BtnClicked = true;
                foodPanel.Controls.Clear();
            }

        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            DrinksBtns Dbtns = new DrinksBtns();
            Dbtns.Dock = DockStyle.Top;
            drinksPanel.Controls.Add(Dbtns);

            bool BtnClicked2 = true;
            //If Drink Button is clicked again, the panel will be cleared.
            if (BtnClicked2)
            {
                BtnClicked2 = false;
            }
            else
            {
                BtnClicked2 = true;
                drinksPanel.Controls.Clear();
            }

        }

        private void CloseMenu(object sender, FormClosingEventArgs e)
        {
           
        }
     
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

        private void foodButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection myConnection = new SqlConnection(dbConnectionString))
            using (SqlDataAdapter menuFood = new SqlDataAdapter($"SELECT * FROM Menu WHERE Category = 'Food' AND Type != 'Starter'", myConnection))
            {
                DataTable getFood = new DataTable();

                myConnection.Open();
                menuFood.Fill(getFood);
                myConnection.Close();
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
                       // mao.foodNamelbl.TextAlign = ContentAlignment.TopCenter;
                       // mao.foodNamelbl.Location = new Point((Screen.PrimaryScreen.Bounds.Size.Width / 2) - (Size.Width / 2), (Screen.PrimaryScreen.Bounds.Size.Height / 2) - (Size.Height / 2));
                    }
      

                }

                //Button btn = (Button)sender;
                //string foodClicked = btn.Text;
                //MessageBox.Show(foodClicked);
            }
            using (SqlConnection myConnection = new SqlConnection(dbConnectionString))
            using (SqlDataAdapter menuFood = new SqlDataAdapter($"SELECT * FROM Menu WHERE Category = 'Food' AND Type = 'Starter'", myConnection))
            {
                DataTable getFood = new DataTable();

                myConnection.Open();
                menuFood.Fill(getFood);
                myConnection.Close();
                Button btn = (Button)sender;
                string foodClicked = btn.Text;
                for (int f = 0; f < getFood.Rows.Count; f++)
                {
                    string foodName = (string)getFood.Rows[f]["menuName"];
                    if (foodClicked == foodName)
                    {
                        MessageBox.Show(foodClicked + " has been added to Order");
                    }

                }

            }
        }

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

        private void drinksButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string drinkClicked = btn.Text;
            MessageBox.Show(drinkClicked);



            using (StaffLogin staffLogin = new StaffLogin())
            using (TableSelection tableSelection = new TableSelection())
            {
                string str = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\heart\repos\RPAProject\BarPointOfSaleSystem\BarPOSSystemData.mdf;Integrated Security=True";
                SqlConnection myConnection = new SqlConnection(str);
                myConnection.Open();

                string tab = tableSelection.tble;
                string emp = staffLogin.pin;

                SqlCommand getmenuid = new SqlCommand("SELECT * FROM Menu",myConnection);
                SqlCommand gettableid = new SqlCommand("SELECT * FROM [Tables]",myConnection);
                SqlCommand getemployeeid = new SqlCommand("SELECT * FROM Employees",myConnection);
              

                SqlDataAdapter getmen = new SqlDataAdapter(getmenuid);
                SqlDataAdapter gettable = new SqlDataAdapter(gettableid);
                SqlDataAdapter getemp = new SqlDataAdapter(getemployeeid);



                DataTable dataTable = new DataTable();

               

                
                getmen.Fill(dataTable);
                gettable.Fill(dataTable);
                getemp.Fill(dataTable);
                for(int row = 0; row < dataTable.Rows.Count; row++)
                {
                    int m = (int)dataTable.Rows[row]["MenuId"];
                    int t = (int)dataTable.Rows[row]["TableId"];
                    int em = (int)dataTable.Rows[row]["EmployeeId"];

                    
                    SqlCommand insertdrinks = new SqlCommand("INSERT INTO Orders (TableId,EmployeeId,MenuId) VALUES ('" + t + "' , '" + t + "', '" + m + "');", myConnection);
                    //" WHERE Menu.menuName = '" + drinkClicked + "' AND [Tables].TableNumber = '" + tab + "' AND Employees.PIN = '"+emp+"'", myConnection))



                  

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
