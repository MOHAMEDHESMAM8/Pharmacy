using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pharmacy_project
{
    public partial class Form1 : Form
    {
        private Button currentButton;
        private Form activeform;

        public Form1()
        {
            InitializeComponent();
        }
        private void Openform(Form form ,object btnsender)
        {
            pictureBox1.Visible = false;
            if(activeform != null)
            {
                activeform.Close();
            }
            ActivateButton(btnsender);
            activeform = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(form);
            this.panelDesktop.Tag = form;
            form.Show();
            headerTitel.Text = form.Text;


        }
        private void ActivateButton(object btnSender)
        {
            if(btnSender !=null)
            {
                if(currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = ColorsTheme.SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new Font("Microsoft Sans Serif", 10F,FontStyle.Regular,GraphicsUnit.Point);
                    panelLogo.BackColor = ColorsTheme.ColorLogoDark(color);
                    panelheader.BackColor = color;
                    ColorsTheme.primaryColor = color;
                    ColorsTheme.SecondryColor =  ColorsTheme.ColorLogoDark(color);
                   
                }
            }
        }
        private void DisableButton()
        {
            foreach(Control perviousBtn in panelNavBar.Controls)
            {
                if(perviousBtn.GetType()== typeof(Button))
                {
                    perviousBtn.BackColor = Color.FromArgb(51, 51, 75);
                    perviousBtn.ForeColor = Color.Gainsboro;
                    perviousBtn.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);

                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Openform(new Forms.Search(), sender);
        }

        private void btnsales_Click(object sender, EventArgs e)
        {
            Openform(new Forms.SalesForm(), sender);
        }
         
        private void btnSalesHistory_Click(object sender, EventArgs e)
        {
            Openform(new Forms.InvoicesForm(), sender);
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            Openform(new Forms.UsersForm(), sender);
        }

        

        private void products_Click(object sender, EventArgs e)
        {
            Openform(new Forms.Products(), sender);
        }

        

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          LoginInfoLabel.Text = "Welcome, " + Forms.Login.LoginInfo.first_name + "";
        }

        private void panelLogo_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;

        }

        private void SignOut_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to leave ??",
                                     "Confirm Sign Out!!",
                                     MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes)
            {
                this.Hide();
                Form obj = new Forms.Login();
                Forms.Login.LoginInfo.UserID = 0;
                Forms.Login.LoginInfo.first_name = null;
                obj.Show();
            }
            
        }
    }
}
