using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week_6_takehome
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        DataTable dtProdukSimpan = new DataTable();
        DataTable dtProdukTampil = new DataTable();
        DataTable dtCategory = new DataTable();
        List<string> listIDProduct = new List<string>();
        List<string> listnamaproduct = new List<string>();
        List<int> listharga = new List<int>();  
        List<int> liststock = new List<int>();
        List<string> listidcat = new List<string>();
        List<string> listnamacat = new List<string>();
        List<string> listidcatdicat = new List<string>();
        DataRow row;
        
        private void Form1_Load(object sender, EventArgs e)
        {

            dtProdukSimpan.Columns.Add("ID Product");
            dtProdukSimpan.Columns.Add("Nama Product");
            dtProdukSimpan.Columns.Add("Harga");
            dtProdukSimpan.Columns.Add("Stock");
            dtProdukSimpan.Columns.Add("ID Category");
            datagridview_allproduct.DataSource = dtProdukSimpan;

            dtProdukTampil.Columns.Add("ID Product");
            dtProdukTampil.Columns.Add("Nama Product");
            dtProdukTampil.Columns.Add("Harga");
            dtProdukTampil.Columns.Add("Stock");
            dtProdukTampil.Columns.Add("ID Category");

            dtCategory.Columns.Add("ID Category");
            dtCategory.Columns.Add("Nama Category");
            datagridview_category.DataSource = dtCategory;
            

            listIDProduct.Add("J001");
            listIDProduct.Add("T001");
            listIDProduct.Add("T002");
            listIDProduct.Add("R001");
            listIDProduct.Add("J002");
            listIDProduct.Add("C001");
            listIDProduct.Add("C002");
            listIDProduct.Add("R002");
            listnamaproduct.Add("Jas Hitam");
            listnamaproduct.Add("T-Shirt Blackpink");
            listnamaproduct.Add("T-Shirt Uniqlo");
            listnamaproduct.Add("Rok Mini");
            listnamaproduct.Add("Jeans Biru");
            listnamaproduct.Add("Celana Pendek Coklat");
            listnamaproduct.Add("Cawat Tartan");
            listnamaproduct.Add("Rocca Shirt");
            listharga.Add(100000);
            listharga.Add(70000);
            listharga.Add(75000);
            listharga.Add(82000);
            listharga.Add(90000);
            listharga.Add(60000);
            listharga.Add(1000000);
            listharga.Add(50000);
            liststock.Add(10);
            liststock.Add(20);
            liststock.Add(16);
            liststock.Add(26);
            liststock.Add(5);
            liststock.Add(11);
            liststock.Add(1);
            liststock.Add(8);
            listidcat.Add("C1");
            listidcat.Add("C2");
            listidcat.Add("C2");
            listidcat.Add("C3");
            listidcat.Add("C4");
            listidcat.Add("C4");
            listidcat.Add("C5");
            listidcat.Add("C2");
            listidcatdicat.Add("C1");
            listidcatdicat.Add("C2");
            listidcatdicat.Add("C3");
            listidcatdicat.Add("C4");
            listidcatdicat.Add("C5");
            listnamacat.Add("Jas");
            listnamacat.Add("T-Shirt");
            listnamacat.Add("Rok");
            listnamacat.Add("Celana");
            listnamacat.Add("Cawat");

            foreach (string a in listIDProduct)
            {
                int index = listIDProduct.IndexOf(a);
                
                dtProdukSimpan.Rows.Add(listIDProduct[index],listnamaproduct[index],
                    listharga[index],liststock[index],listidcat[index]);
            }
            for (int j = 0; j < listidcatdicat.Count; j++)
            {
                row = dtCategory.NewRow();
                row[0] = listidcatdicat[j];
                row[1] = listnamacat[j];
                dtCategory.Rows.Add(row);
            }
            datagridview_allproduct.ClearSelection();
            datagridview_category.ClearSelection();
            combobox_filter.Enabled = false;
            foreach (string s in listnamacat)
            {
                combobox_categorydetail.Items.Add(s);
                combobox_filter.Items.Add(s);
            }
        }

        private void textbox_harga_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textbox_stock_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button_addcategory_Click(object sender, EventArgs e)
        {
            if (textbox_namacategory.Text == "")
            {
                MessageBox.Show("Diisi dulu dong bray", "Error cuy",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int num = 1;
                bool yaa = false;
                if (listnamacat.Contains(textbox_namacategory.Text))
                {
                    yaa = true;
                }
                if (yaa)
                {
                    MessageBox.Show("Category udah ada","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!yaa)
                {
                    foreach (string t in listidcatdicat)
                    {
                        if (t.StartsWith("C"))
                        {
                            int num2 = int.Parse(t.Substring(1));
                            if (num2 >= num)
                            {
                                num = num2 + 1;
                            }
                        }
                    }

                    string idcats = "C"+(num).ToString();
                    listidcatdicat.Add(idcats);
                    datagridview_category.ClearSelection(); 
                    combobox_categorydetail.Items.Add(textbox_namacategory.Text);
                    combobox_filter.Items.Add(textbox_namacategory.Text);
                    listnamacat.Add(textbox_namacategory.Text);
                    dtCategory.Rows.Add(idcats,textbox_namacategory.Text);
                    textbox_namacategory.Clear();
                }
            }
        }

        private void button_addproduct_Click(object sender, EventArgs e)
        {
            if (textbox_harga.Text == "" || combobox_categorydetail.SelectedIndex == -1 ||textbox_namadetail.Text == ""||textbox_stock.Text == "") 
            {
                MessageBox.Show("Seenggaknya diisi yang lengkap dulu dong bray", "Error cuy", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textbox_harga.Text = "";
                combobox_categorydetail.SelectedIndex = -1;
                textbox_namadetail.Text = "";
                textbox_stock.Text = "";

            }
            else
            {
                string hurufpertama = textbox_namadetail.Text.Substring(0, 1).ToUpper();
                int nomer = 0;

                foreach (string g in listIDProduct)
                {
                    char a = g[0];
                    string b = a.ToString();
                    if (b == hurufpertama)
                    {
                        int nomer2 = Convert.ToInt32(g.Substring(1));
                        if (nomer <= nomer2)
                        {
                            nomer = nomer2;
                        }
                    }
                }
                string kode = hurufpertama;
                for (int i = nomer.ToString().Length; i < 3; i++)
                {
                    kode = kode + "0";
                }
                kode = kode + (nomer + 1).ToString();

                int indeks = combobox_categorydetail.SelectedIndex;
                string c = listidcatdicat[indeks];
                listIDProduct.Add(kode);
                listnamaproduct.Add(textbox_namadetail.Text);
                listharga.Add(Convert.ToInt32(textbox_harga.Text));
                liststock.Add(Convert.ToInt32(textbox_stock.Text));
                listidcat.Add(c);
                
                row = dtProdukSimpan.NewRow();
                row[0] = kode;
                row[1] = textbox_namadetail.Text;
                row[2] = textbox_harga.Text;
                row[3] = textbox_stock.Text;
                row[4] = c;
                dtProdukSimpan.Rows.Add(row);

                textbox_namadetail.Clear();
                textbox_harga.Clear();
                textbox_stock.Clear();
                combobox_categorydetail.SelectedIndex = -1;
            }
        }

        private void button_filter_Click(object sender, EventArgs e)
        {
            combobox_filter.Enabled = true;
        }

        private void button_all_Click(object sender, EventArgs e)
        {
            textbox_namadetail.Clear();
            textbox_harga.Clear();
            textbox_stock.Clear();
            combobox_categorydetail.SelectedIndex = -1;
            combobox_filter.SelectedIndex = -1;
            combobox_filter.Enabled = false;
            datagridview_allproduct.DataSource = dtProdukSimpan;
            datagridview_allproduct.ClearSelection();
            
        }

        private void combobox_filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            datagridview_allproduct.DataSource = dtProdukTampil;
            string y = combobox_filter.Text;
            dtProdukTampil.Clear();
            foreach (DataRow row in dtCategory.Rows)
            {
                if (y == row[1].ToString())
                {
                    foreach (DataRow dataRow in dtProdukSimpan.Rows)
                    {
                        if (dataRow["ID Category"].ToString() == row[0].ToString())
                        {
                            dtProdukTampil.Rows.Add(dataRow["ID Product"], dataRow["Nama Product"], dataRow["Harga"], dataRow["Stock"], dataRow["ID Category"]);
                        }
                    }
                }
            }
            datagridview_allproduct.ClearSelection();
        
        }

        private void datagridview_allproduct_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textbox_namadetail.Text = datagridview_allproduct.CurrentRow.Cells["Nama Product"].Value.ToString();
            textbox_harga.Text = datagridview_allproduct.CurrentRow.Cells["Harga"].Value.ToString();
            textbox_stock.Text = datagridview_allproduct.CurrentRow.Cells["Stock"].Value.ToString();

            int index = listidcatdicat.FindIndex(a => a.Contains(datagridview_allproduct.CurrentRow.Cells["ID Category"].Value.ToString()));
            string o = listnamacat[index];
            combobox_categorydetail.Text = o;

        }

        private void button_editproduct_Click(object sender, EventArgs e)
        {
            if (datagridview_allproduct.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih dulu item yang mau kamu ganti", "Error cuy", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
               
                foreach (DataRow row in dtProdukSimpan.Rows)
                {
                    int indeks = combobox_categorydetail.SelectedIndex;
                    int index = listIDProduct.FindIndex(a => a.Contains(datagridview_allproduct.CurrentRow.Cells["ID Product"].Value.ToString()));
                    string idbaru = "" ;
                    if (row[0].ToString() == listIDProduct[index])
                    {
                        idbaru = listidcatdicat[indeks];
                        row[1] = textbox_namadetail.Text;
                        row[2] = textbox_harga.Text;
                        row[3] = textbox_stock.Text;
                        row[4] = idbaru;
                        if (row[3].ToString() == "0")
                        {
                            dtProdukSimpan.Rows.Remove(row);
                            break;
                        }
                    }
                }
                textbox_namadetail.Clear();
                textbox_harga.Clear();
                textbox_stock.Clear();
                combobox_categorydetail.SelectedIndex = -1;
                datagridview_allproduct.ClearSelection();

            }
        }

        private void button_removeproduct_Click(object sender, EventArgs e)
        {
            if (datagridview_allproduct.SelectedRows.Count != 0)
            {
                int select = datagridview_allproduct.CurrentCell.RowIndex;
                datagridview_allproduct.Rows.RemoveAt(select);

                listIDProduct.RemoveAt(select);
                listnamaproduct.RemoveAt(select);
                listharga.RemoveAt(select);
                liststock.RemoveAt(select);
                listidcat.RemoveAt(select);

                dtProdukSimpan.Clear();
                foreach (string a in listIDProduct)
                {
                    int index = listIDProduct.IndexOf(a);
                    dtProdukSimpan.Rows.Add(listIDProduct[index], listnamaproduct[index],
                        listharga[index], liststock[index], listidcat[index]);
                }
                textbox_namadetail.Clear();
                textbox_harga.Clear();
                textbox_stock.Clear();
                combobox_categorydetail.SelectedIndex = -1;
                datagridview_allproduct.ClearSelection();
            }
           
        }

        private void button_removecategory_Click(object sender, EventArgs e)
        {
            if (dtCategory.Rows.Count == 0) 
            {
                MessageBox.Show("Tidak ada Category", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textbox_namacategory.Text = "";
                return;
            }
            int index = datagridview_category.CurrentCell.RowIndex;
                if (datagridview_category.SelectedRows.Count != 0)
                {
                    string selectedCategoryId = listidcatdicat[index];
                    for (int i = listIDProduct.Count - 1; i >= 0; i--)
                    {
                        if (listidcat[i] == selectedCategoryId)
                        {
                            listIDProduct.RemoveAt(i);
                            listnamaproduct.RemoveAt(i);
                            listharga.RemoveAt(i);
                            liststock.RemoveAt(i);
                            listidcat.RemoveAt(i);
                        }
                    }
                    listidcatdicat.RemoveAt(index);
                    listnamacat.RemoveAt(index);
                    combobox_filter.Items.Remove(textbox_namacategory.Text);
                    combobox_categorydetail.Items.Remove(textbox_namacategory.Text);

                }
                dtCategory.Rows.Clear();
                dtProdukSimpan.Rows.Clear();
                foreach (string a in listIDProduct)
                {
                    int ind = listIDProduct.IndexOf(a);
                    dtProdukSimpan.Rows.Add(listIDProduct[ind], listnamaproduct[ind],
                        listharga[ind], liststock[ind], listidcat[ind]);
                }
                for (int j = 0; j < listidcatdicat.Count; j++)
                {
                    row = dtCategory.NewRow();
                    row[0] = listidcatdicat[j];
                    row[1] = listnamacat[j];
                    dtCategory.Rows.Add(row);
                }
            datagridview_allproduct.DataSource = dtProdukSimpan;
            datagridview_allproduct.ClearSelection();
                datagridview_category.ClearSelection();
                textbox_namacategory.Text = "";

        }

        private void datagridview_category_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textbox_namacategory.Text = datagridview_category.CurrentRow.Cells["Nama Category"].Value.ToString();
        }
    }
}

