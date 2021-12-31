
namespace pharmacy_project
{
    partial class Form1
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
            System.Windows.Forms.Button products;
            System.Windows.Forms.Button btnUsers;
            System.Windows.Forms.Button btnSalesHistory;
            System.Windows.Forms.Button btnsales;
            System.Windows.Forms.Button btnSearch;
            System.Windows.Forms.Button SignOut;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelNavBar = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.LoginInfoLabel = new System.Windows.Forms.Label();
            this.panelheader = new System.Windows.Forms.Panel();
            this.headerTitel = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            products = new System.Windows.Forms.Button();
            btnUsers = new System.Windows.Forms.Button();
            btnSalesHistory = new System.Windows.Forms.Button();
            btnsales = new System.Windows.Forms.Button();
            btnSearch = new System.Windows.Forms.Button();
            SignOut = new System.Windows.Forms.Button();
            this.panelNavBar.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelheader.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelNavBar
            // 
            this.panelNavBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(75)))));
            this.panelNavBar.Controls.Add(SignOut);
            this.panelNavBar.Controls.Add(products);
            this.panelNavBar.Controls.Add(btnUsers);
            this.panelNavBar.Controls.Add(btnSalesHistory);
            this.panelNavBar.Controls.Add(btnsales);
            this.panelNavBar.Controls.Add(btnSearch);
            this.panelNavBar.Controls.Add(this.panelLogo);
            this.panelNavBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNavBar.Location = new System.Drawing.Point(0, 0);
            this.panelNavBar.Name = "panelNavBar";
            this.panelNavBar.Size = new System.Drawing.Size(220, 581);
            this.panelNavBar.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.LoginInfoLabel);
            this.panelLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 78);
            this.panelLogo.TabIndex = 1;
            this.panelLogo.Click += new System.EventHandler(this.panelLogo_Click);
            this.panelLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogo_Paint);
            // 
            // LoginInfoLabel
            // 
            this.LoginInfoLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LoginInfoLabel.AutoSize = true;
            this.LoginInfoLabel.Font = new System.Drawing.Font("MS Outlook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginInfoLabel.ForeColor = System.Drawing.Color.Snow;
            this.LoginInfoLabel.Location = new System.Drawing.Point(12, 24);
            this.LoginInfoLabel.Name = "LoginInfoLabel";
            this.LoginInfoLabel.Size = new System.Drawing.Size(193, 23);
            this.LoginInfoLabel.TabIndex = 0;
            this.LoginInfoLabel.Text = "welcome, Mohamed ";
            // 
            // panelheader
            // 
            this.panelheader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelheader.Controls.Add(this.headerTitel);
            this.panelheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelheader.Location = new System.Drawing.Point(220, 0);
            this.panelheader.Name = "panelheader";
            this.panelheader.Size = new System.Drawing.Size(962, 78);
            this.panelheader.TabIndex = 1;
            // 
            // headerTitel
            // 
            this.headerTitel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.headerTitel.AutoSize = true;
            this.headerTitel.Font = new System.Drawing.Font("MS Outlook", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerTitel.ForeColor = System.Drawing.Color.Snow;
            this.headerTitel.Location = new System.Drawing.Point(437, 24);
            this.headerTitel.Name = "headerTitel";
            this.headerTitel.Size = new System.Drawing.Size(87, 28);
            this.headerTitel.TabIndex = 0;
            this.headerTitel.Text = "HOME";
            // 
            // panelDesktop
            // 
            this.panelDesktop.Controls.Add(this.pictureBox1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 78);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(962, 503);
            this.panelDesktop.TabIndex = 2;
            this.panelDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktop_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::pharmacy_project.Properties.Resources.pharmacy__2_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(962, 503);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // products
            // 
            products.AutoSize = true;
            products.Dock = System.Windows.Forms.DockStyle.Top;
            products.FlatAppearance.BorderSize = 0;
            products.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            products.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            products.ForeColor = System.Drawing.Color.Snow;
            products.Image = global::pharmacy_project.Properties.Resources.cubes;
            products.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            products.Location = new System.Drawing.Point(0, 354);
            products.Margin = new System.Windows.Forms.Padding(0);
            products.Name = "products";
            products.Size = new System.Drawing.Size(220, 69);
            products.TabIndex = 6;
            products.Text = "Products";
            products.UseVisualStyleBackColor = true;
            products.Click += new System.EventHandler(this.products_Click);
            // 
            // btnUsers
            // 
            btnUsers.AutoSize = true;
            btnUsers.Dock = System.Windows.Forms.DockStyle.Top;
            btnUsers.FlatAppearance.BorderSize = 0;
            btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnUsers.ForeColor = System.Drawing.Color.Snow;
            btnUsers.Image = global::pharmacy_project.Properties.Resources.user__1_;
            btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnUsers.Location = new System.Drawing.Point(0, 285);
            btnUsers.Margin = new System.Windows.Forms.Padding(0);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new System.Drawing.Size(220, 69);
            btnUsers.TabIndex = 5;
            btnUsers.Text = "Users";
            btnUsers.UseVisualStyleBackColor = true;
            btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnSalesHistory
            // 
            btnSalesHistory.AutoSize = true;
            btnSalesHistory.Dock = System.Windows.Forms.DockStyle.Top;
            btnSalesHistory.FlatAppearance.BorderSize = 0;
            btnSalesHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSalesHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnSalesHistory.ForeColor = System.Drawing.Color.Snow;
            btnSalesHistory.Image = global::pharmacy_project.Properties.Resources.invoice;
            btnSalesHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnSalesHistory.Location = new System.Drawing.Point(0, 216);
            btnSalesHistory.Margin = new System.Windows.Forms.Padding(0);
            btnSalesHistory.Name = "btnSalesHistory";
            btnSalesHistory.Size = new System.Drawing.Size(220, 69);
            btnSalesHistory.TabIndex = 4;
            btnSalesHistory.Text = "SalesHistory";
            btnSalesHistory.UseVisualStyleBackColor = true;
            btnSalesHistory.Click += new System.EventHandler(this.btnSalesHistory_Click);
            // 
            // btnsales
            // 
            btnsales.AutoSize = true;
            btnsales.Dock = System.Windows.Forms.DockStyle.Top;
            btnsales.FlatAppearance.BorderSize = 0;
            btnsales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnsales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnsales.ForeColor = System.Drawing.Color.Snow;
            btnsales.Image = global::pharmacy_project.Properties.Resources.acquisition;
            btnsales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnsales.Location = new System.Drawing.Point(0, 147);
            btnsales.Margin = new System.Windows.Forms.Padding(0);
            btnsales.Name = "btnsales";
            btnsales.Size = new System.Drawing.Size(220, 69);
            btnsales.TabIndex = 3;
            btnsales.Text = "Sales";
            btnsales.UseVisualStyleBackColor = true;
            btnsales.Click += new System.EventHandler(this.btnsales_Click);
            // 
            // btnSearch
            // 
            btnSearch.AutoSize = true;
            btnSearch.Dock = System.Windows.Forms.DockStyle.Top;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnSearch.ForeColor = System.Drawing.Color.Snow;
            btnSearch.Image = global::pharmacy_project.Properties.Resources.shopping_cart__1_;
            btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnSearch.Location = new System.Drawing.Point(0, 78);
            btnSearch.Margin = new System.Windows.Forms.Padding(0);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(220, 69);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // SignOut
            // 
            SignOut.AutoSize = true;
            SignOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            SignOut.FlatAppearance.BorderSize = 0;
            SignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            SignOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            SignOut.ForeColor = System.Drawing.Color.Snow;
            SignOut.Image = global::pharmacy_project.Properties.Resources.logout;
            SignOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            SignOut.Location = new System.Drawing.Point(0, 512);
            SignOut.Margin = new System.Windows.Forms.Padding(0);
            SignOut.Name = "SignOut";
            SignOut.Size = new System.Drawing.Size(220, 69);
            SignOut.TabIndex = 7;
            SignOut.Text = "Sign Out";
            SignOut.UseVisualStyleBackColor = true;
            SignOut.Click += new System.EventHandler(this.SignOut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 581);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelheader);
            this.Controls.Add(this.panelNavBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelNavBar.ResumeLayout(false);
            this.panelNavBar.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelheader.ResumeLayout(false);
            this.panelheader.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNavBar;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelheader;
        private System.Windows.Forms.Label headerTitel;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Label LoginInfoLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

