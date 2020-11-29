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
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Acer\Documents\StoreDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void populate()
        {
            Con.Open();
            String query = "select * from billdb";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            guna2DataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void salesdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Sales_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Main_Menu cf = new Main_Menu();
            cf.Show();
            this.Hide();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Form1 cf = new Form1();
            cf.Show();
            this.Hide();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //guna2DataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
