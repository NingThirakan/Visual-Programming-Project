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
    public partial class LP : Form
    {
        public LP()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            if (username.Text == "" && password.Text == "")
            {
                MessageBox.Show("Invalid Username or Password");
                return;
            }
            else
            {
                string query = "SELECT * FROM member WHERE Username = @user AND Password = @pass";
                SQLiteConnection con = new SQLiteConnection("Data Source = E:/Visual Programming/Project/BlueShopWA/Userdb.db");
                con.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, con);
                cmd.Parameters.AddWithValue("@user", username.Text);
                cmd.Parameters.AddWithValue("@pass", password.Text);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);
                MP1 mp1 = new MP1();

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Login Successful");
                    mp1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password");
                }
            }

        }

        private void register_Click(object sender, EventArgs e)
        {
            this.Hide();
            RP rp = new RP();
            rp.Show();

        }
    }
}
