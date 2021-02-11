namespace TrenBiletRezervasyon
{
    partial class Biletİptal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Biletİptal));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.TicketID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DogumTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KimlikNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailAdresi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cinsiyet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nereden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nereye = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BiletTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrenSaati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vagon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KoltukNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Indirim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SatmaTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ucret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Satın Aldığınız Biletler";
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(828, 236);
            this.dataGridView1.TabIndex = 53;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(496, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(344, 48);
            this.button1.TabIndex = 54;
            this.button1.Text = "SEÇİLİ BİLETİ İPTAL ET ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // Ad
            // 
            this.Ad.DataPropertyName = "Ad";
            this.Ad.HeaderText = "Ad";
            this.Ad.Name = "Ad";
            this.Ad.ReadOnly = true;
            this.Ad.Width = 120;
            // 
            // Soyad
            // 
            this.Soyad.DataPropertyName = "Soyad";
            this.Soyad.HeaderText = "Soyad";
            this.Soyad.Name = "Soyad";
            this.Soyad.ReadOnly = true;
            this.Soyad.Width = 120;
            // 
            // DogumTarihi
            // 
            this.DogumTarihi.DataPropertyName = "DogumTarih";
            this.DogumTarihi.HeaderText = "DogumTarihi";
            this.DogumTarihi.Name = "DogumTarihi";
            this.DogumTarihi.ReadOnly = true;
            this.DogumTarihi.Width = 105;
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
            // TelNo
            // 
            this.TelNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TelNo.DataPropertyName = "TelNo";
            this.TelNo.HeaderText = "TelNo";
            this.TelNo.Name = "TelNo";
            this.TelNo.ReadOnly = true;
            this.TelNo.Width = 75;
            // 
            // EmailAdresi
            // 
            this.EmailAdresi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EmailAdresi.DataPropertyName = "EmailAdresi";
            this.EmailAdresi.HeaderText = "EmailAdresi";
            this.EmailAdresi.Name = "EmailAdresi";
            this.EmailAdresi.ReadOnly = true;
            this.EmailAdresi.Width = 118;
            // 
            // Cinsiyet
            // 
            this.Cinsiyet.DataPropertyName = "Cinsiyet";
            this.Cinsiyet.HeaderText = "Cinsiyet";
            this.Cinsiyet.Name = "Cinsiyet";
            this.Cinsiyet.ReadOnly = true;
            this.Cinsiyet.Width = 70;
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
            // Nereye
            // 
            this.Nereye.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Nereye.DataPropertyName = "Nereye";
            this.Nereye.HeaderText = "Nereye";
            this.Nereye.Name = "Nereye";
            this.Nereye.ReadOnly = true;
            this.Nereye.Width = 84;
            // 
            // BiletTarihi
            // 
            this.BiletTarihi.DataPropertyName = "BiletTarih";
            this.BiletTarihi.HeaderText = "BiletTarihi";
            this.BiletTarihi.Name = "BiletTarihi";
            this.BiletTarihi.ReadOnly = true;
            this.BiletTarihi.Width = 90;
            // 
            // TrenSaati
            // 
            this.TrenSaati.DataPropertyName = "TrenSaati";
            this.TrenSaati.HeaderText = "Saat";
            this.TrenSaati.Name = "TrenSaati";
            this.TrenSaati.ReadOnly = true;
            this.TrenSaati.Width = 55;
            // 
            // Vagon
            // 
            this.Vagon.DataPropertyName = "Vagon";
            this.Vagon.HeaderText = "Vagon";
            this.Vagon.Name = "Vagon";
            this.Vagon.ReadOnly = true;
            this.Vagon.Width = 85;
            // 
            // KoltukNo
            // 
            this.KoltukNo.DataPropertyName = "KoltukNo";
            this.KoltukNo.HeaderText = "K.No";
            this.KoltukNo.Name = "KoltukNo";
            this.KoltukNo.ReadOnly = true;
            this.KoltukNo.Width = 60;
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
            // SatmaTarihi
            // 
            this.SatmaTarihi.DataPropertyName = "SatisTarihi";
            this.SatmaTarihi.HeaderText = "SatışTarihi";
            this.SatmaTarihi.Name = "SatmaTarihi";
            this.SatmaTarihi.ReadOnly = true;
            this.SatmaTarihi.Width = 90;
            // 
            // Ucret
            // 
            this.Ucret.DataPropertyName = "Ucret";
            this.Ucret.HeaderText = "Ucret";
            this.Ucret.Name = "Ucret";
            this.Ucret.ReadOnly = true;
            this.Ucret.Width = 55;
            // 
            // Biletİptal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(853, 340);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Biletİptal";
            this.ShowIcon = false;
            this.Text = "Sorgu";
            this.Load += new System.EventHandler(this.Sorgu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
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