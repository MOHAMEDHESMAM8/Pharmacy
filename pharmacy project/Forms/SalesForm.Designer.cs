
namespace pharmacy_project.Forms
{
    partial class SalesForm
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panelspace = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.quantity = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.product1 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.saveInvoice = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel2quantity = new System.Windows.Forms.NumericUpDown();
            this.product2 = new System.Windows.Forms.Label();
            this.panel2price = new System.Windows.Forms.TextBox();
            this.panel2name = new System.Windows.Forms.TextBox();
            this.panel2id = new System.Windows.Forms.TextBox();
            this.panel = new System.Windows.Forms.Panel();
            this.panel3quantity = new System.Windows.Forms.NumericUpDown();
            this.product3 = new System.Windows.Forms.Label();
            this.panel3price = new System.Windows.Forms.TextBox();
            this.panel3name = new System.Windows.Forms.TextBox();
            this.panel3id = new System.Windows.Forms.TextBox();
            this.invoicetotalbox = new System.Windows.Forms.TextBox();
            this.delete1 = new System.Windows.Forms.Button();
            this.delete2 = new System.Windows.Forms.Button();
            this.delete3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel2quantity)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel3quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox1.DropDownHeight = 107;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.Location = new System.Drawing.Point(0, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(800, 24);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Text = "Enter Name";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // panelspace
            // 
            this.panelspace.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelspace.Location = new System.Drawing.Point(0, 24);
            this.panelspace.Name = "panelspace";
            this.panelspace.Size = new System.Drawing.Size(800, 132);
            this.panelspace.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.delete1);
            this.panel1.Controls.Add(this.quantity);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.product1);
            this.panel1.Controls.Add(this.price);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.id);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 156);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 62);
            this.panel1.TabIndex = 6;
            // 
            // quantity
            // 
            this.quantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.quantity.DecimalPlaces = 1;
            this.quantity.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.quantity.Location = new System.Drawing.Point(435, 21);
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Size = new System.Drawing.Size(120, 22);
            this.quantity.TabIndex = 6;
            this.quantity.ValueChanged += new System.EventHandler(this.quantitynum_ValueChanged);
            this.quantity.Click += new System.EventHandler(this.quantity_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(58, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(84, 73);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.Visible = false;
            // 
            // product1
            // 
            this.product1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.product1.AutoSize = true;
            this.product1.Location = new System.Drawing.Point(23, 22);
            this.product1.Name = "product1";
            this.product1.Size = new System.Drawing.Size(54, 17);
            this.product1.TabIndex = 4;
            this.product1.Text = "item1 : ";
            // 
            // price
            // 
            this.price.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.price.Location = new System.Drawing.Point(589, 19);
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Size = new System.Drawing.Size(141, 22);
            this.price.TabIndex = 3;
            this.price.Text = "0";
            // 
            // name
            // 
            this.name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.name.Location = new System.Drawing.Point(264, 19);
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Size = new System.Drawing.Size(141, 22);
            this.name.TabIndex = 1;
            // 
            // id
            // 
            this.id.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.id.Location = new System.Drawing.Point(106, 19);
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Size = new System.Drawing.Size(131, 22);
            this.id.TabIndex = 0;
            // 
            // saveInvoice
            // 
            this.saveInvoice.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.saveInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveInvoice.Location = new System.Drawing.Point(0, 492);
            this.saveInvoice.Name = "saveInvoice";
            this.saveInvoice.Size = new System.Drawing.Size(800, 47);
            this.saveInvoice.TabIndex = 7;
            this.saveInvoice.Text = "save";
            this.saveInvoice.UseVisualStyleBackColor = true;
            this.saveInvoice.Click += new System.EventHandler(this.saveInvoice_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.delete2);
            this.panel2.Controls.Add(this.panel2quantity);
            this.panel2.Controls.Add(this.product2);
            this.panel2.Controls.Add(this.panel2price);
            this.panel2.Controls.Add(this.panel2name);
            this.panel2.Controls.Add(this.panel2id);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 218);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 62);
            this.panel2.TabIndex = 9;
            // 
            // panel2quantity
            // 
            this.panel2quantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2quantity.DecimalPlaces = 1;
            this.panel2quantity.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.panel2quantity.Location = new System.Drawing.Point(435, 20);
            this.panel2quantity.Name = "panel2quantity";
            this.panel2quantity.ReadOnly = true;
            this.panel2quantity.Size = new System.Drawing.Size(120, 22);
            this.panel2quantity.TabIndex = 7;
            this.panel2quantity.ValueChanged += new System.EventHandler(this.panel2quantity_ValueChanged);
            this.panel2quantity.Click += new System.EventHandler(this.panel2quantity_Click);
            // 
            // product2
            // 
            this.product2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.product2.AutoSize = true;
            this.product2.Location = new System.Drawing.Point(23, 19);
            this.product2.Name = "product2";
            this.product2.Size = new System.Drawing.Size(54, 17);
            this.product2.TabIndex = 5;
            this.product2.Text = "item2 : ";
            // 
            // panel2price
            // 
            this.panel2price.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel2price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2price.Location = new System.Drawing.Point(589, 16);
            this.panel2price.Name = "panel2price";
            this.panel2price.ReadOnly = true;
            this.panel2price.Size = new System.Drawing.Size(141, 22);
            this.panel2price.TabIndex = 3;
            this.panel2price.Text = "0";
            // 
            // panel2name
            // 
            this.panel2name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2name.Location = new System.Drawing.Point(264, 16);
            this.panel2name.Name = "panel2name";
            this.panel2name.ReadOnly = true;
            this.panel2name.Size = new System.Drawing.Size(141, 22);
            this.panel2name.TabIndex = 1;
            // 
            // panel2id
            // 
            this.panel2id.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel2id.Location = new System.Drawing.Point(106, 16);
            this.panel2id.Name = "panel2id";
            this.panel2id.ReadOnly = true;
            this.panel2id.Size = new System.Drawing.Size(131, 22);
            this.panel2id.TabIndex = 0;
            // 
            // panel
            // 
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.delete3);
            this.panel.Controls.Add(this.panel3quantity);
            this.panel.Controls.Add(this.product3);
            this.panel.Controls.Add(this.panel3price);
            this.panel.Controls.Add(this.panel3name);
            this.panel.Controls.Add(this.panel3id);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 280);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(800, 62);
            this.panel.TabIndex = 10;
            // 
            // panel3quantity
            // 
            this.panel3quantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3quantity.DecimalPlaces = 1;
            this.panel3quantity.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.panel3quantity.Location = new System.Drawing.Point(435, 20);
            this.panel3quantity.Name = "panel3quantity";
            this.panel3quantity.ReadOnly = true;
            this.panel3quantity.Size = new System.Drawing.Size(120, 22);
            this.panel3quantity.TabIndex = 7;
            this.panel3quantity.ValueChanged += new System.EventHandler(this.panel3quantity_ValueChanged);
            this.panel3quantity.Click += new System.EventHandler(this.panel3quantity_Click);
            // 
            // product3
            // 
            this.product3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.product3.AutoSize = true;
            this.product3.Location = new System.Drawing.Point(23, 18);
            this.product3.Name = "product3";
            this.product3.Size = new System.Drawing.Size(54, 17);
            this.product3.TabIndex = 5;
            this.product3.Text = "item3 : ";
            // 
            // panel3price
            // 
            this.panel3price.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel3price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3price.Location = new System.Drawing.Point(589, 18);
            this.panel3price.Name = "panel3price";
            this.panel3price.ReadOnly = true;
            this.panel3price.Size = new System.Drawing.Size(141, 22);
            this.panel3price.TabIndex = 3;
            this.panel3price.Text = "0";
            // 
            // panel3name
            // 
            this.panel3name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3name.Location = new System.Drawing.Point(264, 18);
            this.panel3name.Name = "panel3name";
            this.panel3name.ReadOnly = true;
            this.panel3name.Size = new System.Drawing.Size(141, 22);
            this.panel3name.TabIndex = 1;
            // 
            // panel3id
            // 
            this.panel3id.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel3id.Location = new System.Drawing.Point(106, 18);
            this.panel3id.Name = "panel3id";
            this.panel3id.ReadOnly = true;
            this.panel3id.Size = new System.Drawing.Size(131, 22);
            this.panel3id.TabIndex = 0;
            // 
            // invoicetotalbox
            // 
            this.invoicetotalbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.invoicetotalbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.invoicetotalbox.ForeColor = System.Drawing.Color.YellowGreen;
            this.invoicetotalbox.Location = new System.Drawing.Point(647, 448);
            this.invoicetotalbox.Name = "invoicetotalbox";
            this.invoicetotalbox.ReadOnly = true;
            this.invoicetotalbox.Size = new System.Drawing.Size(141, 22);
            this.invoicetotalbox.TabIndex = 11;
            // 
            // delete1
            // 
            this.delete1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.delete1.FlatAppearance.BorderSize = 0;
            this.delete1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete1.Image = global::pharmacy_project.Properties.Resources.remove;
            this.delete1.Location = new System.Drawing.Point(754, 12);
            this.delete1.Name = "delete1";
            this.delete1.Size = new System.Drawing.Size(33, 36);
            this.delete1.TabIndex = 7;
            this.delete1.UseVisualStyleBackColor = true;
            this.delete1.Click += new System.EventHandler(this.delete1_Click);
            // 
            // delete2
            // 
            this.delete2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.delete2.FlatAppearance.BorderSize = 0;
            this.delete2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete2.Image = global::pharmacy_project.Properties.Resources.remove;
            this.delete2.Location = new System.Drawing.Point(754, 12);
            this.delete2.Name = "delete2";
            this.delete2.Size = new System.Drawing.Size(33, 36);
            this.delete2.TabIndex = 8;
            this.delete2.UseVisualStyleBackColor = true;
            this.delete2.Click += new System.EventHandler(this.delete2_Click);
            // 
            // delete3
            // 
            this.delete3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.delete3.FlatAppearance.BorderSize = 0;
            this.delete3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete3.Image = global::pharmacy_project.Properties.Resources.remove;
            this.delete3.Location = new System.Drawing.Point(754, 8);
            this.delete3.Name = "delete3";
            this.delete3.Size = new System.Drawing.Size(33, 36);
            this.delete3.TabIndex = 8;
            this.delete3.UseVisualStyleBackColor = true;
            this.delete3.Click += new System.EventHandler(this.delete3_Click);
            // 
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 539);
            this.Controls.Add(this.invoicetotalbox);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.saveInvoice);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelspace);
            this.Controls.Add(this.comboBox1);
            this.Name = "SalesForm";
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.SalesForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel2quantity)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel3quantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panelspace;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Button saveInvoice;
        private System.Windows.Forms.Label product1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label product2;
        private System.Windows.Forms.TextBox panel2price;
        private System.Windows.Forms.TextBox panel2name;
        private System.Windows.Forms.TextBox panel2id;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label product3;
        private System.Windows.Forms.TextBox panel3price;
        private System.Windows.Forms.TextBox panel3name;
        private System.Windows.Forms.TextBox panel3id;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.NumericUpDown quantity;
        private System.Windows.Forms.NumericUpDown panel2quantity;
        private System.Windows.Forms.NumericUpDown panel3quantity;
        private System.Windows.Forms.TextBox invoicetotalbox;
        private System.Windows.Forms.Button delete1;
        private System.Windows.Forms.Button delete2;
        private System.Windows.Forms.Button delete3;
    }
}