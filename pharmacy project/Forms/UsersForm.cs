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
    public partial class UsersForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VK95HQC\SQLEXPRESS;Initial Catalog=pharmacy_project;Integrated Security=True");
        private int indexRow;
        private int currentId;
        public UsersForm()
        {
            InitializeComponent();
        }
        private void UsersForm_Load(object sender, EventArgs e)
        {
            get_data();
        }
        private void changeColors(Button btn)
        {
            btn.BackColor = ColorsTheme.primaryColor;
        }
        private void returnchangeColors(Button btn)
        {
            btn.BackColor = Color.White;
        }
        private void get_data()
        {
            string query = "SELECT ID, First_name,Last_name,Phone,Password,Last_login FROM [pharmacy_project].[dbo].[users] ";
            SqlCommand command = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewusers.DataSource = table;

        }
        private void cleardata()
        {
            last_nameTxtbox.Text = "";
            first_nameTxtbox.Text = "";
            passwordTxtbox.Text = "";
            phoneTxtbox.Text = "";
            indexRow = 0;
            currentId = 0;
        }
        private void clearbtn_Click(object sender, EventArgs e)
        {

            cleardata();
        }
        private void dataGridViewusers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dataGridViewusers.Rows[indexRow];
            first_nameTxtbox.Text = " " + row.Cells[1].Value.ToString();
            last_nameTxtbox.Text = " " + row.Cells[2].Value.ToString();
            phoneTxtbox.Text = " " + row.Cells[3].Value.ToString();
            passwordTxtbox.Text = " " + row.Cells[4].Value.ToString();
            currentId = int.Parse(row.Cells[0].Value.ToString());

        }

        private void addbtnn_Click(object sender, EventArgs e)
        {
            if(first_nameTxtbox.Text != "" & last_nameTxtbox.Text != "" & passwordTxtbox.Text != "" & phoneTxtbox.Text != "" )
            { 
            string query = "INSERT INTO [dbo].[users]([first_name],[last_name],[password],[phone],[last_login]) VALUES ('"+first_nameTxtbox.Text.Trim()+ "','" + last_nameTxtbox.Text.Trim() + "','" + passwordTxtbox.Text.Trim() + "','" + phoneTxtbox.Text.Trim() + "',0000-00-00)";
            SqlCommand command = new SqlCommand(query, con);
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            get_data();
            cleardata();
             }
            else
            {
                MessageBox.Show("there is a field  is required",
                                    "Can't Add!!",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this user ??",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Warning);
            if ( confirmResult == DialogResult.Yes)
            {
                string query = "DELETE FROM [dbo].[users] where id = "+currentId+"";
                SqlCommand command = new SqlCommand(query, con);
                con.Open();
                command.ExecuteNonQuery();
                con.Close();
                get_data();
            }
            cleardata();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            string query = "UPDATE [dbo].[users] Set [first_name] = '" + first_nameTxtbox.Text.Trim() + "' ,[last_name] ='" + last_nameTxtbox.Text.Trim() + "' ,[password] = '" + passwordTxtbox.Text.Trim() + "',[phone]  = '" + phoneTxtbox.Text.Trim() + "' where id = "+currentId+"" ;
            SqlCommand command = new SqlCommand(query, con);
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            get_data();
            cleardata();
        }

        private void updatebtn_MouseLeave(object sender, EventArgs e)
        {
            returnchangeColors(updatebtn);
        }

        private void updatebtn_MouseEnter(object sender, EventArgs e)
        {
            changeColors(updatebtn);

        }

        private void addbtnn_MouseLeave(object sender, EventArgs e)
        {
            returnchangeColors(addbtnn);

        }

        private void addbtnn_MouseEnter(object sender, EventArgs e)
        {
            changeColors(addbtnn);

        }

        private void deletebtn_MouseEnter(object sender, EventArgs e)
        {
            changeColors(deletebtn);

        }

        private void deletebtn_MouseLeave(object sender, EventArgs e)
        {
            returnchangeColors(deletebtn);

        }

        private void clearbtn_MouseEnter(object sender, EventArgs e)
        {
            changeColors(clearbtn);

        }

        private void clearbtn_MouseLeave(object sender, EventArgs e)
        {
            returnchangeColors(clearbtn);

        }
    }
}
