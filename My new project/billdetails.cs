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
    public partial class billdetails : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Acer\Documents\StoreDB.mdf;Integrated Security=True;Connect Timeout=30");

        public billdetails()
        {
            InitializeComponent();
        }
        string bill;
        private void populate()
        {

            
            bill = Sales.billid;
            //MessageBox.Show(bill);
            Con.Open();
            String query = "select * from solditems where billid ='"+bill+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            billdetaildgv.DataSource = ds.Tables[0];
            Con.Close();
        }
        string firstVariable = string.Empty;
        string secondVariable = string.Empty;
        private void billdetails_Load(object sender, EventArgs e)
        {
            populate();
           
            getdata();
            TotalPrice.Text = secondVariable;
            labelbill.Text = bill;
            label4.Text = firstVariable;

           
        }

        private void getdata() {
            try
            {

                   using (SqlCommand command = new SqlCommand("select items, amount from billdb where billid ='" + bill + "'", Con))
                    {
                        Con.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                firstVariable = reader[0].ToString();
                                secondVariable = reader[1].ToString();
                            }
                        }
                    }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void billdetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void billdetaildgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
