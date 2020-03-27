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
    public partial class RP : Form
    {
        public RP()
        {
            InitializeComponent();
        }

        private void rb_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(userregist.Text)) || (string.IsNullOrWhiteSpace(name.Text))
                || (string.IsNullOrWhiteSpace(pass.Text)))
            {
                MessageBox.Show("Please Enter Data");
            }
            else
            {
                SQLiteConnection con = new SQLiteConnection("Data Source = E:/Visual Programming/Project/BlueShopWA/Userdb.db");
                string query = "INSERT INTO member(Username, Name, Password) VALUES('" + userregist.Text + "', '" + name.Text + "', '" + pass.Text + "')";
                SQLiteCommand cmd = new SQLiteCommand(query, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Registeration Successful");
                LP fp = new LP();
                fp.Show();
                this.Hide();
            }
            
        }

        private void back2_Click(object sender, EventArgs e)
        {
            LP fp = new LP();
            fp.Show();
            this.Hide();
        }
    }
}
