﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarPointOfSaleSystem
{
    public partial class FoodBtns : UserControl
    {
        public FoodBtns()
        {
            InitializeComponent();
        }

        private void AddOn_Click(object sender, EventArgs e)
        {
            MenuAddOn MAdd = new MenuAddOn();
            MAdd.Show();
        }
    }
}
