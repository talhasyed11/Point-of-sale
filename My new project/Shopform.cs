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
    public partial class Shopform : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Acer\Documents\StoreDB.mdf;Integrated Security=True;Connect Timeout=30");
        public Shopform()
        {
            InitializeComponent();
        }
        private void populate()
        {
            Con.Open();
            String query = "select Productid,ProductName, ProductQty, Price from ProductTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProDGV1.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void ProDGV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProName.Text = ProDGV1.SelectedRows[0].Cells[1].Value.ToString();
            Productid.Text = ProDGV1.SelectedRows[0].Cells[0].Value.ToString();
            ProPrice.Text = ProDGV1.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void Shopform_Load(object sender, EventArgs e)
        {
            populate();
            SellerName.Text = Form1.SetValueForText1;
            fillcombo();
            timer1.Start();
            
            
          
        }

        private void Date_Click(object sender, EventArgs e)
        {
        }



        String dbproqty = "";

        int gridtotal  = 0;
        private void label1_Click(object sender, EventArgs e)
        {

            if (ProName.Text == "" || ProPrice.Text == ""||ProQty.Text == ""|| ProQty.Text == "0"||Convert.ToInt32(ProQty.Text)<1 )
            {
                
                 MessageBox.Show("Please select the Valid entries");
                
            }
            else
            {
                int remainingitems;
                SqlCommand command =
                   new SqlCommand("select ProductQty from ProductTable WHERE Productid= "+Productid.Text+"", Con);
                Con.Open();

                SqlDataReader read = command.ExecuteReader();

                read.Read();
                
                    dbproqty = (read["ProductQty"].ToString());
                    if (Convert.ToInt32(ProQty.Text) > Convert.ToInt32(dbproqty)) 
                    {
                        MessageBox.Show("Number of items are low so please enter valid quantity\n Current Quantity = "+ dbproqty+ "");
                        Con.Close();
                        
                    }
                    
                    else
                    {
                        Con.Close();
                        remainingitems = Convert.ToInt32(dbproqty)-Convert.ToInt32(ProQty.Text);
                        
                        String query = "update ProductTable set ProductQty='" + remainingitems + "'where Productid = " + Productid.Text + "";
                        SqlCommand cmd = new SqlCommand(query, Con);
                        Con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Category is Updated Successfully");
                        Con.Close();



                        DataGridViewRow newrow = new DataGridViewRow();
                        newrow.CreateCells(Orderdgv);
                        newrow.Cells[0].Value = Productid.Text;
                        newrow.Cells[1].Value = ProName.Text;
                        newrow.Cells[2].Value = ProPrice.Text;
                        newrow.Cells[3].Value = ProQty.Text;
                        newrow.Cells[4].Value = Convert.ToInt32(ProPrice.Text) * Convert.ToInt32(ProQty.Text);
                        int totalprice = Convert.ToInt32(ProPrice.Text) * Convert.ToInt32(ProQty.Text);
                        Orderdgv.Rows.Add(newrow);
                        gridtotal = gridtotal + totalprice;
                        TotalPrice.Text = gridtotal.ToString();
                        ProQty.Clear();
                        ProName.Clear();
                        ProPrice.Clear();
                        Productid.Clear();
                        populate();
                        

                    }
                
                read.Close();

            }
            
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void discount_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Orderdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ReceivedAmount_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

            int remin = int.Parse(ReceivedAmount.Text) - int.Parse(TotalPrice.Text);
           
        }

       
        private void backtomain_Click(object sender, EventArgs e)
        {
            Form1 pf = new Form1();
            pf.Show();
            this.Hide();
        }

        private void add_Click(object sender, EventArgs e)
        {

            //count rows
            //int rows =  Orderdgv.Rows.Count;
            //rows = rows - 1;

            //Count number of products from grid view
            int sum = 0;
            for (int i = 0; i < Orderdgv.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(Orderdgv.Rows[i].Cells[3].Value);
            }
            // MessageBox.Show(sum.ToString()) ;




                if (ReceivedAmount.Text == "") {
                ReceivedAmount.Text = TotalPrice.Text;
                
                }

                int remaining = Convert.ToInt32(ReceivedAmount.Text) - Convert.ToInt32(TotalPrice.Text);

                if (remaining < 0)
                {
                    MessageBox.Show("INVALID AMOUNT RECEIVED");

                }
                else
                {

                try
                {
                    DateTime dateTime = DateTime.Now;
                    Con.Open();
                    String query = "insert into billdb (items, amount, seller,date) values('" + sum.ToString() + "','" + TotalPrice.Text + "','" 
                        + Form1.SetValueForText1 + "','" + dateTime.ToShortDateString() + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                    }
                MessageBox.Show("Total Products = "  +sum.ToString() + "\n" +   "Total Bill = " + TotalPrice.Text + "\n" + "Amount Recieved= " + ReceivedAmount.Text + "\n" + "Change = " + remaining);
                //////////////////////////////////////////////////////////////////////////////////////////////////////////////
                ///?///////////////////////////
                //////////////////////////////////////////////////////////////////////////////////////////////////////////////
                //////////////////////////////////////////////////////////////////////////////////////////////////////////////
                ///?///////////////////////////
                //////////////////////////////////////////////////////////////////////////////////////////////////////////////
                //////////////////////////////////////////////////////////////////////////////////////////////////////////////
                ///?///////////////////////////
                //////////////////////////////////////////////////////////////////////////////////////////////////////////////
                int i = 0;
                //MessageBox.Show("Yahan se");
                    for (i = 0; i < Orderdgv.Rows.Count-1; i++)
                    {
                    if (i == 0)
                    {

                    }
                    else
                    {
                        try
                        {
                            Con.Open();
                            string StrQuery = "INSERT INTO solditems (pid, pname, pprice,pqty,total) VALUES ('" + Orderdgv.Rows[i].Cells[0].Value + "', '"
                            + Orderdgv.Rows[i].Cells[1].Value + "', '" + Orderdgv.Rows[i].Cells[2].Value + "', '" + Orderdgv.Rows[i].Cells[3].Value + "', '" + Orderdgv.Rows[i].Cells[4].Value + "')";
                            SqlCommand cmd = new SqlCommand(StrQuery, Con);
                            cmd.ExecuteNonQuery();
                            Con.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            Con.Close();
                        }
                    }
                    }

                //MessageBox.Show("Yahan tak");





















                Orderdgv.Rows.Clear();
                    ProQty.Clear();
                    ProName.Clear();
                    ProPrice.Clear();
                    TotalPrice.Clear();
                    ReceivedAmount.Clear();
                }




            }
        

        private void delete_Click(object sender, EventArgs e)
        {
            //Product quantity manage addition on delete of specific item from shop interface
            String id, qty; //Data from grid view
            id = Orderdgv.SelectedRows[0].Cells[0].Value.ToString();
            qty = Orderdgv.SelectedRows[0].Cells[3].Value.ToString();
            
            String items;
            SqlCommand command =
            new SqlCommand("select ProductQty from ProductTable WHERE Productid= " + id + "", Con);
            Con.Open();
            SqlDataReader read = command.ExecuteReader();
            read.Read();
            items = (read["ProductQty"].ToString()); 
            Con.Close();//Quantity read from database
            int total;
            total = Convert.ToInt32(items) + Convert.ToInt32(qty);

            items = items + Convert.ToInt32(qty);
            //items total deleted + remaining

            try
            {
                String query = "update ProductTable set ProductQty='" + total + "'where Productid = " + id + "";
                SqlCommand cmd = new SqlCommand(query, Con);
                Con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category is Updated Successfully");
                Con.Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            

            //orignal code

            int rowindex = Orderdgv.CurrentCell.RowIndex;
            
            Orderdgv.Rows.RemoveAt(rowindex);
        }

        private void SellerName_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }
        private void label9_Click(object sender, EventArgs e)
        {
           
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void edit_Click(object sender, EventArgs e)
        {
        }
        private void Productid_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        private void refresh_Click(object sender, EventArgs e)
        {
            //Orderdgv.Rows.Clear();
            String catergory = this.comboBox2.GetItemText(this.comboBox2.SelectedItem);
            //MessageBox.Show(catergory);

            try
            {
                Con.Open();
                String query = "select Productid,ProductName, ProductQty, Price from ProductTable where Productcategory = '" + catergory + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                ProDGV1.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        private void fillcombo()
        {
            //Fill the category
            Con.Open();
            String query = "select CatName from CategoryTable";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CatName", typeof(String));
            dt.Load(rdr);
            comboBox2.ValueMember = "CatName";
            comboBox2.DataSource = dt;
            Con.Close();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            //Orderdgv.Rows.Clear();
            String catergory = this.comboBox2.GetItemText(this.comboBox2.SelectedItem);
            //MessageBox.Show(catergory);
            Con.Open();
            String query = "select Productid,ProductName, ProductQty, Price from ProductTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProDGV1.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SendKeys.Send("{HOME}");
        }

        private void ProQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.Datelbl.Text = dateTime.ToString();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
