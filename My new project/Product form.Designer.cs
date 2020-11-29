
namespace My_new_project
{
    partial class Product_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.categorycombo = new System.Windows.Forms.ComboBox();
            this.ProID = new System.Windows.Forms.MaskedTextBox();
            this.ProQty = new System.Windows.Forms.MaskedTextBox();
            this.ProName = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ProPrice = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.categorycombo2 = new System.Windows.Forms.ComboBox();
            this.logout = new System.Windows.Forms.Label();
            this.backtomain = new System.Windows.Forms.Label();
            this.ProDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.refresh = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Label();
            this.edit = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(389, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Manage Product";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(28, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "ID";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(28, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(28, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Quantity";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(28, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 23);
            this.label6.TabIndex = 9;
            this.label6.Text = "Category";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // categorycombo
            // 
            this.categorycombo.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.categorycombo.AllowDrop = true;
            this.categorycombo.Cursor = System.Windows.Forms.Cursors.Default;
            this.categorycombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categorycombo.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorycombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.categorycombo.FormattingEnabled = true;
            this.categorycombo.Items.AddRange(new object[] {
            "Shawls",
            "Suits",
            "Trousers"});
            this.categorycombo.Location = new System.Drawing.Point(161, 218);
            this.categorycombo.Name = "categorycombo";
            this.categorycombo.Size = new System.Drawing.Size(190, 24);
            this.categorycombo.TabIndex = 10;
            this.categorycombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ProID
            // 
            this.ProID.BackColor = System.Drawing.Color.White;
            this.ProID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProID.Enabled = false;
            this.ProID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ProID.Location = new System.Drawing.Point(161, 81);
            this.ProID.Name = "ProID";
            this.ProID.ReadOnly = true;
            this.ProID.Size = new System.Drawing.Size(190, 23);
            this.ProID.TabIndex = 11;
            this.ProID.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.ProID_MaskInputRejected);
            this.ProID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProID_KeyPress);
            // 
            // ProQty
            // 
            this.ProQty.BackColor = System.Drawing.Color.White;
            this.ProQty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ProQty.Location = new System.Drawing.Point(161, 170);
            this.ProQty.Name = "ProQty";
            this.ProQty.Size = new System.Drawing.Size(190, 23);
            this.ProQty.TabIndex = 12;
            this.ProQty.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.ProQty_MaskInputRejected);
            this.ProQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProQty_KeyPress);
            // 
            // ProName
            // 
            this.ProName.BackColor = System.Drawing.Color.White;
            this.ProName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ProName.Location = new System.Drawing.Point(161, 124);
            this.ProName.Name = "ProName";
            this.ProName.Size = new System.Drawing.Size(190, 23);
            this.ProName.TabIndex = 13;
            this.ProName.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.ProName_MaskInputRejected);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(28, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = "Price";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // ProPrice
            // 
            this.ProPrice.BackColor = System.Drawing.Color.White;
            this.ProPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ProPrice.Location = new System.Drawing.Point(161, 263);
            this.ProPrice.Name = "ProPrice";
            this.ProPrice.Size = new System.Drawing.Size(190, 23);
            this.ProPrice.TabIndex = 15;
            this.ProPrice.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.ProPrice_MaskInputRejected);
            this.ProPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProPrice_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.categorycombo2);
            this.panel1.Controls.Add(this.logout);
            this.panel1.Controls.Add(this.backtomain);
            this.panel1.Controls.Add(this.ProDGV);
            this.panel1.Controls.Add(this.refresh);
            this.panel1.Controls.Add(this.delete);
            this.panel1.Controls.Add(this.edit);
            this.panel1.Controls.Add(this.add);
            this.panel1.Controls.Add(this.ProPrice);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.ProName);
            this.panel1.Controls.Add(this.ProQty);
            this.panel1.Controls.Add(this.ProID);
            this.panel1.Controls.Add(this.categorycombo);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(943, 551);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(137, 381);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 25);
            this.label11.TabIndex = 39;
            this.label11.Text = "Clear";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(367, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 38;
            this.label1.Text = "All Products";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // categorycombo2
            // 
            this.categorycombo2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.categorycombo2.Cursor = System.Windows.Forms.Cursors.Default;
            this.categorycombo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categorycombo2.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorycombo2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.categorycombo2.FormattingEnabled = true;
            this.categorycombo2.Items.AddRange(new object[] {
            "Shawls",
            "Suits",
            "Trousers"});
            this.categorycombo2.Location = new System.Drawing.Point(538, 50);
            this.categorycombo2.Name = "categorycombo2";
            this.categorycombo2.Size = new System.Drawing.Size(177, 24);
            this.categorycombo2.TabIndex = 37;
            this.categorycombo2.SelectedIndexChanged += new System.EventHandler(this.categorycombo2_SelectedIndexChanged);
            // 
            // logout
            // 
            this.logout.AutoSize = true;
            this.logout.BackColor = System.Drawing.Color.White;
            this.logout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logout.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.logout.Location = new System.Drawing.Point(14, 505);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(74, 25);
            this.logout.TabIndex = 36;
            this.logout.Text = "Logout";
            this.logout.Click += new System.EventHandler(this.label12_Click_1);
            // 
            // backtomain
            // 
            this.backtomain.AutoSize = true;
            this.backtomain.BackColor = System.Drawing.Color.White;
            this.backtomain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.backtomain.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backtomain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.backtomain.Location = new System.Drawing.Point(11, 7);
            this.backtomain.Name = "backtomain";
            this.backtomain.Size = new System.Drawing.Size(189, 25);
            this.backtomain.TabIndex = 35;
            this.backtomain.Text = "Back to Main Menu";
            this.backtomain.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // ProDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.ProDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ProDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProDGV.BackgroundColor = System.Drawing.Color.White;
            this.ProDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ProDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ProDGV.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.ProDGV.EnableHeadersVisualStyles = false;
            this.ProDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ProDGV.Location = new System.Drawing.Point(367, 77);
            this.ProDGV.Name = "ProDGV";
            this.ProDGV.ReadOnly = true;
            this.ProDGV.RowHeadersVisible = false;
            this.ProDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProDGV.Size = new System.Drawing.Size(566, 450);
            this.ProDGV.TabIndex = 22;
            this.ProDGV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.ProDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ProDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ProDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ProDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ProDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ProDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ProDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ProDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DarkRed;
            this.ProDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ProDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ProDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ProDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ProDGV.ThemeStyle.HeaderStyle.Height = 25;
            this.ProDGV.ThemeStyle.ReadOnly = true;
            this.ProDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ProDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ProDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ProDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ProDGV.ThemeStyle.RowsStyle.Height = 22;
            this.ProDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ProDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProDGV_CellContentClick);
            // 
            // refresh
            // 
            this.refresh.AutoSize = true;
            this.refresh.BackColor = System.Drawing.Color.White;
            this.refresh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.refresh.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.refresh.Location = new System.Drawing.Point(721, 50);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(77, 25);
            this.refresh.TabIndex = 21;
            this.refresh.Text = "Refresh";
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // delete
            // 
            this.delete.AutoSize = true;
            this.delete.BackColor = System.Drawing.Color.White;
            this.delete.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.delete.Location = new System.Drawing.Point(248, 326);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(69, 23);
            this.delete.TabIndex = 18;
            this.delete.Text = "DELETE";
            this.delete.Click += new System.EventHandler(this.label10_Click);
            // 
            // edit
            // 
            this.edit.AutoSize = true;
            this.edit.BackColor = System.Drawing.Color.White;
            this.edit.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.edit.Location = new System.Drawing.Point(151, 326);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(46, 23);
            this.edit.TabIndex = 17;
            this.edit.Text = "EDIT";
            this.edit.Click += new System.EventHandler(this.label9_Click);
            // 
            // add
            // 
            this.add.AutoSize = true;
            this.add.BackColor = System.Drawing.Color.White;
            this.add.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.add.Location = new System.Drawing.Point(45, 326);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(50, 23);
            this.add.TabIndex = 16;
            this.add.Text = "ADD";
            this.add.Click += new System.EventHandler(this.label8_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label8.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(914, -1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 30);
            this.label8.TabIndex = 40;
            this.label8.Text = "X";
            this.label8.Click += new System.EventHandler(this.label8_Click_1);
            // 
            // Product_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(937, 551);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Product_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product_form";
            this.Load += new System.EventHandler(this.Product_form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox categorycombo;
        private System.Windows.Forms.MaskedTextBox ProID;
        private System.Windows.Forms.MaskedTextBox ProQty;
        private System.Windows.Forms.MaskedTextBox ProName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox ProPrice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label delete;
        private System.Windows.Forms.Label edit;
        private System.Windows.Forms.Label add;
        private System.Windows.Forms.Label refresh;
        private Guna.UI2.WinForms.Guna2DataGridView ProDGV;
        private System.Windows.Forms.Label backtomain;
        private System.Windows.Forms.Label logout;
        private System.Windows.Forms.ComboBox categorycombo2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
    }
}