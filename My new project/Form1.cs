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

    public partial class Form1 : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Acer\Documents\StoreDB.mdf;Integrated Security=True;Connect Timeout=30");

        public Form1()
        {
            InitializeComponent();
        }
     
        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }
        
        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Uname.Clear();
            Pass.Clear();
        }


        public static String Username = "";
        public static string SetValueForText1 = "";
        private void button5_Click(object sender, EventArgs e)
        {
            if (Uname.Text == "" || Pass.Text == "")
            {
                MessageBox.Show("Missing user name or password");
            }
            else if (Role.SelectedItem == null)
            {
                MessageBox.Show("Please select your position");
                return;
            }
            else
            {
                if (Role.SelectedItem.ToString() == "Admin")
                {
                    if (Uname.Text == "Admin" && Pass.Text == "Admin")
                    {
                        Main_Menu pf = new Main_Menu();
                        pf.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Please Enter Correct Password");
                    }
                }
                else if (Role.SelectedItem.ToString() == "Sales Man")
                {

                    Con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("Select count(8) from SellerTable where CONVERT(VARCHAR, SellerName)='" + Uname.Text + "' and CONVERT(VARCHAR, SellerPassword)='" + Pass.Text + "'", Con);
                    DataTable dt = new DataTable();
                    SetValueForText1 = Uname.Text;
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        Shopform pf = new Shopform();
                        pf.Show();
                        this.Hide();
                        
    }
                    else
                    {
                        MessageBox.Show("Incorect");
                    }
                    Con.Close();
                }

               
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
