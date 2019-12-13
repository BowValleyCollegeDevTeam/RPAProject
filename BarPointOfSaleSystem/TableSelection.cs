﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace BarPointOfSaleSystem
{
    public partial class TableSelection : Form
    {
        private string dbConnectionString;
        
        

        public static Label TableName = new Label();

        public TableSelection()
        {
            InitializeComponent();
        }
      
        public string tble
        {
            get { return TableName.Text; }
        }

        private void FormCenterToScreen()
        {
            //Repositions The Form To The Center Of The Screen With The New Width.
            Location = new Point((Screen.PrimaryScreen.Bounds.Size.Width / 2) - (Size.Width / 2), (Screen.PrimaryScreen.Bounds.Size.Height / 2) - (Size.Height / 2));
        }

        private void TableSelection_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'barPOSSystemDataDataSet.Employees' table. You can move, or remove it, as needed.
            //this.employeesTableAdapter.Fill(this.barPOSSystemDataDataSet.Employees);
            getTopBar();



        }


        //Re-opens staff log in when the table selection is closed
        private void TableSelectionClosing(object sender, FormClosingEventArgs e)
        {
            var StaffLogin = new StaffLogin();
            this.Hide();
            StaffLogin.Show();
        }


        // Displays Server's name and current time at the top of application after server signs in
        public void getTopBar()
        {
            dbConnectionString = ConfigurationManager.ConnectionStrings["BarPointOfSaleSystem.Properties.Settings.BarPOSSystemDataConnectionString"].ConnectionString;
            string str = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\heart\repos\RPAProject\BarPointOfSaleSystem\BarPOSSystemData.mdf;Integrated Security=True";
            using (StaffLogin login = new StaffLogin())
            using (SqlConnection myConnection = new SqlConnection(str))
            using (SqlDataAdapter employeePin = new SqlDataAdapter($"SELECT * FROM Employees WHERE PIN = {login.pin}", myConnection))
            {
                DataTable userPin = new DataTable();

                myConnection.Open();
                employeePin.Fill(userPin);
                myConnection.Close();
                for (int row = 0; row < userPin.Rows.Count; row++)
                {
                    string FirstName = (string)userPin.Rows[row]["FName"];
                    string LastName = (string)userPin.Rows[row]["LName"];
                    this.topInfoBar1.StaffNameLabel.Text = "Name: " + FirstName + " " + LastName;

                }



            }
        }


        //Creates the Order Menu Selection
        private void CreateOrderMenu()
        {
            //Changes The Width Of The Form When A Table Is Selected
            Width = 1500;
            FormCenterToScreen();
            Panel TableOrderMenuPanel = new Panel();
            TableOrderMenuPanel.Width = 200;
            TableOrderMenuPanel.Dock = DockStyle.Right;
            TableOrderMenuPanel.BorderStyle = BorderStyle.Fixed3D;

            var tableOrderMainMenu = new TableOrderMainMenu();
            tableOrderMainMenu.Dock = DockStyle.Fill;

            this.Controls.Add(TableOrderMenuPanel);
            TableOrderMenuPanel.Controls.Add(tableOrderMainMenu);
            TableName.Dock = DockStyle.Top;
            tableOrderMainMenu.Controls.Add(TableName);
            TableName.TextAlign = ContentAlignment.TopCenter;
        }


        //Displays the Order Menu on the right side of the table selections where you can start
        //adding Menu items
        private void TableSelectionClick(object sender, EventArgs e)
        {
            
            if (sender == Table1 && TableName.Text == "")
            {
                TableName.Text = Table1.Name;
                CreateOrderMenu();
                
            }

            else if (sender == Table2 && TableName.Text == "")
            {
                TableName.Text = Table2.Name;
                CreateOrderMenu();
                
            }

            else if (sender == Table3 && TableName.Text == "")
            {
                TableName.Text = Table3.Name;
                CreateOrderMenu();
                
            }

            else if (sender == Table4 && TableName.Text == "")
            {
                TableName.Text = Table4.Name;
                CreateOrderMenu();
                
            }

            else if (sender == Table5 && TableName.Text == "")
            {
                TableName.Text = Table5.Name;
                CreateOrderMenu();
                
            }

            else if (sender == Table6 && TableName.Text == "")
            {
                TableName.Text = Table6.Name;
                CreateOrderMenu();
               
            }

            else if (sender == Table7 && TableName.Text == "")
            {
                TableName.Text = Table7.Name;
                CreateOrderMenu();
               
            }

            else if (sender == Table8 && TableName.Text == "")
            {
                TableName.Text = Table8.Name;
                CreateOrderMenu();
                
            }

            else if (sender == Table9 && TableName.Text == "")
            {
                TableName.Text = Table9.Name;
                CreateOrderMenu();
                
            }

            else if (sender == BarStool1 && TableName.Text == "")
            {
                TableName.Text = BarStool1.Name;
                CreateOrderMenu();
                
            }

            else if (sender == BarStool2 && TableName.Text == "")
            {
                TableName.Text = BarStool2.Name;
                CreateOrderMenu();
                
            }

            else if (sender == BarStool3 && TableName.Text == "")
            {
                TableName.Text = BarStool3.Name;
                CreateOrderMenu();
                
            }

            else if (sender == BarStool4 && TableName.Text == "")
            {
                TableName.Text = BarStool4.Name;
                CreateOrderMenu();
               
            }

            else
            {
                try
                {
                    this.Controls.RemoveAt(15);
                    TableName.Text = "";
                }

                catch { }
            }
        }
      


        //Sets the hover image for the table selections
        private void TableSelectionMouseHover(object sender, EventArgs e)
        {
            if (sender == Table1)
            {
                Table1.Image = Properties.Resources.TableActive;
            }

            else if (sender == Table2)
            {
                Table2.Image = Properties.Resources.TableActive;
            }

            else if (sender == Table3)
            {
                Table3.Image = Properties.Resources.TableActive;
            }

            else if (sender == Table4)
            {
                Table4.Image = Properties.Resources.TableActive;
            }

            else if (sender == Table5)
            {
                Table5.Image = Properties.Resources.TableActive;
            }

            else if (sender == Table6)
            {
                Table6.Image = Properties.Resources.TableActive;
            }

            else if (sender == Table7)
            {
                Table7.Image = Properties.Resources.TableActive;
            }

            else if (sender == Table8)
            {
                Table8.Image = Properties.Resources.TableActive;
            }

            else if (sender == Table9)
            {
                Table9.Image = Properties.Resources.TableActive;
            }

            else if (sender == BarStool1)
            {
                BarStool1.Image = Properties.Resources.BarStoolActive;
            }

            else if (sender == BarStool2)
            {
                BarStool2.Image = Properties.Resources.BarStoolActive;
            }

            else if (sender == BarStool3)
            {
                BarStool3.Image = Properties.Resources.BarStoolActive;
            }

            else if (sender == BarStool4)
            {
                BarStool4.Image = Properties.Resources.BarStoolActive;
            }

        }



        //Image is set to default when the user stops hovering on the table
        private void TableSelcetionMouseLeave(object sender, EventArgs e)
        {
            if (sender == Table1)
            {
                Table1.Image = Properties.Resources.TableInActive;
            }
            else if (sender == Table2)
            {
                Table2.Image = Properties.Resources.TableInActive;
            }

            else if (sender == Table3)
            {
                Table3.Image = Properties.Resources.TableInActive;
            }

            else if (sender == Table4)
            {
                Table4.Image = Properties.Resources.TableInActive;
            }

            else if (sender == Table5)
            {
                Table5.Image = Properties.Resources.TableInActive;
            }

            else if (sender == Table6)
            {
                Table6.Image = Properties.Resources.TableInActive;
            }

            else if (sender == Table7)
            {
                Table7.Image = Properties.Resources.TableInActive;
            }

            else if (sender == Table8)
            {
                Table8.Image = Properties.Resources.TableInActive;
            }

            else if (sender == Table9)
            {
                Table9.Image = Properties.Resources.TableInActive;
            }

            else if (sender == BarStool1)
            {
                BarStool1.Image = Properties.Resources.BarStoolInActive;
            }

            else if (sender == BarStool2)
            {
                BarStool2.Image = Properties.Resources.BarStoolInActive;
            }

            else if (sender == BarStool3)
            {
                BarStool3.Image = Properties.Resources.BarStoolInActive;
            }

            else if (sender == BarStool4)
            {
                BarStool4.Image = Properties.Resources.BarStoolInActive;
            }
        }
    }
}
