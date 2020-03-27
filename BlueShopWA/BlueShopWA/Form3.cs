using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlueShopWA
{
    public partial class MP1 : Form
    {
        public MP1()
        {
            InitializeComponent();
        }

        private void exit1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void next3_Click(object sender, EventArgs e)
        {
            MP2 mp2 = new MP2();
            mp2.Show();
            this.Hide();
        }

        private void buy1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for buying.");
        }

        private void buy2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for buying.");
        }

        private void buy3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for buying.");
        }
    }
}
