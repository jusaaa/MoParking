namespace Mo_Parking
{
    partial class frmAutomobili
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lblParking = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtTablice = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.lblTablice = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.txtTipVozila = new System.Windows.Forms.TextBox();
            this.lblTipVozila = new System.Windows.Forms.Label();
            this.txtBojaVozila = new System.Windows.Forms.TextBox();
            this.lblBoja = new System.Windows.Forms.Label();
            this.dgvVozila = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDodajVozilo = new Guna.UI2.WinForms.Guna2Button();
            this.btnUrediVozilo = new Guna.UI2.WinForms.Guna2Button();
            this.btnUkloniVozilo = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVozila)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.lblParking);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(96, 779);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Mo_Parking.Properties.Resources.logout;
            this.pictureBox6.Location = new System.Drawing.Point(24, 715);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(48, 39);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 7;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ubuntu", 10F);
            this.label2.Location = new System.Drawing.Point(12, 529);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Lokacije";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Mo_Parking.Properties.Resources.parking_area;
            this.pictureBox5.Location = new System.Drawing.Point(12, 460);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(68, 66);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // lblParking
            // 
            this.lblParking.AutoSize = true;
            this.lblParking.Font = new System.Drawing.Font("Ubuntu", 10F);
            this.lblParking.Location = new System.Drawing.Point(12, 410);
            this.lblParking.Name = "lblParking";
            this.lblParking.Size = new System.Drawing.Size(68, 21);
            this.lblParking.TabIndex = 4;
            this.lblParking.Text = "Parking";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Mo_Parking.Properties.Resources.parking__1_;
            this.pictureBox4.Location = new System.Drawing.Point(12, 341);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(68, 66);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ubuntu", 10F);
            this.label1.Location = new System.Drawing.Point(20, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vozila";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Mo_Parking.Properties.Resources.parked_car;
            this.pictureBox3.Location = new System.Drawing.Point(12, 224);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(68, 66);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Mo_Parking.Properties.Resources.cropped_cropped_Mo_Parking_HiDef_logo_300x300;
            this.pictureBox1.Location = new System.Drawing.Point(12, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1168, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 779);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Mo_Parking.Properties.Resources.icons8_close_50;
            this.pictureBox2.Location = new System.Drawing.Point(156, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // txtTablice
            // 
            this.txtTablice.Location = new System.Drawing.Point(153, 124);
            this.txtTablice.Multiline = true;
            this.txtTablice.Name = "txtTablice";
            this.txtTablice.Size = new System.Drawing.Size(242, 39);
            this.txtTablice.TabIndex = 3;
            this.txtTablice.TabStop = false;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(443, 124);
            this.txtIme.Multiline = true;
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(161, 39);
            this.txtIme.TabIndex = 4;
            this.txtIme.TabStop = false;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(678, 124);
            this.txtPrezime.Multiline = true;
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(162, 39);
            this.txtPrezime.TabIndex = 5;
            this.txtPrezime.TabStop = false;
            // 
            // lblTablice
            // 
            this.lblTablice.AutoSize = true;
            this.lblTablice.Font = new System.Drawing.Font("Ubuntu", 10F);
            this.lblTablice.Location = new System.Drawing.Point(148, 96);
            this.lblTablice.Name = "lblTablice";
            this.lblTablice.Size = new System.Drawing.Size(100, 21);
            this.lblTablice.TabIndex = 6;
            this.lblTablice.Text = "Broj tablica:";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Ubuntu", 10F);
            this.lblIme.Location = new System.Drawing.Point(439, 96);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(44, 21);
            this.lblIme.TabIndex = 7;
            this.lblIme.Text = "Ime:";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Font = new System.Drawing.Font("Ubuntu", 10F);
            this.lblPrezime.Location = new System.Drawing.Point(674, 100);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(77, 21);
            this.lblPrezime.TabIndex = 8;
            this.lblPrezime.Text = "Prezime:";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(881, 124);
            this.txtTelefon.Multiline = true;
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(242, 39);
            this.txtTelefon.TabIndex = 9;
            this.txtTelefon.TabStop = false;
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Font = new System.Drawing.Font("Ubuntu", 10F);
            this.lblTelefon.Location = new System.Drawing.Point(877, 100);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(73, 21);
            this.lblTelefon.TabIndex = 10;
            this.lblTelefon.Text = "Telefon:";
            // 
            // txtTipVozila
            // 
            this.txtTipVozila.Location = new System.Drawing.Point(310, 207);
            this.txtTipVozila.Multiline = true;
            this.txtTipVozila.Name = "txtTipVozila";
            this.txtTipVozila.Size = new System.Drawing.Size(243, 39);
            this.txtTipVozila.TabIndex = 11;
            this.txtTipVozila.TabStop = false;
            // 
            // lblTipVozila
            // 
            this.lblTipVozila.AutoSize = true;
            this.lblTipVozila.Font = new System.Drawing.Font("Ubuntu", 10F);
            this.lblTipVozila.Location = new System.Drawing.Point(306, 183);
            this.lblTipVozila.Name = "lblTipVozila";
            this.lblTipVozila.Size = new System.Drawing.Size(83, 21);
            this.lblTipVozila.TabIndex = 12;
            this.lblTipVozila.Text = "Tip vozila:";
            // 
            // txtBojaVozila
            // 
            this.txtBojaVozila.Location = new System.Drawing.Point(740, 207);
            this.txtBojaVozila.Multiline = true;
            this.txtBojaVozila.Name = "txtBojaVozila";
            this.txtBojaVozila.Size = new System.Drawing.Size(243, 39);
            this.txtBojaVozila.TabIndex = 13;
            this.txtBojaVozila.TabStop = false;
            // 
            // lblBoja
            // 
            this.lblBoja.AutoSize = true;
            this.lblBoja.Font = new System.Drawing.Font("Ubuntu", 10F);
            this.lblBoja.Location = new System.Drawing.Point(736, 183);
            this.lblBoja.Name = "lblBoja";
            this.lblBoja.Size = new System.Drawing.Size(94, 21);
            this.lblBoja.TabIndex = 14;
            this.lblBoja.Text = "Boja vozila:";
            // 
            // dgvVozila
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.dgvVozila.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvVozila.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(147)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVozila.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvVozila.ColumnHeadersHeight = 32;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVozila.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvVozila.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvVozila.Location = new System.Drawing.Point(102, 344);
            this.dgvVozila.Name = "dgvVozila";
            this.dgvVozila.ReadOnly = true;
            this.dgvVozila.RowHeadersVisible = false;
            this.dgvVozila.RowHeadersWidth = 51;
            this.dgvVozila.RowTemplate.Height = 28;
            this.dgvVozila.Size = new System.Drawing.Size(1060, 423);
            this.dgvVozila.TabIndex = 19;
            this.dgvVozila.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvVozila.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvVozila.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvVozila.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvVozila.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvVozila.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvVozila.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvVozila.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(147)))), ((int)(((byte)(227)))));
            this.dgvVozila.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvVozila.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvVozila.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvVozila.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvVozila.ThemeStyle.HeaderStyle.Height = 32;
            this.dgvVozila.ThemeStyle.ReadOnly = true;
            this.dgvVozila.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvVozila.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvVozila.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvVozila.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvVozila.ThemeStyle.RowsStyle.Height = 28;
            this.dgvVozila.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvVozila.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvVozila.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVozila_CellContentClick_1);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 15;
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(147)))), ((int)(((byte)(227)))));
            this.guna2Panel1.Location = new System.Drawing.Point(152, 39);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(966, 31);
            this.guna2Panel1.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(147)))), ((int)(((byte)(227)))));
            this.label3.Font = new System.Drawing.Font("Ubuntu", 10F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(304, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mo parking management system v1.0";
            // 
            // btnDodajVozilo
            // 
            this.btnDodajVozilo.BackColor = System.Drawing.Color.Transparent;
            this.btnDodajVozilo.BorderRadius = 10;
            this.btnDodajVozilo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDodajVozilo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDodajVozilo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDodajVozilo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDodajVozilo.FillColor = System.Drawing.Color.Green;
            this.btnDodajVozilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnDodajVozilo.ForeColor = System.Drawing.Color.White;
            this.btnDodajVozilo.Location = new System.Drawing.Point(357, 276);
            this.btnDodajVozilo.Name = "btnDodajVozilo";
            this.btnDodajVozilo.Size = new System.Drawing.Size(126, 38);
            this.btnDodajVozilo.TabIndex = 43;
            this.btnDodajVozilo.Text = "Dodaj";
            this.btnDodajVozilo.Click += new System.EventHandler(this.btnDodajVozilo_Click_1);
            // 
            // btnUrediVozilo
            // 
            this.btnUrediVozilo.BackColor = System.Drawing.Color.Transparent;
            this.btnUrediVozilo.BorderRadius = 10;
            this.btnUrediVozilo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUrediVozilo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUrediVozilo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUrediVozilo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUrediVozilo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnUrediVozilo.Font = new System.Drawing.Font("Ubuntu", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUrediVozilo.ForeColor = System.Drawing.Color.White;
            this.btnUrediVozilo.Location = new System.Drawing.Point(802, 276);
            this.btnUrediVozilo.Name = "btnUrediVozilo";
            this.btnUrediVozilo.Size = new System.Drawing.Size(126, 38);
            this.btnUrediVozilo.TabIndex = 42;
            this.btnUrediVozilo.Text = "Uredi";
            this.btnUrediVozilo.Click += new System.EventHandler(this.btnUrediVozilo_Click_1);
            // 
            // btnUkloniVozilo
            // 
            this.btnUkloniVozilo.BackColor = System.Drawing.Color.Transparent;
            this.btnUkloniVozilo.BorderRadius = 10;
            this.btnUkloniVozilo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUkloniVozilo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUkloniVozilo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUkloniVozilo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUkloniVozilo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnUkloniVozilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnUkloniVozilo.ForeColor = System.Drawing.Color.White;
            this.btnUkloniVozilo.Location = new System.Drawing.Point(584, 276);
            this.btnUkloniVozilo.Name = "btnUkloniVozilo";
            this.btnUkloniVozilo.Size = new System.Drawing.Size(126, 38);
            this.btnUkloniVozilo.TabIndex = 41;
            this.btnUkloniVozilo.Text = "Ukloni";
            this.btnUkloniVozilo.Click += new System.EventHandler(this.btnUkloniVozilo_Click_1);
            // 
            // frmAutomobili
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1368, 779);
            this.Controls.Add(this.btnDodajVozilo);
            this.Controls.Add(this.btnUrediVozilo);
            this.Controls.Add(this.btnUkloniVozilo);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.dgvVozila);
            this.Controls.Add(this.lblBoja);
            this.Controls.Add(this.txtBojaVozila);
            this.Controls.Add(this.lblTipVozila);
            this.Controls.Add(this.txtTipVozila);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.lblTablice);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.txtTablice);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAutomobili";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Automobili";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVozila)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtTablice;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label lblTablice;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.TextBox txtTipVozila;
        private System.Windows.Forms.Label lblTipVozila;
        private System.Windows.Forms.TextBox txtBojaVozila;
        private System.Windows.Forms.Label lblBoja;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblParking;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvVozila;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnDodajVozilo;
        private Guna.UI2.WinForms.Guna2Button btnUrediVozilo;
        private Guna.UI2.WinForms.Guna2Button btnUkloniVozilo;
    }
}