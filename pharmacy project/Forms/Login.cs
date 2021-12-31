using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace pharmacy_project.Forms
{
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VK95HQC\SQLEXPRESS;Initial Catalog=pharmacy_project;Integrated Security=True");

        public Login()
        {
            InitializeComponent();
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {

            if (password.Text == "" || id.Text == "")
            {
                MessageBox.Show("ID and Password Fields are required",
                    "validation error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }
            else
            {
                
                string query = "SELECT id,first_name FROM[dbo].[users]where id = '" + id.Text + "' and password = '" + password.Text.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable tb = new DataTable();
                sda.Fill(tb);
                if (tb.Rows.Count == 1)
                {
                    foreach (DataRow row in tb.Rows)
                    {
                        LoginInfo.UserID = int.Parse(row["id"].ToString());
                        LoginInfo.first_name  = row["first_name"].ToString();
                        
                    }
                    Form1 obj = new Form1();
                    this.Hide();
                    obj.Show();

                }
                else
                {
                    MessageBox.Show("data you enter isn't correct check your username and password","Data Error",
                        MessageBoxButtons.OK,MessageBoxIcon.Hand);
                }

            }

        }
        public static class LoginInfo
        {
            public static int UserID;
            public static string first_name;

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
