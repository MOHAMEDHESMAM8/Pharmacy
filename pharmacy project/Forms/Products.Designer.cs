
namespace pharmacy_project.Forms
{
    partial class Products
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
            System.Windows.Forms.Label code;
            this.panel1 = new System.Windows.Forms.Panel();
            this.PriceNum = new System.Windows.Forms.NumericUpDown();
            this.quantityNum = new System.Windows.Forms.NumericUpDown();
            this.addbtnn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.clearbtn = new System.Windows.Forms.Button();
            this.codeTxtbox = new System.Windows.Forms.TextBox();
            this.nameTxtbox = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewproducts = new System.Windows.Forms.DataGridView();
            code = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PriceNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNum)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewproducts)).BeginInit();
            this.SuspendLayout();
            // 
            // code
            // 
            code.AutoSize = true;
            code.Location = new System.Drawing.Point(46, 100);
            code.Name = "code";
            code.Size = new System.Drawing.Size(53, 17);
            code.TabIndex = 2;
            code.Text = "Code : ";
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.PriceNum);
            this.panel1.Controls.Add(this.quantityNum);
            this.panel1.Controls.Add(this.addbtnn);
            this.panel1.Controls.Add(this.updatebtn);
            this.panel1.Controls.Add(this.clearbtn);
            this.panel1.Controls.Add(this.codeTxtbox);
            this.panel1.Controls.Add(this.nameTxtbox);
            this.panel1.Controls.Add(this.price);
            this.panel1.Controls.Add(this.quantity);
            this.panel1.Controls.Add(code);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 285);
            this.panel1.TabIndex = 2;
            // 
            // PriceNum
            // 
            this.PriceNum.DecimalPlaces = 1;
            this.PriceNum.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.PriceNum.Location = new System.Drawing.Point(455, 105);
            this.PriceNum.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.PriceNum.Name = "PriceNum";
            this.PriceNum.Size = new System.Drawing.Size(197, 22);
            this.PriceNum.TabIndex = 14;
            // 
            // quantityNum
            // 
            this.quantityNum.DecimalPlaces = 1;
            this.quantityNum.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.quantityNum.Location = new System.Drawing.Point(455, 56);
            this.quantityNum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.quantityNum.Name = "quantityNum";
            this.quantityNum.Size = new System.Drawing.Size(197, 22);
            this.quantityNum.TabIndex = 13;
            // 
            // addbtnn
            // 
            this.addbtnn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addbtnn.Location = new System.Drawing.Point(0, 180);
            this.addbtnn.Name = "addbtnn";
            this.addbtnn.Size = new System.Drawing.Size(800, 35);
            this.addbtnn.TabIndex = 12;
            this.addbtnn.Text = "Add";
            this.addbtnn.UseVisualStyleBackColor = true;
            this.addbtnn.Click += new System.EventHandler(this.addbtnn_Click);
            this.addbtnn.MouseEnter += new System.EventHandler(this.addbtnn_MouseEnter);
            this.addbtnn.MouseLeave += new System.EventHandler(this.addbtnn_MouseLeave);
            // 
            // updatebtn
            // 
            this.updatebtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.updatebtn.Location = new System.Drawing.Point(0, 215);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(800, 35);
            this.updatebtn.TabIndex = 10;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.updatebtn_MouseClick);
            this.updatebtn.MouseEnter += new System.EventHandler(this.updatebtn_MouseEnter);
            this.updatebtn.MouseLeave += new System.EventHandler(this.updatebtn_MouseLeave);
            // 
            // clearbtn
            // 
            this.clearbtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.clearbtn.Location = new System.Drawing.Point(0, 250);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(800, 35);
            this.clearbtn.TabIndex = 9;
            this.clearbtn.Text = "Clear";
            this.clearbtn.UseVisualStyleBackColor = true;
            this.clearbtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clearbtn_Click);
            this.clearbtn.MouseEnter += new System.EventHandler(this.clearbtn_MouseEnter);
            this.clearbtn.MouseLeave += new System.EventHandler(this.clearbtn_MouseLeave);
            // 
            // codeTxtbox
            // 
            this.codeTxtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.codeTxtbox.Location = new System.Drawing.Point(142, 98);
            this.codeTxtbox.Name = "codeTxtbox";
            this.codeTxtbox.Size = new System.Drawing.Size(197, 22);
            this.codeTxtbox.TabIndex = 6;
            // 
            // nameTxtbox
            // 
            this.nameTxtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTxtbox.Location = new System.Drawing.Point(142, 54);
            this.nameTxtbox.Name = "nameTxtbox";
            this.nameTxtbox.Size = new System.Drawing.Size(197, 22);
            this.nameTxtbox.TabIndex = 5;
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Location = new System.Drawing.Point(368, 105);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(52, 17);
            this.price.TabIndex = 4;
            this.price.Text = "Price : ";
            // 
            // quantity
            // 
            this.quantity.AutoSize = true;
            this.quantity.Location = new System.Drawing.Point(368, 58);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(73, 17);
            this.quantity.TabIndex = 3;
            this.quantity.Text = "Quantity : ";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(46, 56);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(57, 17);
            this.name.TabIndex = 1;
            this.name.Text = "Name : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Products Entry Data";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewproducts);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 285);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 165);
            this.panel2.TabIndex = 3;
            // 
            // dataGridViewproducts
            // 
            this.dataGridViewproducts.AllowUserToAddRows = false;
            this.dataGridViewproducts.AllowUserToDeleteRows = false;
            this.dataGridViewproducts.AllowUserToResizeColumns = false;
            this.dataGridViewproducts.AllowUserToResizeRows = false;
            this.dataGridViewproducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewproducts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridViewproducts.BackgroundColor = System.Drawing.Color.Snow;
            this.dataGridViewproducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewproducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewproducts.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridViewproducts.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dataGridViewproducts.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewproducts.MultiSelect = false;
            this.dataGridViewproducts.Name = "dataGridViewproducts";
            this.dataGridViewproducts.RowHeadersWidth = 51;
            this.dataGridViewproducts.RowTemplate.Height = 24;
            this.dataGridViewproducts.Size = new System.Drawing.Size(800, 165);
            this.dataGridViewproducts.TabIndex = 2;
            this.dataGridViewproducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewproducts_CellClick);
            this.dataGridViewproducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewproducts_CellContentClick);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Products";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Products_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PriceNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNum)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewproducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addbtnn;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.TextBox codeTxtbox;
        private System.Windows.Forms.TextBox nameTxtbox;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label quantity;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewproducts;
        private System.Windows.Forms.NumericUpDown PriceNum;
        private System.Windows.Forms.NumericUpDown quantityNum;
    }
}