using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace My_new_project
{
    public partial class Splash_Screen : Form
    {
        public Splash_Screen()
        {
            InitializeComponent();
            ProgressIndicator.BackColor = Color.FromArgb(159, 29, 52);
            timer1.Start();
            ProgressIndicator.Start();
        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();

        }

        private void Splash_Screen_Load(object sender, EventArgs e)
        {
           // timer1.Start();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void progressBar_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ProgressIndicator_Click(object sender, EventArgs e)
        {
            
        }
    }
}
