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
    public partial class InvoicesForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VK95HQC\SQLEXPRESS;Initial Catalog=pharmacy_project;Integrated Security=True");

        public InvoicesForm()
        {
            InitializeComponent();
        }
        
        private void InvoicesForm_Load(object sender, EventArgs e)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            FillCombo();
            changeColors();
        }
        private void changeColors()
        {
            comboBox1.ForeColor = ColorsTheme.primaryColor;
        }
        private void FillCombo()
        {
            string query = "SELECT total ,id FROM [dbo].[invoice] ";
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader reader;
            con.Open();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                int id = reader.GetInt32(1);
                int total = reader.GetInt32(1);
                comboBox1.Items.Add(id);
            }
            con.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "SELECT  i.id as invoice_id , i.total,i.created_at,  p.code, p.name, ip.quantity,i.user_id,u.first_name,u.last_name FROM [dbo].[invoice] as i join invoice_products as ip on i.id = ip.invoice_id join product as p on ip.product_id = p.id join users as u on i.user_id = u.id where i.id = " + comboBox1.SelectedItem+"";
            SqlCommand command = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            comboBox1.Text = " ";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
