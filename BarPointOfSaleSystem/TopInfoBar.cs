using System;
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
    public partial class TopInfoBar : UserControl
    {
        public TopInfoBar()
        {
            InitializeComponent();
            TimeTimerTicker.Start();
        }

        private void TimeTimerTicker_Tick_1(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.TimeLabel.Text = dateTime.ToString();
        }
    }
}
