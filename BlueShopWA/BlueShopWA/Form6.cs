using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace BlueShopWA
{
    public partial class MP2 : Form
    {
        public MP2()
        {
            InitializeComponent();
        }

        private void exit2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void back6_Click(object sender, EventArgs e)
        {
            MP1 mp1 = new MP1();
            mp1.Show();
            this.Hide();
        }

        private void buy4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Error!!!");
        }

        private void buy5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for buying.");
        }

        private void buy6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for buying.");
        }
    }
}
