namespace TrenBiletRezervasyon
{
    partial class SatisListe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SatisListe));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboara = new System.Windows.Forms.ComboBox();
            this.textara = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSorgu = new System.Windows.Forms.Button();
            this.buttontemizle = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelucret = new System.Windows.Forms.Label();
            this.buttonGuncelle = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.Ucret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SatmaTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Indirim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KoltukNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vagon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrenSaati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BiletTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nereye = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nereden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cinsiyet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailAdresi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KimlikNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DogumTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TicketID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TicketID,
            this.Ad,
            this.Soyad,
            this.DogumTarihi,
            this.KimlikNo,
            this.TelNo,
            this.EmailAdresi,
            this.Cinsiyet,
            this.Nereden,
            this.Nereye,
            this.BiletTarihi,
            this.TrenSaati,
            this.Vagon,
            this.KoltukNo,
            this.Indirim,
            this.SatmaTarihi,
            this.Ucret});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1339, 365);
            this.dataGridView1.TabIndex = 52;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(215, 379);
            this.button2.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 52);
            this.button2.TabIndex = 2;
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(12, 379);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 52);
            this.button1.TabIndex = 1;
            this.button1.Text = "       SEÇİLENİ SİL";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(551, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 22);
            this.label1.TabIndex = 53;
            this.label1.Text = "Arama Türü:";
            // 
            // comboara
            // 
            this.comboara.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboara.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboara.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboara.FormattingEnabled = true;
            this.comboara.Items.AddRange(new object[] {
            "PNR Kodu",
            "Ad",
            "Email",
            "TelNo",
            "KimlikNo"});
            this.comboara.Location = new System.Drawing.Point(555, 402);
            this.comboara.Name = "comboara";
            this.comboara.Size = new System.Drawing.Size(146, 28);
            this.comboara.TabIndex = 5;
            this.comboara.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboara.SelectedValueChanged += new System.EventHandler(this.comboara_SelectedValueChanged);
            // 
            // textara
            // 
            this.textara.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textara.Location = new System.Drawing.Point(715, 404);
            this.textara.Name = "textara";
            this.textara.Size = new System.Drawing.Size(146, 26);
            this.textara.TabIndex = 6;
            this.textara.TextChanged += new System.EventHandler(this.textara_TextChanged);
            this.textara.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textara_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(711, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 22);
            this.label2.TabIndex = 56;
            this.label2.Text = "Arama Bilgisi:";
            // 
            // buttonSorgu
            // 
            this.buttonSorgu.BackColor = System.Drawing.Color.LightBlue;
            this.buttonSorgu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSorgu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSorgu.Image = ((System.Drawing.Image)(resources.GetObject("buttonSorgu.Image")));
            this.buttonSorgu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSorgu.Location = new System.Drawing.Point(309, 379);
            this.buttonSorgu.Name = "buttonSorgu";
            this.buttonSorgu.Size = new System.Drawing.Size(150, 52);
            this.buttonSorgu.TabIndex = 3;
            this.buttonSorgu.Text = "ARA     ";
            this.buttonSorgu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSorgu.UseVisualStyleBackColor = false;
            this.buttonSorgu.Click += new System.EventHandler(this.buttonSorgu_Click);
            // 
            // buttontemizle
            // 
            this.buttontemizle.BackColor = System.Drawing.Color.LightBlue;
            this.buttontemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttontemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttontemizle.ForeColor = System.Drawing.Color.Black;
            this.buttontemizle.Image = ((System.Drawing.Image)(resources.GetObject("buttontemizle.Image")));
            this.buttontemizle.Location = new System.Drawing.Point(470, 378);
            this.buttontemizle.Name = "buttontemizle";
            this.buttontemizle.Size = new System.Drawing.Size(67, 52);
            this.buttontemizle.TabIndex = 4;
            this.buttontemizle.UseVisualStyleBackColor = false;
            this.buttontemizle.Click += new System.EventHandler(this.buttontemizle_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(1092, 371);
            this.dateTimePicker1.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(156, 26);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged_2);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(890, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 24);
            this.label3.TabIndex = 61;
            this.label3.Text = "Tarih filtresi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(890, 406);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 24);
            this.label4.TabIndex = 62;
            this.label4.Text = "Toplam ücret:";
            // 
            // labelucret
            // 
            this.labelucret.AutoSize = true;
            this.labelucret.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelucret.ForeColor = System.Drawing.Color.Gold;
            this.labelucret.Location = new System.Drawing.Point(1086, 400);
            this.labelucret.Name = "labelucret";
            this.labelucret.Size = new System.Drawing.Size(30, 32);
            this.labelucret.TabIndex = 63;
            this.labelucret.Text = "0";
            this.labelucret.Click += new System.EventHandler(this.labelucret_Click);
            // 
            // buttonGuncelle
            // 
            this.buttonGuncelle.BackColor = System.Drawing.Color.LightBlue;
            this.buttonGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("buttonGuncelle.Image")));
            this.buttonGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGuncelle.Location = new System.Drawing.Point(1425, 449);
            this.buttonGuncelle.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.buttonGuncelle.Name = "buttonGuncelle";
            this.buttonGuncelle.Size = new System.Drawing.Size(191, 52);
            this.buttonGuncelle.TabIndex = 64;
            this.buttonGuncelle.Text = "GÜNCELLE";
            this.buttonGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonGuncelle.UseVisualStyleBackColor = false;
            this.buttonGuncelle.Visible = false;
            this.buttonGuncelle.Click += new System.EventHandler(this.buttonGuncelle_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.maskedTextBox1.Location = new System.Drawing.Point(715, 404);
            this.maskedTextBox1.Mask = "(999) 000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(146, 26);
            this.maskedTextBox1.TabIndex = 7;
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            this.maskedTextBox1.TextChanged += new System.EventHandler(this.maskedTextBox1_TextChanged);
            this.maskedTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBox1_KeyPress);
            // 
            // Ucret
            // 
            this.Ucret.DataPropertyName = "Ucret";
            this.Ucret.HeaderText = "Ucret";
            this.Ucret.Name = "Ucret";
            this.Ucret.ReadOnly = true;
            this.Ucret.Width = 55;
            // 
            // SatmaTarihi
            // 
            this.SatmaTarihi.DataPropertyName = "SatisTarihi";
            this.SatmaTarihi.HeaderText = "SatışTarihi";
            this.SatmaTarihi.Name = "SatmaTarihi";
            this.SatmaTarihi.ReadOnly = true;
            this.SatmaTarihi.Width = 90;
            // 
            // Indirim
            // 
            this.Indirim.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Indirim.DataPropertyName = "Indirim";
            this.Indirim.HeaderText = "İndirim";
            this.Indirim.Name = "Indirim";
            this.Indirim.ReadOnly = true;
            this.Indirim.Width = 81;
            // 
            // KoltukNo
            // 
            this.KoltukNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.KoltukNo.DataPropertyName = "KoltukNo";
            this.KoltukNo.HeaderText = "K.No";
            this.KoltukNo.Name = "KoltukNo";
            this.KoltukNo.ReadOnly = true;
            this.KoltukNo.Width = 68;
            // 
            // Vagon
            // 
            this.Vagon.DataPropertyName = "Vagon";
            this.Vagon.HeaderText = "Vagon";
            this.Vagon.Name = "Vagon";
            this.Vagon.ReadOnly = true;
            this.Vagon.Width = 85;
            // 
            // TrenSaati
            // 
            this.TrenSaati.DataPropertyName = "TrenSaati";
            this.TrenSaati.HeaderText = "Saat";
            this.TrenSaati.Name = "TrenSaati";
            this.TrenSaati.ReadOnly = true;
            this.TrenSaati.Width = 55;
            // 
            // BiletTarihi
            // 
            this.BiletTarihi.DataPropertyName = "BiletTarih";
            this.BiletTarihi.HeaderText = "BiletTarihi";
            this.BiletTarihi.Name = "BiletTarihi";
            this.BiletTarihi.ReadOnly = true;
            this.BiletTarihi.Width = 90;
            // 
            // Nereye
            // 
            this.Nereye.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Nereye.DataPropertyName = "Nereye";
            this.Nereye.HeaderText = "Nereye";
            this.Nereye.Name = "Nereye";
            this.Nereye.ReadOnly = true;
            this.Nereye.Width = 84;
            // 
            // Nereden
            // 
            this.Nereden.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Nereden.DataPropertyName = "Nereden";
            this.Nereden.HeaderText = "Nereden";
            this.Nereden.Name = "Nereden";
            this.Nereden.ReadOnly = true;
            this.Nereden.Width = 95;
            // 
            // Cinsiyet
            // 
            this.Cinsiyet.DataPropertyName = "Cinsiyet";
            this.Cinsiyet.HeaderText = "Cinsiyet";
            this.Cinsiyet.Name = "Cinsiyet";
            this.Cinsiyet.ReadOnly = true;
            this.Cinsiyet.Width = 70;
            // 
            // EmailAdresi
            // 
            this.EmailAdresi.DataPropertyName = "EmailAdresi";
            this.EmailAdresi.HeaderText = "EmailAdresi";
            this.EmailAdresi.Name = "EmailAdresi";
            this.EmailAdresi.ReadOnly = true;
            this.EmailAdresi.Width = 140;
            // 
            // TelNo
            // 
            this.TelNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TelNo.DataPropertyName = "TelNo";
            this.TelNo.HeaderText = "TelNo";
            this.TelNo.Name = "TelNo";
            this.TelNo.ReadOnly = true;
            this.TelNo.Width = 75;
            // 
            // KimlikNo
            // 
            this.KimlikNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.KimlikNo.DataPropertyName = "KimlikNo";
            this.KimlikNo.HeaderText = "KimlikNo";
            this.KimlikNo.Name = "KimlikNo";
            this.KimlikNo.ReadOnly = true;
            this.KimlikNo.Width = 94;
            // 
            // DogumTarihi
            // 
            this.DogumTarihi.DataPropertyName = "DogumTarih";
            this.DogumTarihi.HeaderText = "DogumTarihi";
            this.DogumTarihi.Name = "DogumTarihi";
            this.DogumTarihi.ReadOnly = true;
            this.DogumTarihi.Width = 105;
            // 
            // Soyad
            // 
            this.Soyad.DataPropertyName = "Soyad";
            this.Soyad.HeaderText = "Soyad";
            this.Soyad.Name = "Soyad";
            this.Soyad.ReadOnly = true;
            this.Soyad.Width = 120;
            // 
            // Ad
            // 
            this.Ad.DataPropertyName = "Ad";
            this.Ad.HeaderText = "Ad";
            this.Ad.Name = "Ad";
            this.Ad.ReadOnly = true;
            this.Ad.Width = 120;
            // 
            // TicketID
            // 
            this.TicketID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TicketID.DataPropertyName = "TicketID";
            this.TicketID.HeaderText = "PNR";
            this.TicketID.Name = "TicketID";
            this.TicketID.ReadOnly = true;
            this.TicketID.Width = 67;
            // 
            // SatisListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1339, 444);
            this.Controls.Add(this.buttonGuncelle);
            this.Controls.Add(this.labelucret);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.buttontemizle);
            this.Controls.Add(this.buttonSorgu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboara);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textara);
            this.Controls.Add(this.maskedTextBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SatisListe";
            this.Text = "Satış Liste";
            this.Load += new System.EventHandler(this.SatisListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboara;
        private System.Windows.Forms.TextBox textara;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttontemizle;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSorgu;
        private System.Windows.Forms.Label labelucret;
        private System.Windows.Forms.Button buttonGuncelle;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TicketID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn DogumTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn KimlikNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailAdresi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cinsiyet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nereden;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nereye;
        private System.Windows.Forms.DataGridViewTextBoxColumn BiletTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrenSaati;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vagon;
        private System.Windows.Forms.DataGridViewTextBoxColumn KoltukNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Indirim;
        private System.Windows.Forms.DataGridViewTextBoxColumn SatmaTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ucret;
    }
}