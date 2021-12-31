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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();

        }
        private void Search_Load(object sender, EventArgs e)
        {
            changeColor();
        }
        private void changeColor()
        {
          

        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VK95HQC\SQLEXPRESS;Initial Catalog=pharmacy_project;Integrated Security=True");
       
        private void searchbox_KeyUp(object sender, KeyEventArgs e)
        {
            string query = "SELECT *FROM [pharmacy_project].[dbo].[product] where name LIKE '%" + searchboxinput.Text.Trim() + "%' or code LIKE '%" + searchboxinput.Text.Trim() + "%' ";
            SqlCommand command = new SqlCommand(query,con);
            
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewseaechdata.DataSource =table ;

        }

        private void dataGridViewseaechdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchboxinput_Click(object sender, EventArgs e)
        {
            searchboxinput.Text = " ";
        }

        private void dataGridViewseaechdata_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
