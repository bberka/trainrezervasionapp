namespace TrenBiletRezervasyon
{
    partial class Satis
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Satis));
            this.textBoxad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxsoyad = new System.Windows.Forms.TextBox();
            this.dateTimePickerdgm = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerbilet = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxkimlik = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxtrensaat = new System.Windows.Forms.ComboBox();
            this.comboBoxnereden = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxnereye = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxvagon = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxcinsiyet = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBoxindirim = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxmail = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxtel = new System.Windows.Forms.MaskedTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.editbtn = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.biletdbDataSet1 = new TrenBiletRezervasyon.biletdbDataSet();
            this.label18 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.b = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sehirlist = new System.Windows.Forms.ListBox();
            this.saatlist = new System.Windows.Forms.ListBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.sehirText = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.sehirsilbtn = new System.Windows.Forms.Button();
            this.saatsilbtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.saatText = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.biletdbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxad
            // 
            this.textBoxad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxad.Location = new System.Drawing.Point(13, 94);
            this.textBoxad.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.textBoxad.MaxLength = 25;
            this.textBoxad.Name = "textBoxad";
            this.textBoxad.Size = new System.Drawing.Size(170, 24);
            this.textBoxad.TabIndex = 1;
            this.textBoxad.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBoxad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(10, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "AD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(9, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "SOYAD";
            // 
            // textBoxsoyad
            // 
            this.textBoxsoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxsoyad.Location = new System.Drawing.Point(14, 145);
            this.textBoxsoyad.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.textBoxsoyad.MaxLength = 25;
            this.textBoxsoyad.Name = "textBoxsoyad";
            this.textBoxsoyad.Size = new System.Drawing.Size(169, 24);
            this.textBoxsoyad.TabIndex = 2;
            this.textBoxsoyad.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBoxsoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // dateTimePickerdgm
            // 
            this.dateTimePickerdgm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePickerdgm.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerdgm.Location = new System.Drawing.Point(13, 277);
            this.dateTimePickerdgm.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.dateTimePickerdgm.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerdgm.MinDate = new System.DateTime(1800, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerdgm.Name = "dateTimePickerdgm";
            this.dateTimePickerdgm.Size = new System.Drawing.Size(117, 24);
            this.dateTimePickerdgm.TabIndex = 4;
            this.dateTimePickerdgm.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePickerbilet
            // 
            this.dateTimePickerbilet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePickerbilet.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerbilet.Location = new System.Drawing.Point(13, 167);
            this.dateTimePickerbilet.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.dateTimePickerbilet.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerbilet.MinDate = new System.DateTime(2020, 8, 1, 0, 0, 0, 0);
            this.dateTimePickerbilet.Name = "dateTimePickerbilet";
            this.dateTimePickerbilet.Size = new System.Drawing.Size(145, 24);
            this.dateTimePickerbilet.TabIndex = 10;
            this.dateTimePickerbilet.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(9, 251);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "DOGUM TARİHİ";
            // 
            // textBoxkimlik
            // 
            this.textBoxkimlik.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxkimlik.Location = new System.Drawing.Point(12, 338);
            this.textBoxkimlik.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.textBoxkimlik.MaxLength = 11;
            this.textBoxkimlik.Name = "textBoxkimlik";
            this.textBoxkimlik.Size = new System.Drawing.Size(118, 24);
            this.textBoxkimlik.TabIndex = 6;
            this.textBoxkimlik.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.textBoxkimlik.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(11, 317);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 22);
            this.label4.TabIndex = 14;
            this.label4.Text = "KİMLİK NO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(10, 140);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 22);
            this.label5.TabIndex = 15;
            this.label5.Text = "BİLET TARİHİ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(9, 67);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 22);
            this.label6.TabIndex = 16;
            this.label6.Text = "NEREDEN";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(192, 67);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 22);
            this.label7.TabIndex = 17;
            this.label7.Text = "NEREYE";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(18, 24);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(271, 34);
            this.label8.TabIndex = 19;
            this.label8.Text = "KİŞİSEL BİLGİLER";
            // 
            // comboBoxtrensaat
            // 
            this.comboBoxtrensaat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxtrensaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxtrensaat.FormattingEnabled = true;
            this.comboBoxtrensaat.ItemHeight = 18;
            this.comboBoxtrensaat.Location = new System.Drawing.Point(196, 165);
            this.comboBoxtrensaat.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.comboBoxtrensaat.Name = "comboBoxtrensaat";
            this.comboBoxtrensaat.Size = new System.Drawing.Size(112, 26);
            this.comboBoxtrensaat.TabIndex = 11;
            this.comboBoxtrensaat.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBoxtrensaat.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            this.comboBoxtrensaat.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // comboBoxnereden
            // 
            this.comboBoxnereden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxnereden.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxnereden.FormattingEnabled = true;
            this.comboBoxnereden.Location = new System.Drawing.Point(13, 94);
            this.comboBoxnereden.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.comboBoxnereden.Name = "comboBoxnereden";
            this.comboBoxnereden.Size = new System.Drawing.Size(145, 26);
            this.comboBoxnereden.TabIndex = 8;
            this.comboBoxnereden.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            this.comboBoxnereden.SelectedValueChanged += new System.EventHandler(this.comboBox2_SelectedValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(193, 142);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 22);
            this.label9.TabIndex = 22;
            this.label9.Text = "TREN SAATİ";
            // 
            // comboBoxnereye
            // 
            this.comboBoxnereye.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxnereye.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxnereye.FormattingEnabled = true;
            this.comboBoxnereye.Location = new System.Drawing.Point(196, 94);
            this.comboBoxnereye.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.comboBoxnereye.Name = "comboBoxnereye";
            this.comboBoxnereye.Size = new System.Drawing.Size(137, 26);
            this.comboBoxnereye.TabIndex = 9;
            this.comboBoxnereye.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            this.comboBoxnereye.SelectedValueChanged += new System.EventHandler(this.comboBox3_SelectedValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(53, 18);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(255, 34);
            this.label10.TabIndex = 24;
            this.label10.Text = "BİLET BİLGİLERİ";
            // 
            // comboBoxvagon
            // 
            this.comboBoxvagon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxvagon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxvagon.FormattingEnabled = true;
            this.comboBoxvagon.Items.AddRange(new object[] {
            "V1 (Ekonomi)",
            "V2 (Ekonomi)",
            "V3 (Ekonomi)",
            "V4 (Ekonomi)",
            "V5 (Business)",
            "V6 (Business)",
            "V7 (Business)"});
            this.comboBoxvagon.Location = new System.Drawing.Point(14, 241);
            this.comboBoxvagon.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.comboBoxvagon.Name = "comboBoxvagon";
            this.comboBoxvagon.Size = new System.Drawing.Size(127, 26);
            this.comboBoxvagon.TabIndex = 12;
            this.comboBoxvagon.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            this.comboBoxvagon.SelectedValueChanged += new System.EventHandler(this.comboBox4_SelectedValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(10, 217);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 22);
            this.label11.TabIndex = 26;
            this.label11.Text = "VAGON";
            // 
            // comboBoxcinsiyet
            // 
            this.comboBoxcinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxcinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxcinsiyet.FormattingEnabled = true;
            this.comboBoxcinsiyet.Items.AddRange(new object[] {
            "ERKEK",
            "KADIN"});
            this.comboBoxcinsiyet.Location = new System.Drawing.Point(176, 275);
            this.comboBoxcinsiyet.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.comboBoxcinsiyet.Name = "comboBoxcinsiyet";
            this.comboBoxcinsiyet.Size = new System.Drawing.Size(113, 26);
            this.comboBoxcinsiyet.TabIndex = 5;
            this.comboBoxcinsiyet.SelectedIndexChanged += new System.EventHandler(this.comboBoxcinsiyet_SelectedIndexChanged);
            this.comboBoxcinsiyet.SelectedValueChanged += new System.EventHandler(this.comboBox6_SelectedValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(173, 251);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 22);
            this.label13.TabIndex = 30;
            this.label13.Text = "CİNSİYET";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(174, 313);
            this.label14.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 22);
            this.label14.TabIndex = 32;
            this.label14.Text = "TELEFON NO";
            // 
            // comboBoxindirim
            // 
            this.comboBoxindirim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxindirim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxindirim.FormattingEnabled = true;
            this.comboBoxindirim.Items.AddRange(new object[] {
            "Tam",
            "Öğrenci/Çocuk"});
            this.comboBoxindirim.Location = new System.Drawing.Point(196, 241);
            this.comboBoxindirim.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.comboBoxindirim.Name = "comboBoxindirim";
            this.comboBoxindirim.Size = new System.Drawing.Size(137, 26);
            this.comboBoxindirim.TabIndex = 13;
            this.comboBoxindirim.SelectedIndexChanged += new System.EventHandler(this.comboBox7_SelectedIndexChanged);
            this.comboBoxindirim.SelectedValueChanged += new System.EventHandler(this.comboBox7_SelectedValueChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(193, 216);
            this.label15.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(140, 22);
            this.label15.TabIndex = 34;
            this.label15.Text = "BİLET İNDİRİM";
            // 
            // textBox7
            // 
            this.textBox7.Enabled = false;
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox7.Location = new System.Drawing.Point(106, 305);
            this.textBox7.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(35, 31);
            this.textBox7.TabIndex = 41;
            this.textBox7.Text = "0";
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.Location = new System.Drawing.Point(10, 309);
            this.label16.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 24);
            this.label16.TabIndex = 42;
            this.label16.Text = "ÜCRET:";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // textBoxmail
            // 
            this.textBoxmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxmail.Location = new System.Drawing.Point(14, 209);
            this.textBoxmail.Name = "textBoxmail";
            this.textBoxmail.Size = new System.Drawing.Size(212, 24);
            this.textBoxmail.TabIndex = 3;
            this.textBoxmail.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxmail_MouseClick);
            this.textBoxmail.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            this.textBoxmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox8_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(10, 184);
            this.label17.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(140, 22);
            this.label17.TabIndex = 44;
            this.label17.Text = "E-MAİL ADRESİ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxtel);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBoxad);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.textBoxsoyad);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dateTimePickerdgm);
            this.groupBox2.Controls.Add(this.comboBoxcinsiyet);
            this.groupBox2.Controls.Add(this.textBoxmail);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBoxkimlik);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(12, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(313, 376);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // textBoxtel
            // 
            this.textBoxtel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxtel.Location = new System.Drawing.Point(176, 338);
            this.textBoxtel.Mask = "(999) 000-0000";
            this.textBoxtel.Name = "textBoxtel";
            this.textBoxtel.Size = new System.Drawing.Size(113, 24);
            this.textBoxtel.TabIndex = 7;
            this.textBoxtel.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.textBoxtel_MaskInputRejected);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.editbtn);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.comboBoxnereden);
            this.groupBox3.Controls.Add(this.dateTimePickerbilet);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.comboBoxvagon);
            this.groupBox3.Controls.Add(this.textBox7);
            this.groupBox3.Controls.Add(this.comboBoxtrensaat);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.comboBoxindirim);
            this.groupBox3.Controls.Add(this.comboBoxnereye);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox3.Location = new System.Drawing.Point(342, 9);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(353, 370);
            this.groupBox3.TabIndex = 46;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // editbtn
            // 
            this.editbtn.BackColor = System.Drawing.Color.LightBlue;
            this.editbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editbtn.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.editbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editbtn.Location = new System.Drawing.Point(196, 299);
            this.editbtn.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(137, 47);
            this.editbtn.TabIndex = 222;
            this.editbtn.Text = "DÜZENLE";
            this.editbtn.UseVisualStyleBackColor = false;
            this.editbtn.Click += new System.EventHandler(this.editbtn_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label21.Location = new System.Drawing.Point(182, 377);
            this.label21.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(80, 22);
            this.label21.TabIndex = 54;
            this.label21.Text = "SEÇİLEN";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Gold;
            this.button4.Enabled = false;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(205, 402);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(35, 30);
            this.button4.TabIndex = 44;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label20.Location = new System.Drawing.Point(19, 378);
            this.label20.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(40, 22);
            this.label20.TabIndex = 53;
            this.label20.Text = "BOŞ";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGray;
            this.button2.Enabled = false;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(21, 402);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 30);
            this.button2.TabIndex = 43;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label19.Location = new System.Drawing.Point(105, 377);
            this.label19.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(50, 22);
            this.label19.TabIndex = 52;
            this.label19.Text = "DOLU";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Enabled = false;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(112, 403);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(35, 30);
            this.button3.TabIndex = 51;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox5.Location = new System.Drawing.Point(1570, 105);
            this.textBox5.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(26, 26);
            this.textBox5.TabIndex = 37;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(1508, 107);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 22);
            this.label12.TabIndex = 38;
            this.label12.Text = "KNO:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // biletdbDataSet1
            // 
            this.biletdbDataSet1.DataSetName = "biletdbDataSet";
            this.biletdbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(29, 8);
            this.label18.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(207, 34);
            this.label18.TabIndex = 47;
            this.label18.Text = "YOLCU DÜZENİ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1570, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(26, 21);
            this.dataGridView1.TabIndex = 48;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // b
            // 
            this.b.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b.FormattingEnabled = true;
            this.b.ItemHeight = 2;
            this.b.Location = new System.Drawing.Point(1570, 27);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(26, 18);
            this.b.TabIndex = 49;
            this.b.SelectedIndexChanged += new System.EventHandler(this.b_SelectedIndexChanged);
            this.b.SelectedValueChanged += new System.EventHandler(this.b_SelectedValueChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(12, 394);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(683, 64);
            this.button1.TabIndex = 16;
            this.button1.Text = "REZERVASYON YAP  ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button1_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(710, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 441);
            this.panel1.TabIndex = 15;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // sehirlist
            // 
            this.sehirlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sehirlist.FormattingEnabled = true;
            this.sehirlist.ItemHeight = 24;
            this.sehirlist.Location = new System.Drawing.Point(27, 47);
            this.sehirlist.Name = "sehirlist";
            this.sehirlist.Size = new System.Drawing.Size(113, 172);
            this.sehirlist.TabIndex = 51;
            this.sehirlist.SelectedIndexChanged += new System.EventHandler(this.sehirlist_SelectedIndexChanged);
            // 
            // saatlist
            // 
            this.saatlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.saatlist.FormattingEnabled = true;
            this.saatlist.ItemHeight = 24;
            this.saatlist.Location = new System.Drawing.Point(27, 274);
            this.saatlist.Name = "saatlist";
            this.saatlist.Size = new System.Drawing.Size(113, 148);
            this.saatlist.TabIndex = 51;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label22.Location = new System.Drawing.Point(21, 10);
            this.label22.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(223, 34);
            this.label22.TabIndex = 52;
            this.label22.Text = "ŞEHİR LİSTESİ";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label23.Location = new System.Drawing.Point(21, 237);
            this.label23.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(207, 34);
            this.label23.TabIndex = 53;
            this.label23.Text = "SAAT LİSTESİ";
            // 
            // sehirText
            // 
            this.sehirText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sehirText.Location = new System.Drawing.Point(149, 129);
            this.sehirText.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.sehirText.MaxLength = 25;
            this.sehirText.Name = "sehirText";
            this.sehirText.Size = new System.Drawing.Size(95, 24);
            this.sehirText.TabIndex = 54;
            this.sehirText.TextChanged += new System.EventHandler(this.sehirText_TextChanged);
            this.sehirText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sehirText_KeyPress);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightBlue;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(149, 161);
            this.button5.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(95, 60);
            this.button5.TabIndex = 444;
            this.button5.Text = "ŞEHİR EKLE";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.LightBlue;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(149, 362);
            this.button6.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(95, 60);
            this.button6.TabIndex = 442;
            this.button6.Text = "SAAT EKLE";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // sehirsilbtn
            // 
            this.sehirsilbtn.BackColor = System.Drawing.Color.LightBlue;
            this.sehirsilbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sehirsilbtn.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sehirsilbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sehirsilbtn.Location = new System.Drawing.Point(149, 48);
            this.sehirsilbtn.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.sehirsilbtn.Name = "sehirsilbtn";
            this.sehirsilbtn.Size = new System.Drawing.Size(95, 35);
            this.sehirsilbtn.TabIndex = 441;
            this.sehirsilbtn.Text = "ŞEHİR SİL";
            this.sehirsilbtn.UseVisualStyleBackColor = false;
            this.sehirsilbtn.Click += new System.EventHandler(this.sehirsilbtn_Click);
            // 
            // saatsilbtn
            // 
            this.saatsilbtn.BackColor = System.Drawing.Color.LightBlue;
            this.saatsilbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saatsilbtn.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saatsilbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saatsilbtn.Location = new System.Drawing.Point(149, 275);
            this.saatsilbtn.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.saatsilbtn.Name = "saatsilbtn";
            this.saatsilbtn.Size = new System.Drawing.Size(95, 35);
            this.saatsilbtn.TabIndex = 446;
            this.saatsilbtn.Text = "SAAT SİL";
            this.saatsilbtn.UseVisualStyleBackColor = false;
            this.saatsilbtn.Click += new System.EventHandler(this.saatsilbtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.saatText);
            this.panel2.Controls.Add(this.saatlist);
            this.panel2.Controls.Add(this.sehirlist);
            this.panel2.Controls.Add(this.saatsilbtn);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.sehirsilbtn);
            this.panel2.Controls.Add(this.label23);
            this.panel2.Controls.Add(this.sehirText);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Location = new System.Drawing.Point(710, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(265, 441);
            this.panel2.TabIndex = 48;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // saatText
            // 
            this.saatText.Location = new System.Drawing.Point(149, 324);
            this.saatText.Mask = "00:00";
            this.saatText.Name = "saatText";
            this.saatText.Size = new System.Drawing.Size(95, 24);
            this.saatText.TabIndex = 447;
            // 
            // Satis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(986, 473);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.b);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Satis";
            this.Text = "Bilet Rezervasyon";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.biletdbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxsoyad;
        private System.Windows.Forms.DateTimePicker dateTimePickerdgm;
        private System.Windows.Forms.DateTimePicker dateTimePickerbilet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxkimlik;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxtrensaat;
        private System.Windows.Forms.ComboBox comboBoxnereden;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxnereye;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxvagon;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBoxcinsiyet;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBoxindirim;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxmail;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private biletdbDataSet biletdbDataSet1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox b;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ListBox sehirlist;
        private System.Windows.Forms.ListBox saatlist;
        private System.Windows.Forms.MaskedTextBox textBoxtel;
        private System.Windows.Forms.Button editbtn;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox sehirText;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button sehirsilbtn;
        private System.Windows.Forms.Button saatsilbtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MaskedTextBox saatText;
    }
}

