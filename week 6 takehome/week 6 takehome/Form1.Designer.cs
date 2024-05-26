namespace week_6_takehome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.datagridview_allproduct = new System.Windows.Forms.DataGridView();
            this.label_product = new System.Windows.Forms.Label();
            this.button_all = new System.Windows.Forms.Button();
            this.button_filter = new System.Windows.Forms.Button();
            this.combobox_filter = new System.Windows.Forms.ComboBox();
            this.label_category = new System.Windows.Forms.Label();
            this.datagridview_category = new System.Windows.Forms.DataGridView();
            this.label_namacategory = new System.Windows.Forms.Label();
            this.textbox_namacategory = new System.Windows.Forms.TextBox();
            this.button_addcategory = new System.Windows.Forms.Button();
            this.button_removecategory = new System.Windows.Forms.Button();
            this.label_detail = new System.Windows.Forms.Label();
            this.label_namadetail = new System.Windows.Forms.Label();
            this.textbox_namadetail = new System.Windows.Forms.TextBox();
            this.label_categorydetail = new System.Windows.Forms.Label();
            this.combobox_categorydetail = new System.Windows.Forms.ComboBox();
            this.label_harga = new System.Windows.Forms.Label();
            this.textbox_harga = new System.Windows.Forms.TextBox();
            this.label_stock = new System.Windows.Forms.Label();
            this.textbox_stock = new System.Windows.Forms.TextBox();
            this.button_addproduct = new System.Windows.Forms.Button();
            this.button_editproduct = new System.Windows.Forms.Button();
            this.button_removeproduct = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_allproduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_category)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridview_allproduct
            // 
            this.datagridview_allproduct.AllowUserToAddRows = false;
            this.datagridview_allproduct.AllowUserToDeleteRows = false;
            this.datagridview_allproduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridview_allproduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview_allproduct.Location = new System.Drawing.Point(12, 87);
            this.datagridview_allproduct.Name = "datagridview_allproduct";
            this.datagridview_allproduct.ReadOnly = true;
            this.datagridview_allproduct.RowHeadersVisible = false;
            this.datagridview_allproduct.RowHeadersWidth = 62;
            this.datagridview_allproduct.RowTemplate.Height = 28;
            this.datagridview_allproduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridview_allproduct.Size = new System.Drawing.Size(585, 293);
            this.datagridview_allproduct.TabIndex = 0;
            this.datagridview_allproduct.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.datagridview_allproduct_CellMouseClick);
            // 
            // label_product
            // 
            this.label_product.AutoSize = true;
            this.label_product.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_product.Location = new System.Drawing.Point(12, 43);
            this.label_product.Name = "label_product";
            this.label_product.Size = new System.Drawing.Size(116, 33);
            this.label_product.TabIndex = 1;
            this.label_product.Text = "Product";
            // 
            // button_all
            // 
            this.button_all.Location = new System.Drawing.Point(289, 48);
            this.button_all.Name = "button_all";
            this.button_all.Size = new System.Drawing.Size(75, 33);
            this.button_all.TabIndex = 2;
            this.button_all.Text = "All";
            this.button_all.UseVisualStyleBackColor = true;
            this.button_all.Click += new System.EventHandler(this.button_all_Click);
            // 
            // button_filter
            // 
            this.button_filter.Location = new System.Drawing.Point(384, 48);
            this.button_filter.Name = "button_filter";
            this.button_filter.Size = new System.Drawing.Size(75, 33);
            this.button_filter.TabIndex = 3;
            this.button_filter.Text = "Filter: ";
            this.button_filter.UseVisualStyleBackColor = true;
            this.button_filter.Click += new System.EventHandler(this.button_filter_Click);
            // 
            // combobox_filter
            // 
            this.combobox_filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_filter.FormattingEnabled = true;
            this.combobox_filter.Location = new System.Drawing.Point(476, 51);
            this.combobox_filter.Name = "combobox_filter";
            this.combobox_filter.Size = new System.Drawing.Size(121, 28);
            this.combobox_filter.TabIndex = 4;
            this.combobox_filter.SelectedIndexChanged += new System.EventHandler(this.combobox_filter_SelectedIndexChanged);
            // 
            // label_category
            // 
            this.label_category.AutoSize = true;
            this.label_category.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_category.Location = new System.Drawing.Point(704, 43);
            this.label_category.Name = "label_category";
            this.label_category.Size = new System.Drawing.Size(132, 33);
            this.label_category.TabIndex = 5;
            this.label_category.Text = "Category";
            // 
            // datagridview_category
            // 
            this.datagridview_category.AllowUserToAddRows = false;
            this.datagridview_category.AllowUserToDeleteRows = false;
            this.datagridview_category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview_category.Location = new System.Drawing.Point(701, 87);
            this.datagridview_category.Name = "datagridview_category";
            this.datagridview_category.ReadOnly = true;
            this.datagridview_category.RowHeadersVisible = false;
            this.datagridview_category.RowHeadersWidth = 62;
            this.datagridview_category.RowTemplate.Height = 28;
            this.datagridview_category.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridview_category.Size = new System.Drawing.Size(303, 185);
            this.datagridview_category.TabIndex = 6;
            this.datagridview_category.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.datagridview_category_CellMouseClick);
            // 
            // label_namacategory
            // 
            this.label_namacategory.AutoSize = true;
            this.label_namacategory.Location = new System.Drawing.Point(697, 295);
            this.label_namacategory.Name = "label_namacategory";
            this.label_namacategory.Size = new System.Drawing.Size(55, 20);
            this.label_namacategory.TabIndex = 7;
            this.label_namacategory.Text = "Nama:";
            // 
            // textbox_namacategory
            // 
            this.textbox_namacategory.Location = new System.Drawing.Point(783, 295);
            this.textbox_namacategory.Name = "textbox_namacategory";
            this.textbox_namacategory.Size = new System.Drawing.Size(221, 26);
            this.textbox_namacategory.TabIndex = 8;
            // 
            // button_addcategory
            // 
            this.button_addcategory.BackColor = System.Drawing.Color.BurlyWood;
            this.button_addcategory.Location = new System.Drawing.Point(783, 340);
            this.button_addcategory.Name = "button_addcategory";
            this.button_addcategory.Size = new System.Drawing.Size(97, 64);
            this.button_addcategory.TabIndex = 9;
            this.button_addcategory.Text = "Add Category";
            this.button_addcategory.UseVisualStyleBackColor = false;
            this.button_addcategory.Click += new System.EventHandler(this.button_addcategory_Click);
            // 
            // button_removecategory
            // 
            this.button_removecategory.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button_removecategory.Location = new System.Drawing.Point(911, 340);
            this.button_removecategory.Name = "button_removecategory";
            this.button_removecategory.Size = new System.Drawing.Size(93, 64);
            this.button_removecategory.TabIndex = 10;
            this.button_removecategory.Text = "Remove Category";
            this.button_removecategory.UseVisualStyleBackColor = false;
            this.button_removecategory.Click += new System.EventHandler(this.button_removecategory_Click);
            // 
            // label_detail
            // 
            this.label_detail.AutoSize = true;
            this.label_detail.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_detail.Location = new System.Drawing.Point(12, 395);
            this.label_detail.Name = "label_detail";
            this.label_detail.Size = new System.Drawing.Size(109, 33);
            this.label_detail.TabIndex = 11;
            this.label_detail.Text = "Details";
            // 
            // label_namadetail
            // 
            this.label_namadetail.AutoSize = true;
            this.label_namadetail.Location = new System.Drawing.Point(14, 441);
            this.label_namadetail.Name = "label_namadetail";
            this.label_namadetail.Size = new System.Drawing.Size(55, 20);
            this.label_namadetail.TabIndex = 12;
            this.label_namadetail.Text = "Nama:";
            // 
            // textbox_namadetail
            // 
            this.textbox_namadetail.Location = new System.Drawing.Point(97, 441);
            this.textbox_namadetail.Name = "textbox_namadetail";
            this.textbox_namadetail.Size = new System.Drawing.Size(443, 26);
            this.textbox_namadetail.TabIndex = 13;
            // 
            // label_categorydetail
            // 
            this.label_categorydetail.AutoSize = true;
            this.label_categorydetail.Location = new System.Drawing.Point(14, 483);
            this.label_categorydetail.Name = "label_categorydetail";
            this.label_categorydetail.Size = new System.Drawing.Size(77, 20);
            this.label_categorydetail.TabIndex = 14;
            this.label_categorydetail.Text = "Category:";
            // 
            // combobox_categorydetail
            // 
            this.combobox_categorydetail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_categorydetail.FormattingEnabled = true;
            this.combobox_categorydetail.Location = new System.Drawing.Point(97, 480);
            this.combobox_categorydetail.Name = "combobox_categorydetail";
            this.combobox_categorydetail.Size = new System.Drawing.Size(151, 28);
            this.combobox_categorydetail.TabIndex = 15;
            // 
            // label_harga
            // 
            this.label_harga.AutoSize = true;
            this.label_harga.Location = new System.Drawing.Point(14, 527);
            this.label_harga.Name = "label_harga";
            this.label_harga.Size = new System.Drawing.Size(57, 20);
            this.label_harga.TabIndex = 16;
            this.label_harga.Text = "Harga:";
            // 
            // textbox_harga
            // 
            this.textbox_harga.Location = new System.Drawing.Point(97, 524);
            this.textbox_harga.Name = "textbox_harga";
            this.textbox_harga.Size = new System.Drawing.Size(151, 26);
            this.textbox_harga.TabIndex = 17;
            this.textbox_harga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_harga_KeyPress);
            // 
            // label_stock
            // 
            this.label_stock.AutoSize = true;
            this.label_stock.Location = new System.Drawing.Point(14, 570);
            this.label_stock.Name = "label_stock";
            this.label_stock.Size = new System.Drawing.Size(54, 20);
            this.label_stock.TabIndex = 18;
            this.label_stock.Text = "Stock:";
            // 
            // textbox_stock
            // 
            this.textbox_stock.Location = new System.Drawing.Point(97, 570);
            this.textbox_stock.Name = "textbox_stock";
            this.textbox_stock.Size = new System.Drawing.Size(151, 26);
            this.textbox_stock.TabIndex = 19;
            this.textbox_stock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_stock_KeyPress);
            // 
            // button_addproduct
            // 
            this.button_addproduct.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.button_addproduct.Location = new System.Drawing.Point(277, 520);
            this.button_addproduct.Name = "button_addproduct";
            this.button_addproduct.Size = new System.Drawing.Size(87, 70);
            this.button_addproduct.TabIndex = 20;
            this.button_addproduct.Text = "Add Product";
            this.button_addproduct.UseVisualStyleBackColor = false;
            this.button_addproduct.Click += new System.EventHandler(this.button_addproduct_Click);
            // 
            // button_editproduct
            // 
            this.button_editproduct.BackColor = System.Drawing.Color.Moccasin;
            this.button_editproduct.Location = new System.Drawing.Point(370, 520);
            this.button_editproduct.Name = "button_editproduct";
            this.button_editproduct.Size = new System.Drawing.Size(89, 70);
            this.button_editproduct.TabIndex = 21;
            this.button_editproduct.Text = "Edit Product";
            this.button_editproduct.UseVisualStyleBackColor = false;
            this.button_editproduct.Click += new System.EventHandler(this.button_editproduct_Click);
            // 
            // button_removeproduct
            // 
            this.button_removeproduct.BackColor = System.Drawing.Color.Tomato;
            this.button_removeproduct.ForeColor = System.Drawing.Color.White;
            this.button_removeproduct.Location = new System.Drawing.Point(465, 520);
            this.button_removeproduct.Name = "button_removeproduct";
            this.button_removeproduct.Size = new System.Drawing.Size(82, 70);
            this.button_removeproduct.TabIndex = 22;
            this.button_removeproduct.Text = "Remove Product";
            this.button_removeproduct.UseVisualStyleBackColor = false;
            this.button_removeproduct.Click += new System.EventHandler(this.button_removeproduct_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(772, 410);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(295, 229);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1037, 640);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_removeproduct);
            this.Controls.Add(this.button_editproduct);
            this.Controls.Add(this.button_addproduct);
            this.Controls.Add(this.textbox_stock);
            this.Controls.Add(this.label_stock);
            this.Controls.Add(this.textbox_harga);
            this.Controls.Add(this.label_harga);
            this.Controls.Add(this.combobox_categorydetail);
            this.Controls.Add(this.label_categorydetail);
            this.Controls.Add(this.textbox_namadetail);
            this.Controls.Add(this.label_namadetail);
            this.Controls.Add(this.label_detail);
            this.Controls.Add(this.button_removecategory);
            this.Controls.Add(this.button_addcategory);
            this.Controls.Add(this.textbox_namacategory);
            this.Controls.Add(this.label_namacategory);
            this.Controls.Add(this.datagridview_category);
            this.Controls.Add(this.label_category);
            this.Controls.Add(this.combobox_filter);
            this.Controls.Add(this.button_filter);
            this.Controls.Add(this.button_all);
            this.Controls.Add(this.label_product);
            this.Controls.Add(this.datagridview_allproduct);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_allproduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_category)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridview_allproduct;
        private System.Windows.Forms.Label label_product;
        private System.Windows.Forms.Button button_all;
        private System.Windows.Forms.Button button_filter;
        private System.Windows.Forms.ComboBox combobox_filter;
        private System.Windows.Forms.Label label_category;
        private System.Windows.Forms.DataGridView datagridview_category;
        private System.Windows.Forms.Label label_namacategory;
        private System.Windows.Forms.TextBox textbox_namacategory;
        private System.Windows.Forms.Button button_addcategory;
        private System.Windows.Forms.Button button_removecategory;
        private System.Windows.Forms.Label label_detail;
        private System.Windows.Forms.Label label_namadetail;
        private System.Windows.Forms.TextBox textbox_namadetail;
        private System.Windows.Forms.Label label_categorydetail;
        private System.Windows.Forms.ComboBox combobox_categorydetail;
        private System.Windows.Forms.Label label_harga;
        private System.Windows.Forms.TextBox textbox_harga;
        private System.Windows.Forms.Label label_stock;
        private System.Windows.Forms.TextBox textbox_stock;
        private System.Windows.Forms.Button button_addproduct;
        private System.Windows.Forms.Button button_editproduct;
        private System.Windows.Forms.Button button_removeproduct;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

