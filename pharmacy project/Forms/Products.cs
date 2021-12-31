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
    public partial class Products : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VK95HQC\SQLEXPRESS;Initial Catalog=pharmacy_project;Integrated Security=True");
        int indexRow;
        int currentId;
        public Products()
        {
            InitializeComponent();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            get_data();
        }
        private void get_data()
        {
            string query = "SELECT ID, Code,Name,Quantity,Price,last_update FROM [dbo].[product] ";
            SqlCommand command = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewproducts.DataSource = table;
        }
        private void cleardata()
        {
            nameTxtbox.Text = "";
            codeTxtbox.Text = "";
            quantityNum.Value = 0;
            PriceNum.Value = 0;
            indexRow = 0;
            currentId = 0;
        }
        private void clearbtn_Click(object sender, EventArgs e)
        {

            cleardata();
        }
        private void dataGridViewproducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dataGridViewproducts.Rows[indexRow];
            codeTxtbox.Text = " " + row.Cells[1].Value.ToString();
            nameTxtbox.Text = " " + row.Cells[2].Value.ToString();
            quantityNum.Value =  decimal.Parse(row.Cells[3].Value.ToString());
            PriceNum.Value = decimal.Parse(row.Cells[4].Value.ToString());
            currentId = int.Parse(row.Cells[0].Value.ToString());

        }

        private void updatebtn_MouseClick(object sender, MouseEventArgs e)
        {
            DateTime now = new DateTime();

            string query = "UPDATE [dbo].[product] SET [code] = '" + codeTxtbox.Text.Trim() + "' ,[name] ='" + nameTxtbox.Text.Trim() + "' ,[quantity] = " + quantityNum.Value + ",[price]  = " + PriceNum.Value + ", [last_update] = " + now.ToString("yyyy-MM-dd") + " where id = " + currentId + "";
            SqlCommand command = new SqlCommand(query, con);
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            get_data();
            cleardata();
        }

        private void addbtnn_Click(object sender, EventArgs e) 
        {
            if(codeTxtbox.Text != " " & nameTxtbox.Text != " " & quantityNum.Value != 0 & PriceNum.Value != 0)
            {
                DateTime now = new DateTime();
                string query = "INSERT INTO [dbo].[product]([code],[name],[quantity],[price],[last_update]) VALUES ('" + codeTxtbox.Text.Trim() + "','" + nameTxtbox.Text.Trim() + "'," + quantityNum.Value + "," + PriceNum.Value + "," + now.ToString("yyyy-MM-dd") + ")";
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


        private void changeColors(Button btn)
        {
            btn.BackColor = ColorsTheme.primaryColor;
        }
        private void returnchangeColors(Button btn)
        {
            btn.BackColor = Color.White;
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

        
        private void clearbtn_MouseEnter(object sender, EventArgs e)
        {
            changeColors(clearbtn);

        }

        private void clearbtn_MouseLeave(object sender, EventArgs e)
        {
            returnchangeColors(clearbtn);

        }

        private void dataGridViewusers_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewproducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
