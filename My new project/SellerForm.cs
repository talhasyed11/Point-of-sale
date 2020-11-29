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
    public partial class SellerForm : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Acer\Documents\StoreDB.mdf;Integrated Security=True;Connect Timeout=30");

        public SellerForm()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            Product_form cf = new Product_form();
            cf.Show();
            this.Hide();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            categoriesform cf = new categoriesform();
            cf.Show();
            this.Hide();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SellerForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            try
            {
                if (EID.Text == "" || EName.Text == "" || EAge.Text == "" || EPhone.Text == "" || ECNIC.Text == "" || EPass.Text == "")
                {
                    MessageBox.Show("Feilds are empty");
                }
                else
                {
                    Con.Open();
                    String query = "insert into SellerTable values(" + EID.Text + ",'" + EName.Text + "','" + EAge.Text + "','" + EPhone.Text + "','" + ECNIC.Text + "','" + EPass.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee is added Successfully");
                    Con.Close();
                    cleartext();
                    populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Con.Close();
            }
        }
        private void populate()
        {
            Con.Open();
            String query = "select * from SellerTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            EmpDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void EmpDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EID.Text = EmpDGV.SelectedRows[0].Cells[0].Value.ToString();
            EName.Text = EmpDGV.SelectedRows[0].Cells[1].Value.ToString();
            EAge.Text = EmpDGV.SelectedRows[0].Cells[2].Value.ToString();
            EPhone.Text = EmpDGV.SelectedRows[0].Cells[3].Value.ToString();
            ECNIC.Text = EmpDGV.SelectedRows[0].Cells[4].Value.ToString();
            EPass.Text = EmpDGV.SelectedRows[0].Cells[5].Value.ToString();
        }
        public void cleartext()
        {
            EID.Clear();
            EName.Clear();
            EAge.Clear();
            EPhone.Clear();
            ECNIC.Clear();
            EPass.Clear();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            cleartext();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            try
            {
                if (EID.Text == "")
                {
                    MessageBox.Show("Select the category to delete");
                }
                else
                {
                    Con.Open();
                    String query = "delete from SellerTable where SellerID = " + EID.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category is deleted Successfully");
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

        private void label9_Click(object sender, EventArgs e)
        {
            try
            {
                if (EID.Text == "" || EName.Text == "" || EAge.Text == "" || EPhone.Text == "" || ECNIC.Text == "" || EPass.Text == "")
                {
                    MessageBox.Show("Select the category to Update");
                }
                else
                {
                    Con.Open();
                    String query = "update SellerTable set SellerName='" + EName.Text + "',SellerNumber='" + EPhone.Text + "',SellerIDCard='" + ECNIC.Text + "',SellerPassword='" + EPass.Text + "'where SellerID = " + EID.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Information is Updated Successfully");
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

        private void label17_Click(object sender, EventArgs e)
        {
            Main_Menu cf = new Main_Menu();
            cf.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Main_Menu cf = new Main_Menu();
            cf.Show();
            this.Hide();
        }

      

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click_1(object sender, EventArgs e)
        {

        }

        private void label12_Click_2(object sender, EventArgs e)
        {
            Form1 cf = new Form1();
            cf.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void EPass_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void EPhone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void ECNIC_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void EName_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void EAge_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void EID_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ECNIC_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
            }
        }

        private void EID_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
            }
        }

        private void EAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
            }
        }

        private void EPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
            }
        }
    }
}
