using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarPointOfSaleSystem
{
    public partial class StaffLogin : Form
    {
        public StaffLogin()
        {
            InitializeComponent();
        }

        private void PasscodeButtonClick(object sender, EventArgs e)
        {
            try { 
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

        private void StaffSignClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
