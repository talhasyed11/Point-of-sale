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
namespace My_new_project
{
    public partial class Product_form : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Acer\Documents\StoreDB.mdf;Integrated Security=True;Connect Timeout=30");

        public Product_form()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void fillcombo() {
            //Fill the category
            Con.Open();
            String query = "select CatName from CategoryTable";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CatName", typeof(String));
            dt.Load(rdr);
            categorycombo.ValueMember = "CatName";
            categorycombo.DataSource = dt;
            categorycombo2.ValueMember = "CatName";
            categorycombo2.DataSource = dt;
            Con.Close();

        }

        private void Product_form_Load(object sender, EventArgs e)
        {
            fillcombo();
            populate();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            categoriesform cf = new categoriesform();
            cf.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            if (ProID.Text == "" || ProName.Text == "" || ProQty.Text == "" || ProPrice.Text == "")
            {
                MessageBox.Show("Please enter the product details");
            }
            else {
                
                try
                {
                    Con.Open();
                    String query = "insert into ProductTable values(" + ProID.Text + ",'" + ProName.Text + "','" + ProQty.Text + "','" + categorycombo.SelectedValue.ToString() + "','" + ProPrice.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product added Successfully");
                    Con.Close();
                    populate();
                    cleartext();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Con.Close();
                }
            }
        }
        private void populate()
        {
            Con.Open();
            String query = "select * from ProductTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void ProDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProID.Text = ProDGV.SelectedRows[0].Cells[0].Value.ToString();
            ProName.Text = ProDGV.SelectedRows[0].Cells[1].Value.ToString();
            ProQty.Text = ProDGV.SelectedRows[0].Cells[2].Value.ToString();
            categorycombo.SelectedValue = ProDGV.SelectedRows[0].Cells[3].Value.ToString();
            ProPrice.Text = ProDGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                String query = "delete from ProductTable where ProductID = "+ ProID.Text+"";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Deleted Successfully");
                Con.Close();
                populate();
                cleartext();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Con.Close();
            }
        }
        public void cleartext()
        {
            ProID.Clear();
            ProName.Clear();
            ProQty.Clear();
            ProPrice.Clear();
            categorycombo.SelectedIndex.Equals(String.Empty);
        }

        private void label9_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProID.Text == "")
                {
                    MessageBox.Show("Select the category to delete");
                }
                else
                {
                    Con.Open();
                    String query = "update ProductTable set ProductName='" + ProName.Text + "',ProductQty='" + ProQty.Text + "',Productcategory='" + categorycombo.SelectedValue + "',Price='" + ProPrice.Text + "'where Productid = " + ProID.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category is Updated Successfully");
                    Con.Close();
                    populate();
                    cleartext();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Con.Close();
            }
        }

       
        
       
        private void label1_Click_1(object sender, EventArgs e)
        {
            Main_Menu SF = new Main_Menu();
            SF.Show();
            this.Hide();
        }

        private void label12_Click_1(object sender, EventArgs e)
        {
            Form1 SF = new Form1();
            SF.Show();
            this.Hide();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ProID_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void ProQty_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void ProName_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void ProPrice_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void refresh_Click(object sender, EventArgs e)
        {
            //Orderdgv.Rows.Clear();
            String catergory = this.categorycombo2.GetItemText(this.categorycombo2.SelectedItem);
            //MessageBox.Show(catergory);
            try
            {
                Con.Open();
                String query = "select * from ProductTable where Productcategory = '" + catergory + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                ProDGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
        }

        private void categorycombo2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void ProQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!char.IsDigit(chr) && chr!=8)
            {
                e.Handled = true;
            }
        }

        private void ProPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
            }
        }

        private void ProID_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            Char chr = e.KeyChar;
            if (!char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
            }
        }
       
    }
    }

