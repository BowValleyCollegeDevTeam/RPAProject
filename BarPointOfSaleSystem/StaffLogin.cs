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
    public partial class StaffLogin : Form
    {
        private string dbConnectionString;

        public StaffLogin()
        {
            InitializeComponent();
        }

        private void StaffLogin_Load(object sender, EventArgs e)
        {
            
        }
        public void getEmployeePinLogin()
        {
            dbConnectionString = ConfigurationManager.ConnectionStrings["BarPointOfSaleSystem.Properties.Settings.BarPOSSystemDataConnectionString"].ConnectionString;
            string pin = StaffPasscodeInputBox.Text;
            using (SqlConnection myConnection = new SqlConnection(dbConnectionString))
            using (SqlDataAdapter employeePin = new SqlDataAdapter($"SELECT * FROM Employees WHERE PIN = {pin}", myConnection))
            {
                DataTable userPin = new DataTable();
              
                myConnection.Open();
                employeePin.Fill(userPin);
                myConnection.Close();
                bool correct = false;
                for (int row = 0; row < userPin.Rows.Count; row++)
                {
                    if (!DBNull.Value.Equals(userPin.Rows[row]["PIN"]))
                    {
                        int dpin = (int)userPin.Rows[row]["PIN"];
                        if (pin == dpin.ToString())
                        {
                            var TableSelection = new TableSelection();
                            Hide();
                            TableSelection.Show();
                            correct = true;
                        }

                    }

                } 
                if (correct == false)
                {
                    DialogResult PasscodeError = MessageBox.Show("Please Enter Valid Passcode", "Passcode Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (PasscodeError == DialogResult.OK)
                    {
                        StaffPasscodeInputBox.Text = "";
                    }
                }

            }
        }

        private void PasscodeButtonClick(object sender, EventArgs e)
        {
            try
            {
                Button button = (Button)sender;

                StaffPasscodeInputBox.Text += button.Text;
            }

            catch { }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                StaffPasscodeInputBox.Text = StaffPasscodeInputBox.Text.Substring(0, StaffPasscodeInputBox.Text.Length - 1);
            }

            catch { }
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            getEmployeePinLogin();

            //if (StaffPasscodeInputBox.Text == "1234")
            //{
            //    var TableSelection = new TableSelection();
            //    Hide();
            //    TableSelection.Show();
            //}

            //else
            //{
            //    DialogResult PasscodeError = MessageBox.Show("Please Enter Valid Passcode", "Passcode Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    if (PasscodeError == DialogResult.OK)
            //    {
            //        StaffPasscodeInputBox.Text = "";
            //    }
            //}

        }

        private void NumPadKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad0 || e.KeyCode == Keys.D0)
            {
                StaffPasscodeInputBox.Text += Button0.Text;
            }

            else if (e.KeyCode == Keys.NumPad1 || e.KeyCode == Keys.D1)
            {
                StaffPasscodeInputBox.Text += Button1.Text;
            }

            else if (e.KeyCode == Keys.NumPad2 || e.KeyCode == Keys.D2)
            {
                StaffPasscodeInputBox.Text += Button2.Text;
            }

            else if (e.KeyCode == Keys.NumPad3 || e.KeyCode == Keys.D3)
            {
                StaffPasscodeInputBox.Text += Button3.Text;
            }

            else if (e.KeyCode == Keys.NumPad4 || e.KeyCode == Keys.D4)
            {
                StaffPasscodeInputBox.Text += Button4.Text;
            }

            else if (e.KeyCode == Keys.NumPad5 || e.KeyCode == Keys.D5)
            {
                StaffPasscodeInputBox.Text += Button5.Text;
            }

            else if (e.KeyCode == Keys.NumPad6 || e.KeyCode == Keys.D6)
            {
                StaffPasscodeInputBox.Text += Button6.Text;
            }

            else if (e.KeyCode == Keys.NumPad7 || e.KeyCode == Keys.D7)
            {
                StaffPasscodeInputBox.Text += Button7.Text;
            }

            else if (e.KeyCode == Keys.NumPad8 || e.KeyCode == Keys.D8)
            {
                StaffPasscodeInputBox.Text += Button8.Text;
            }

            else if (e.KeyCode == Keys.NumPad9 || e.KeyCode == Keys.D9)
            {
                StaffPasscodeInputBox.Text += Button9.Text;
            }

            else if (e.KeyCode == Keys.Subtract || e.KeyCode == Keys.OemMinus || e.KeyCode == Keys.Delete)
            {
                try
                {
                    StaffPasscodeInputBox.Text = StaffPasscodeInputBox.Text.Substring(0, StaffPasscodeInputBox.Text.Length - 1);
                }
                catch { }
            }

            else if (e.KeyCode == Keys.Enter)
            {
                if (StaffPasscodeInputBox.Text == "1234")
                {
                    var TableSelection = new TableSelection();
                    Hide();
                    TableSelection.Show();
                }

                else
                {
                    DialogResult PasscodeError = MessageBox.Show("Please Enter Valid Passcode", "Passcode Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (PasscodeError == DialogResult.OK)
                    {
                        StaffPasscodeInputBox.Text = "";
                    }
                }
            }
        }

        private void StaffSignClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
