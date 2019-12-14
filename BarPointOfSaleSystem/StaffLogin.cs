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
        // so the variable doesn't change over time
        public static int dpin;

        public StaffLogin()
        {
            InitializeComponent();
        }
        // makes the static variable accessable from every form
        public string pin
        {
            get { return dpin.ToString(); }
        }


        //Takes the PIN codes from the employees table And validates
        //Whether the pin code is entered correctly
        public void getEmployeePinLogin()
        {
            // to catch the bug if someone doesn't enter any number into the login field and just selects enter
            try
            {
                
                string pin = StaffPasscodeInputBox.Text;
                // uses the local connection string to grab data
                string str = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\heart\repos\RPAProject\BarPointOfSaleSystem\BarPOSSystemData.mdf;Integrated Security=True";
                using (SqlConnection myConnection = new SqlConnection(str))
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
                            dpin = (int)userPin.Rows[row]["PIN"];
                            if (pin == dpin.ToString())
                            {
                                var TableSelection = new TableSelection();
                                Hide();
                                TableSelection.Show();
                                correct = true;
                            }

                        }

                    }
                    //If the pin is incorrect it sends out this message
                    if (correct == false)
                    {
                        DialogResult PasscodeError = MessageBox.Show("Please Enter Valid Passcode", "Passcode Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        // if the previous if statement is correct it changes the input box to blank
                        if (PasscodeError == DialogResult.OK)
                        {
                            StaffPasscodeInputBox.Text = "";
                        }
                    }

                }
            }
            // once it catches this bug/error it displays this message
            catch
            {
                DialogResult PasscodeError = MessageBox.Show("Please Enter Valid Passcode", "Passcode Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ever time you enter number or click a button it adds it to the input box
        private void PasscodeButtonClick(object sender, EventArgs e)
        {
            try
            {
                Button button = (Button)sender;

                StaffPasscodeInputBox.Text += button.Text;
            }

            catch { }
        }
        // once you hit the delete button it removes a number from the string
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



        }


        //Creates references to the Number pads so that user is able to use it.
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
            // validates that you can use the delete key on your keyboard to delete a number
            else if (e.KeyCode == Keys.Subtract || e.KeyCode == Keys.OemMinus || e.KeyCode == Keys.Delete)
            {
                try
                {
                    StaffPasscodeInputBox.Text = StaffPasscodeInputBox.Text.Substring(0, StaffPasscodeInputBox.Text.Length - 1);
                }
                catch { }
            }
            
        }
        // once the user clicks the x the application exits
        private void StaffSignClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void StaffLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
