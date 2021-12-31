
namespace pharmacy_project.Forms
{
    partial class Search
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
            this.searchboxinput = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewseaechdata = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewseaechdata)).BeginInit();
            this.SuspendLayout();
            // 
            // searchboxinput
            // 
            this.searchboxinput.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchboxinput.Location = new System.Drawing.Point(0, 0);
            this.searchboxinput.Name = "searchboxinput";
            this.searchboxinput.Size = new System.Drawing.Size(734, 22);
            this.searchboxinput.TabIndex = 4;
            this.searchboxinput.Text = "Enter Name or Code";
            this.searchboxinput.Click += new System.EventHandler(this.searchboxinput_Click);
            this.searchboxinput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchbox_KeyUp);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewseaechdata);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 484);
            this.panel1.TabIndex = 5;
            // 
            // dataGridViewseaechdata
            // 
            this.dataGridViewseaechdata.AllowUserToAddRows = false;
            this.dataGridViewseaechdata.AllowUserToDeleteRows = false;
            this.dataGridViewseaechdata.AllowUserToResizeColumns = false;
            this.dataGridViewseaechdata.AllowUserToResizeRows = false;
            this.dataGridViewseaechdata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewseaechdata.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridViewseaechdata.BackgroundColor = System.Drawing.Color.Snow;
            this.dataGridViewseaechdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewseaechdata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewseaechdata.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewseaechdata.Name = "dataGridViewseaechdata";
            this.dataGridViewseaechdata.RowHeadersWidth = 51;
            this.dataGridViewseaechdata.RowTemplate.Height = 24;
            this.dataGridViewseaechdata.Size = new System.Drawing.Size(734, 484);
            this.dataGridViewseaechdata.TabIndex = 4;
            this.dataGridViewseaechdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewseaechdata_CellContentClick_1);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 506);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.searchboxinput);
            this.Name = "Search";
            this.Text = "Search";
            this.TransparencyKey = System.Drawing.Color.DimGray;
            this.Load += new System.EventHandler(this.Search_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewseaechdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox searchboxinput;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewseaechdata;
    }
}