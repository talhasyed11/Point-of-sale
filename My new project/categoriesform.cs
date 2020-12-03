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
    public partial class categoriesform : Form
    {
        public categoriesform()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Acer\Documents\StoreDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void label8_Click(object sender, EventArgs e)
        {
            try
            {

                Con.Open();
                
                String query = "insert into CategoryTable (CatName, Catdescription) values('" + Catname.Text + "','" + CatDes.Text + "')";
                SqlCommand cmd = new SqlCommand(query,Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category is added Successfully");
                Con.Close();
                populate();
                cleartext();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                Con.Close();
            }
        }
        private void populate() {
            Con.Open();
            String query = "select * from CategoryTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CatDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void categoriesform_Load(object sender, EventArgs e)
        {
            populate();
            CatID.Hide();
            label3.Hide();
            label9.Hide();
            label10.Hide();
           
        }


        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            label8.Hide();
            label9.Show();
            label10.Show();
            CatID.Text = CatDGV.SelectedRows[0].Cells[0].Value.ToString();
            Catname.Text = CatDGV.SelectedRows[0].Cells[1].Value.ToString();
            CatDes.Text = CatDGV.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void label10_Click(object sender, EventArgs e)
        {

            try
            {
                if (Catname.Text == "")
                {
                    MessageBox.Show("Select the category to delete");
                }
                else {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete the employee information ?", "Some Title", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {

                        Con.Open();
                        String query = "delete from CategoryTable where CatID = " + CatID.Text + "";
                        SqlCommand cmd = new SqlCommand(query, Con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Category is deleted Successfully");
                        Con.Close();
                        populate();
                        cleartext();

                        label9.Hide();
                        label10.Hide();
                    }
                    else {
                        label9.Hide();
                        label10.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            label8.Show();
        }
        public void cleartext() {
            CatID.Clear();
            Catname.Clear();
            CatDes.Clear();
        }
        private void label11_Click(object sender, EventArgs e)
        {
            cleartext();
            label9.Hide();
            label10.Hide();
            label8.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            try
            {
                if (CatID.Text == "")
                {
                    MessageBox.Show("Select the category to update");
                }
                else
                {
                    Con.Open();
                    String query = "update CategoryTable set CatName='" + Catname.Text + "',CatDescription='" + CatDes.Text + "'where CatID = '" + CatID.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category is Updated Successfully");
                    Con.Close();
                    populate();
                    cleartext();
                    populate();
                    label9.Hide();
                    label10.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Con.Close();
            }
            label8.Show();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Product_form cf = new Product_form();
            cf.Show();
            this.Hide();

        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form1 cf = new Form1();
            cf.Show();
            this.Hide();
        }

       
        private void label17_Click(object sender, EventArgs e)
        {
            Main_Menu cf = new Main_Menu();
            cf.Show();
            this.Hide();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            Form1 cf = new Form1();
            cf.Show();
            this.Hide();
        }

        private void CatID_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void categoriesform_FormClosed(object sender, FormClosedEventArgs e)
        {
          
        }

        private void categoriesform_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
