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
    public partial class SalesForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VK95HQC\SQLEXPRESS;Initial Catalog=pharmacy_project;Integrated Security=True");
        private float price1;
        private float price2;
        private float price3;
        private float quantity1;
        private float quantity2;
        private float quantity3;
        private float invoicetotal;
        private int product_id1 =0;
        private int product_id2 = 0;
        private int product_id3 = 0;
        public SalesForm()
        {
            InitializeComponent();
        }
        private void SalesForm_Load(object sender, EventArgs e)
        {
            changeColors();
            FillCombo();
        }
        private void FillCombo()
        {
            string query = "SELECT code ,name,quantity FROM [pharmacy_project].[dbo].[product] ";
            SqlCommand command = new SqlCommand(query, con);

            SqlDataReader reader;
            con.Open();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
              
                string name = reader.GetString(1);
                comboBox1.Items.Add(name);
            }
            con.Close();
        }
        private void changeColors()
        {
            saveInvoice.BackColor = ColorsTheme.primaryColor;
        }
        private void addItem_Click(object sender, EventArgs e)
        {
            Panel panel2 = new Panel();
            panel2.Dock = DockStyle.Top;
            TextBox price2 =new TextBox();
            price2.Anchor = AnchorStyles.Left;
            panel2.Controls.Add(price2);
            Controls.Add(panel2);

        }
        private void get_data()
        {
            string query = "SELECT code ,name ,price ,quantity,id FROM [pharmacy_project].[dbo].[product] where name = '"+comboBox1.SelectedItem +"'";
            SqlCommand command = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
        private Boolean Checkexist(string code )
        {
            if(id.Text == code || panel2id.Text  == code || panel3id.Text == code)
            {
                MessageBox.Show("the product already exist"," Notice",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return true;
            }
            return false;

        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            get_data();
            DataGridViewRow row = dataGridView1.Rows[0];
            if (id.Text == "")
            {

                string code  = row.Cells[0].Value.ToString();
                if (!Checkexist(code))
                {
                    quantity.ReadOnly = false;
                    id.Text = code;
                    name.Text = row.Cells[1].Value.ToString();
                    price1 = float.Parse(row.Cells[2].Value.ToString());
                    quantity1 = float.Parse(row.Cells[3].Value.ToString());
                    product_id1 = int.Parse(row.Cells[4].Value.ToString());
                    quantity.Maximum = decimal.Parse(quantity1.ToString());
                }
            }
            else if (panel2id.Text == "")
            {
                string code = row.Cells[0].Value.ToString();
                if (!Checkexist(code))
                {
                    panel2quantity.ReadOnly = false;
                    panel2id.Text = code;
                    panel2name.Text = row.Cells[1].Value.ToString();
                    price2 = float.Parse(row.Cells[2].Value.ToString());
                    quantity2 = float.Parse(row.Cells[3].Value.ToString());
                    product_id2 = int.Parse(row.Cells[4].Value.ToString());
                    panel2quantity.ReadOnly = false;
                    panel2quantity.Maximum = decimal.Parse(quantity2.ToString());

                }


            }
            else if (panel3id.Text == "")
            {
                string code = row.Cells[0].Value.ToString();
                if (!Checkexist(code))
                {
                    panel3id.Text = code;
                    panel3name.Text = row.Cells[1].Value.ToString();
                    price3 = float.Parse(row.Cells[2].Value.ToString());
                    quantity3 = float.Parse(row.Cells[3].Value.ToString());
                    product_id3 = int.Parse(row.Cells[4].Value.ToString());
                    panel3quantity.ReadOnly = false;
                    panel3quantity.Maximum = decimal.Parse(quantity3.ToString());

                }
            }
            else
            {
                MessageBox.Show("You Can Only add 3 products at time", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }
       


        private void quantitynum_ValueChanged(object sender, EventArgs e)
        {
            float q = float.Parse(quantity.Value.ToString());
            float finalprice = price1 * q;
            price.Text = finalprice.ToString();
            calcTotal();
        }

        private void panel2quantity_ValueChanged(object sender, EventArgs e)
        {
            
            float q = float.Parse(panel2quantity.Value.ToString());
            float finalprice = price2 * q;
            panel2price.Text = finalprice.ToString();
            calcTotal();
        }

        private void panel3quantity_ValueChanged(object sender, EventArgs e)
        {
            float q = float.Parse(panel3quantity.Value.ToString());
            float finalprice = price3 * q;
            panel3price.Text = finalprice.ToString();
            calcTotal();
        }
        private void calcTotal()
        {
            float first = float.Parse(panel3price.Text);
            float second = float.Parse(panel2price.Text);
            float third = float.Parse(price.Text);
            invoicetotal = first + second +third;
            invoicetotalbox.Text = invoicetotal.ToString();
        }

        private void saveInvoice_Click(object sender, EventArgs e)
        {

            if(product_id1 != 0 || product_id2 != 0 || product_id3 != 0)
            {
                  if (invoicetotal != 0)
                  {
                        DateTime now = DateTime.Now;
                        
                        string query = "INSERT INTO [pharmacy_project].[dbo].[invoice] (user_id,total,created_at) VALUES(" + Login.LoginInfo.UserID + "," + invoicetotal + ", '" + now.ToString("yyyy-MM-dd HH:mm:ss") + "'); select MAX(id) from [pharmacy_project].[dbo].[invoice]";
                        con.Open();
                        SqlCommand com = new SqlCommand(query, con);
                        int  idinvoice = Convert.ToInt32(com.ExecuteScalar());
                        if (product_id1 != 0)
                        {
                        float newquantity1 = quantity1 - float.Parse(quantity.Text);
                        string query1 = "INSERT INTO [dbo].[invoice_products]([product_id],[quantity],[invoice_id]) VALUES("+ product_id1 + ","+ quantity.Text + ","+ idinvoice + "); UPDATE [dbo].[product] set quantity = "+ newquantity1 + " where id="+ product_id1 + " ";
                        SqlCommand command1 = new SqlCommand(query1, con);
                        command1.ExecuteNonQuery();
                        }
                        if (product_id2 != 0)
                        {
                            float newquantity2 = quantity2 - float.Parse(panel2quantity.Text);
                            string query2 = "INSERT INTO [dbo].[invoice_products]([product_id],[quantity],[invoice_id]) VALUES(" + product_id2 + "," + panel2quantity.Text + "," + idinvoice + "); UPDATE [dbo].[product] set quantity = " + newquantity2 + " where id=" + product_id2 + " ";
                            SqlCommand command2 = new SqlCommand(query2, con);
                            command2.ExecuteNonQuery();
                        }
                        if (product_id3 != 0)
                        {
                            float newquantity3 = quantity3 - float.Parse(panel3quantity.Text);
                            string query3 = "INSERT INTO [dbo].[invoice_products]([product_id],[quantity],[invoice_id]) VALUES(" + product_id3 + "," + panel3quantity.Text + "," + idinvoice + "); UPDATE [dbo].[product] set quantity = " + newquantity3 + " where id=" + product_id3 + " ";
                            SqlCommand command3 = new SqlCommand(query3, con);
                            command3.ExecuteNonQuery();
                        }
                        con.Close();
                        MessageBox.Show("Saved Successfully, You  invoice id ="+ idinvoice + " ","Successfully",MessageBoxButtons.OK);
                  }
            }
            else
            {
                MessageBox.Show("You must add product to save the Invoice First","Validation Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
        }

        private void quantity_Click(object sender, EventArgs e)
        {
            if(quantity1 == 0)
            {
                MessageBox.Show("Product  Quantity is 0 ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void panel2quantity_Click(object sender, EventArgs e)
        {
            if (quantity2 == 0)
            {
                MessageBox.Show("Product  Quantity is 0 ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void panel3quantity_Click(object sender, EventArgs e)
        {
            if (quantity3 == 0)
            {
                MessageBox.Show("Product  Quantity is 0 ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void delete2_Click(object sender, EventArgs e)
        {
            panel2id.Text = "";
            panel2name.Text = "";
            panel2price.Text = "0";
            panel2quantity.Value = 0;
            panel2quantity.ReadOnly = true;

        }

        private void delete3_Click(object sender, EventArgs e)
        {
            panel3id.Text = "";
            panel3name.Text = "";
            panel3price.Text = "0";
            panel3quantity.Value = 0;
            panel3quantity.ReadOnly = true;

        }

        private void delete1_Click(object sender, EventArgs e)
        {
            id.Text = "";
            name.Text = "";
            price.Text = "0";
            quantity.Value = 0;
            quantity.ReadOnly = false;

        }
    }
}
