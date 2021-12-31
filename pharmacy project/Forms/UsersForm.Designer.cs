
namespace pharmacy_project.Forms
{
    partial class UsersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.addbtnn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.clearbtn = new System.Windows.Forms.Button();
            this.passwordTxtbox = new System.Windows.Forms.TextBox();
            this.phoneTxtbox = new System.Windows.Forms.TextBox();
            this.last_nameTxtbox = new System.Windows.Forms.TextBox();
            this.first_nameTxtbox = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.last_name = new System.Windows.Forms.Label();
            this.first_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewusers = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewusers)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.addbtnn);
            this.panel1.Controls.Add(this.deletebtn);
            this.panel1.Controls.Add(this.updatebtn);
            this.panel1.Controls.Add(this.clearbtn);
            this.panel1.Controls.Add(this.passwordTxtbox);
            this.panel1.Controls.Add(this.phoneTxtbox);
            this.panel1.Controls.Add(this.last_nameTxtbox);
            this.panel1.Controls.Add(this.first_nameTxtbox);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.phone);
            this.panel1.Controls.Add(this.last_name);
            this.panel1.Controls.Add(this.first_name);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 285);
            this.panel1.TabIndex = 1;
            // 
            // addbtnn
            // 
            this.addbtnn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addbtnn.Location = new System.Drawing.Point(0, 145);
            this.addbtnn.Name = "addbtnn";
            this.addbtnn.Size = new System.Drawing.Size(792, 35);
            this.addbtnn.TabIndex = 12;
            this.addbtnn.Text = "Add";
            this.addbtnn.UseVisualStyleBackColor = true;
            this.addbtnn.Click += new System.EventHandler(this.addbtnn_Click);
            this.addbtnn.MouseEnter += new System.EventHandler(this.addbtnn_MouseEnter);
            this.addbtnn.MouseLeave += new System.EventHandler(this.addbtnn_MouseLeave);
            // 
            // deletebtn
            // 
            this.deletebtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.deletebtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.deletebtn.Location = new System.Drawing.Point(0, 180);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(792, 35);
            this.deletebtn.TabIndex = 11;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            this.deletebtn.MouseEnter += new System.EventHandler(this.deletebtn_MouseEnter);
            this.deletebtn.MouseLeave += new System.EventHandler(this.deletebtn_MouseLeave);
            // 
            // updatebtn
            // 
            this.updatebtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.updatebtn.Location = new System.Drawing.Point(0, 215);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(792, 35);
            this.updatebtn.TabIndex = 10;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            this.updatebtn.MouseEnter += new System.EventHandler(this.updatebtn_MouseEnter);
            this.updatebtn.MouseLeave += new System.EventHandler(this.updatebtn_MouseLeave);
            // 
            // clearbtn
            // 
            this.clearbtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.clearbtn.Location = new System.Drawing.Point(0, 250);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(792, 35);
            this.clearbtn.TabIndex = 9;
            this.clearbtn.Text = "Clear";
            this.clearbtn.UseVisualStyleBackColor = true;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            this.clearbtn.MouseEnter += new System.EventHandler(this.clearbtn_MouseEnter);
            this.clearbtn.MouseLeave += new System.EventHandler(this.clearbtn_MouseLeave);
            // 
            // passwordTxtbox
            // 
            this.passwordTxtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTxtbox.Location = new System.Drawing.Point(455, 103);
            this.passwordTxtbox.Name = "passwordTxtbox";
            this.passwordTxtbox.Size = new System.Drawing.Size(197, 22);
            this.passwordTxtbox.TabIndex = 8;
            // 
            // phoneTxtbox
            // 
            this.phoneTxtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phoneTxtbox.Location = new System.Drawing.Point(455, 56);
            this.phoneTxtbox.Name = "phoneTxtbox";
            this.phoneTxtbox.Size = new System.Drawing.Size(197, 22);
            this.phoneTxtbox.TabIndex = 7;
            // 
            // last_nameTxtbox
            // 
            this.last_nameTxtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.last_nameTxtbox.Location = new System.Drawing.Point(142, 98);
            this.last_nameTxtbox.Name = "last_nameTxtbox";
            this.last_nameTxtbox.Size = new System.Drawing.Size(197, 22);
            this.last_nameTxtbox.TabIndex = 6;
            // 
            // first_nameTxtbox
            // 
            this.first_nameTxtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.first_nameTxtbox.Location = new System.Drawing.Point(142, 54);
            this.first_nameTxtbox.Name = "first_nameTxtbox";
            this.first_nameTxtbox.Size = new System.Drawing.Size(197, 22);
            this.first_nameTxtbox.TabIndex = 5;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(368, 105);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(81, 17);
            this.password.TabIndex = 4;
            this.password.Text = "Password : ";
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Location = new System.Drawing.Point(388, 56);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(61, 17);
            this.phone.TabIndex = 3;
            this.phone.Text = "Phone : ";
            // 
            // last_name
            // 
            this.last_name.AutoSize = true;
            this.last_name.Location = new System.Drawing.Point(46, 100);
            this.last_name.Name = "last_name";
            this.last_name.Size = new System.Drawing.Size(90, 17);
            this.last_name.TabIndex = 2;
            this.last_name.Text = "Last_name : ";
            // 
            // first_name
            // 
            this.first_name.AutoSize = true;
            this.first_name.Location = new System.Drawing.Point(46, 56);
            this.first_name.Name = "first_name";
            this.first_name.Size = new System.Drawing.Size(90, 17);
            this.first_name.TabIndex = 1;
            this.first_name.Text = "First_name : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Users Entry Data";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewusers);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 285);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(792, 212);
            this.panel2.TabIndex = 2;
            // 
            // dataGridViewusers
            // 
            this.dataGridViewusers.AllowUserToAddRows = false;
            this.dataGridViewusers.AllowUserToDeleteRows = false;
            this.dataGridViewusers.AllowUserToResizeColumns = false;
            this.dataGridViewusers.AllowUserToResizeRows = false;
            this.dataGridViewusers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewusers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridViewusers.BackgroundColor = System.Drawing.Color.Snow;
            this.dataGridViewusers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewusers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewusers.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridViewusers.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dataGridViewusers.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewusers.MultiSelect = false;
            this.dataGridViewusers.Name = "dataGridViewusers";
            this.dataGridViewusers.RowHeadersWidth = 51;
            this.dataGridViewusers.RowTemplate.Height = 24;
            this.dataGridViewusers.Size = new System.Drawing.Size(792, 212);
            this.dataGridViewusers.TabIndex = 1;
            this.dataGridViewusers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewusers_CellClick);
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 497);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UsersForm";
            this.Text = "Users";
            this.Load += new System.EventHandler(this.UsersForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewusers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addbtnn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.TextBox last_nameTxtbox;
        private System.Windows.Forms.TextBox first_nameTxtbox;
        private System.Windows.Forms.Label last_name;
        private System.Windows.Forms.Label first_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewusers;
        private System.Windows.Forms.TextBox passwordTxtbox;
        private System.Windows.Forms.TextBox phoneTxtbox;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label phone;
    }
}