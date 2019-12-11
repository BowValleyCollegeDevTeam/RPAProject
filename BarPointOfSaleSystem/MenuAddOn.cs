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
    public partial class MenuAddOn : Form
    {
        private string dbConnectionString;
        public MenuAddOn()
        {
            InitializeComponent();
        }



        private void GetOptions()
        {

            using (Menu menu = new Menu())
            using (SqlConnection myConnection = new SqlConnection(dbConnectionString))
            using (SqlDataAdapter menuOptions = new SqlDataAdapter($"SELECT * FROM Options JOIN Menu ON Options.MenuId = Menu.MenuId WHERE IsSide= 0 AND Menu.menuName ='{menu.fooditem}'", myConnection))
            {
                DataTable getOptions = new DataTable();
                List<string> OptList = new List<string>();
                myConnection.Open();
                menuOptions.Fill(getOptions);
                myConnection.Close();
                for (int f = 0; f < getOptions.Rows.Count; f++)
                {
                    string foodname = (string)getOptions.Rows[f]["menuName"];
                    string Options = (string)getOptions.Rows[f]["Name"];
                    OptList.Add(Options);
                }

                for (int i = 0; i < OptList.Count; i++)
                {
                    CheckBox OptCheck = new CheckBox();
                    OptCheck.Text = OptList[i];
                    panel1.Controls.Add(OptCheck);
                    OptCheck.Dock = DockStyle.Top;

                }
                

            }
        }

        private void GetSides()
        {
           
            using (Menu menu = new Menu())
            using (SqlConnection myConnection = new SqlConnection(dbConnectionString))
            using (SqlDataAdapter menuSides = new SqlDataAdapter($"SELECT * FROM Options JOIN Menu ON Options.MenuId = Menu.MenuId WHERE IsSide= 1 AND Menu.menuName ='{menu.fooditem}'", myConnection))
            {
                DataTable getSides = new DataTable();

                myConnection.Open();
                menuSides.Fill(getSides);
                myConnection.Close();
                List<string> SideList = new List<string>();
                for (int f = 0; f < getSides.Rows.Count; f++)
                {
                    string foodname = (string)getSides.Rows[f]["menuName"];
                    string Sides = (string)getSides.Rows[f]["Name"];
                    SideList.Add(Sides);
                }

                for (int i = 0; i < SideList.Count; i++)
                {
                    CheckBox SideCheck = new CheckBox();
                    SideCheck.Text = SideList[i];
                    panel2.Controls.Add(SideCheck);
                    SideCheck.Dock = DockStyle.Top;

                }

            }
        }
        public static List<string> checkedOption = new List<string>();
        public static List<string> CheckedOption
        {
            get {return checkedOption; }
        }


        private void MenuAddOn_Load(object sender, EventArgs e)
        {
            dbConnectionString = ConfigurationManager.ConnectionStrings["BarPointOfSaleSystem.Properties.Settings.BarPOSSystemDataConnectionString"].ConnectionString;
            GetOptions();
            GetSides();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control c in panel1.Controls)
            {
                if (c is CheckBox && ((CheckBox)c).Checked)
                {
                    checkedOption.Add(c.Text);
                }
            }
            foreach (Control c in panel2.Controls)
            {
                if (c is CheckBox &&((CheckBox)c).Checked)
                {
                    checkedOption.Add(c.Text);
                }
            }
            this.Hide();
        }
    }
}
