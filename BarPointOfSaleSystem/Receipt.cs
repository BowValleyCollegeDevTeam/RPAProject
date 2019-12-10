﻿using System;
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
    public partial class Receipt : Form
    {
        public Receipt()
        {
            InitializeComponent();
        }


        private void Billsplitways_ValueChanged(object sender, EventArgs e)
        {
            var splitways = Billsplitways.Value + 1;
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
        }

        private void Receipt_Load(object sender, EventArgs e)
        {
            GrabSelectedMenuItems();
            TotalPerBillNumberLBL.Text = TotalNumberLBL.Text;
            
            
        }

        private void GrabSelectedMenuItems()
        {
            // go into the database and grab the selected items for the certain table number
            var totalamount = 65.55 + 36.75;
            totalamount = Math.Round(totalamount, 2);

            TotalNumberLBL.Text = totalamount.ToString();
        }
    }
}
