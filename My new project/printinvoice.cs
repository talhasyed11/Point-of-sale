﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_new_project.NewFolder1
{
    public partial class printinvoice : Form
    {
        public printinvoice()
        {
            InitializeComponent();
        }

        private void printinvoice_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
