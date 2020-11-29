using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_new_project
{
    public partial class Main_Menu : Form
    {
        public Main_Menu()
        {
            InitializeComponent();
        }


        private void Main_Menu_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SellerForm sf = new SellerForm();
            sf.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            categoriesform SF = new categoriesform();
            SF.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Product_form SF = new Product_form();
            SF.Show();
            this.Hide();
        }

 

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 SF = new Form1();
            SF.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Sales SF = new Sales();
            SF.Show();
            this.Hide();
        }
    }
}
