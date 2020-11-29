
namespace My_new_project
{
    partial class Shopform
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            this.backtomain = new System.Windows.Forms.Label();
            this.Orderdgv = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refresh = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.delete = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Productid = new System.Windows.Forms.MaskedTextBox();
            this.SellerName = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ReceivedAmount = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TotalPrice = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Datelbl = new System.Windows.Forms.Label();
            this.ProDGV1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ProPrice = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ProName = new System.Windows.Forms.MaskedTextBox();
            this.ProQty = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Orderdgv)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProDGV1)).BeginInit();
            this.SuspendLayout();
            // 
            // backtomain
            // 
            this.backtomain.AutoSize = true;
            this.backtomain.BackColor = System.Drawing.Color.White;
            this.backtomain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.backtomain.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backtomain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.backtomain.Location = new System.Drawing.Point(14, 7);
            this.backtomain.Name = "backtomain";
            this.backtomain.Size = new System.Drawing.Size(74, 25);
            this.backtomain.TabIndex = 35;
            this.backtomain.Text = "Logout\r\n";
            this.backtomain.Click += new System.EventHandler(this.backtomain_Click);
            // 
            // Orderdgv
            // 
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.White;
            this.Orderdgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
            this.Orderdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Orderdgv.BackgroundColor = System.Drawing.Color.White;
            this.Orderdgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Orderdgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Orderdgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Orderdgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.Orderdgv.ColumnHeadersHeight = 25;
            this.Orderdgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.PName,
            this.Price,
            this.Qty,
            this.Total});
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Orderdgv.DefaultCellStyle = dataGridViewCellStyle27;
            this.Orderdgv.EnableHeadersVisualStyles = false;
            this.Orderdgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Orderdgv.Location = new System.Drawing.Point(364, 48);
            this.Orderdgv.Name = "Orderdgv";
            this.Orderdgv.RowHeadersVisible = false;
            this.Orderdgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Orderdgv.Size = new System.Drawing.Size(566, 372);
            this.Orderdgv.TabIndex = 22;
            this.Orderdgv.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.Orderdgv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.Orderdgv.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.Orderdgv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.Orderdgv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.Orderdgv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.Orderdgv.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.Orderdgv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Orderdgv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DarkRed;
            this.Orderdgv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Orderdgv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.Orderdgv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.Orderdgv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.Orderdgv.ThemeStyle.HeaderStyle.Height = 25;
            this.Orderdgv.ThemeStyle.ReadOnly = false;
            this.Orderdgv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.Orderdgv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Orderdgv.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.Orderdgv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.Orderdgv.ThemeStyle.RowsStyle.Height = 22;
            this.Orderdgv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Orderdgv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.Orderdgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Orderdgv_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "Productid";
            this.ID.Name = "ID";
            // 
            // PName
            // 
            this.PName.HeaderText = "ProName";
            this.PName.Name = "PName";
            // 
            // Price
            // 
            this.Price.HeaderText = "ProPrice";
            this.Price.Name = "Price";
            // 
            // Qty
            // 
            this.Qty.HeaderText = "ProQty";
            this.Qty.Name = "Qty";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // refresh
            // 
            this.refresh.AutoSize = true;
            this.refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.refresh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.refresh.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh.ForeColor = System.Drawing.Color.White;
            this.refresh.Location = new System.Drawing.Point(254, 196);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(65, 21);
            this.refresh.TabIndex = 21;
            this.refresh.Text = "Refresh";
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.comboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.comboBox2.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.ForeColor = System.Drawing.Color.White;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(70, 194);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(175, 24);
            this.comboBox2.TabIndex = 20;
            this.comboBox2.Text = "SELECT CATEGORY";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // delete
            // 
            this.delete.AutoSize = true;
            this.delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.delete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.delete.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.Color.White;
            this.delete.Location = new System.Drawing.Point(859, 507);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(71, 25);
            this.delete.TabIndex = 18;
            this.delete.Text = "DELETE";
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // add
            // 
            this.add.AutoSize = true;
            this.add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.add.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.add.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.ForeColor = System.Drawing.Color.White;
            this.add.Location = new System.Drawing.Point(878, 474);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(52, 25);
            this.add.TabIndex = 16;
            this.add.Text = "ADD";
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.Productid);
            this.panel1.Controls.Add(this.SellerName);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.ReceivedAmount);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.TotalPrice);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Datelbl);
            this.panel1.Controls.Add(this.ProDGV1);
            this.panel1.Controls.Add(this.backtomain);
            this.panel1.Controls.Add(this.Orderdgv);
            this.panel1.Controls.Add(this.refresh);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.delete);
            this.panel1.Controls.Add(this.add);
            this.panel1.Controls.Add(this.ProPrice);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.ProName);
            this.panel1.Controls.Add(this.ProQty);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(946, 551);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(19, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 21);
            this.label3.TabIndex = 54;
            this.label3.Text = "ALL";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(13, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 19);
            this.label10.TabIndex = 53;
            this.label10.Text = "Product ID";
            // 
            // Productid
            // 
            this.Productid.BackColor = System.Drawing.Color.White;
            this.Productid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Productid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Productid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Productid.Location = new System.Drawing.Point(137, 48);
            this.Productid.Name = "Productid";
            this.Productid.ReadOnly = true;
            this.Productid.Size = new System.Drawing.Size(190, 23);
            this.Productid.TabIndex = 52;
            this.Productid.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Productid_MaskInputRejected);
            // 
            // SellerName
            // 
            this.SellerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.SellerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SellerName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellerName.ForeColor = System.Drawing.Color.White;
            this.SellerName.Location = new System.Drawing.Point(474, 431);
            this.SellerName.Name = "SellerName";
            this.SellerName.Size = new System.Drawing.Size(127, 20);
            this.SellerName.TabIndex = 51;
            this.SellerName.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.SellerName_MaskInputRejected);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(360, 431);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 19);
            this.label9.TabIndex = 50;
            this.label9.Text = "Seller Name :   ";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // ReceivedAmount
            // 
            this.ReceivedAmount.BackColor = System.Drawing.Color.White;
            this.ReceivedAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReceivedAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReceivedAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ReceivedAmount.Location = new System.Drawing.Point(839, 452);
            this.ReceivedAmount.Name = "ReceivedAmount";
            this.ReceivedAmount.Size = new System.Drawing.Size(91, 19);
            this.ReceivedAmount.TabIndex = 49;
            this.ReceivedAmount.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.ReceivedAmount_MaskInputRejected);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label8.CausesValidation = false;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(728, 450);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 23);
            this.label8.TabIndex = 48;
            this.label8.Text = "Received";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(728, 427);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 23);
            this.label6.TabIndex = 47;
            this.label6.Text = "Amount";
            // 
            // TotalPrice
            // 
            this.TotalPrice.BackColor = System.Drawing.Color.White;
            this.TotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.TotalPrice.Location = new System.Drawing.Point(839, 427);
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Size = new System.Drawing.Size(91, 19);
            this.TotalPrice.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(104, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 39;
            this.label1.Text = "Add Product";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Datelbl
            // 
            this.Datelbl.AutoSize = true;
            this.Datelbl.BackColor = System.Drawing.Color.Transparent;
            this.Datelbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datelbl.ForeColor = System.Drawing.Color.White;
            this.Datelbl.Location = new System.Drawing.Point(711, 8);
            this.Datelbl.Name = "Datelbl";
            this.Datelbl.Size = new System.Drawing.Size(54, 23);
            this.Datelbl.TabIndex = 38;
            this.Datelbl.Text = "Date";
            this.Datelbl.Click += new System.EventHandler(this.Date_Click);
            // 
            // ProDGV1
            // 
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.White;
            this.ProDGV1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle28;
            this.ProDGV1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProDGV1.BackgroundColor = System.Drawing.Color.White;
            this.ProDGV1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProDGV1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ProDGV1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProDGV1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.ProDGV1.ColumnHeadersHeight = 25;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProDGV1.DefaultCellStyle = dataGridViewCellStyle30;
            this.ProDGV1.EnableHeadersVisualStyles = false;
            this.ProDGV1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ProDGV1.Location = new System.Drawing.Point(17, 224);
            this.ProDGV1.Name = "ProDGV1";
            this.ProDGV1.ReadOnly = true;
            this.ProDGV1.RowHeadersVisible = false;
            this.ProDGV1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProDGV1.Size = new System.Drawing.Size(310, 322);
            this.ProDGV1.TabIndex = 37;
            this.ProDGV1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.ProDGV1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ProDGV1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ProDGV1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ProDGV1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ProDGV1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ProDGV1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ProDGV1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ProDGV1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DarkRed;
            this.ProDGV1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ProDGV1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ProDGV1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ProDGV1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ProDGV1.ThemeStyle.HeaderStyle.Height = 25;
            this.ProDGV1.ThemeStyle.ReadOnly = true;
            this.ProDGV1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ProDGV1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ProDGV1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ProDGV1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ProDGV1.ThemeStyle.RowsStyle.Height = 22;
            this.ProDGV1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProDGV1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ProDGV1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProDGV1_CellContentClick);
            // 
            // ProPrice
            // 
            this.ProPrice.BackColor = System.Drawing.Color.White;
            this.ProPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ProPrice.Location = new System.Drawing.Point(137, 106);
            this.ProPrice.Name = "ProPrice";
            this.ProPrice.ReadOnly = true;
            this.ProPrice.Size = new System.Drawing.Size(190, 23);
            this.ProPrice.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(13, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "Quantity";
            // 
            // ProName
            // 
            this.ProName.BackColor = System.Drawing.Color.White;
            this.ProName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ProName.Location = new System.Drawing.Point(137, 76);
            this.ProName.Name = "ProName";
            this.ProName.ReadOnly = true;
            this.ProName.Size = new System.Drawing.Size(190, 23);
            this.ProName.TabIndex = 13;
            // 
            // ProQty
            // 
            this.ProQty.BackColor = System.Drawing.Color.White;
            this.ProQty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ProQty.Location = new System.Drawing.Point(137, 136);
            this.ProQty.Name = "ProQty";
            this.ProQty.Size = new System.Drawing.Size(190, 23);
            this.ProQty.TabIndex = 12;
            this.ProQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProQty_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(13, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Product Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(400, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Zaffiro Billing";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label11.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(912, 2);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 26);
            this.label11.TabIndex = 55;
            this.label11.Text = "X";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // Shopform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 551);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Shopform";
            this.Text = "Shopform";
            this.Load += new System.EventHandler(this.Shopform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Orderdgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProDGV1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label backtomain;
        private Guna.UI2.WinForms.Guna2DataGridView Orderdgv;
        private System.Windows.Forms.Label refresh;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label delete;
        private System.Windows.Forms.Label add;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Datelbl;
        private Guna.UI2.WinForms.Guna2DataGridView ProDGV1;
        private System.Windows.Forms.MaskedTextBox ProPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox ProName;
        private System.Windows.Forms.MaskedTextBox ProQty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox TotalPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox ReceivedAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox SellerName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox Productid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label11;
    }
}