using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;



namespace TrenBiletRezervasyon

{
    public partial class Satis : Form
    {
        public Satis()
        {
            InitializeComponent();
            dateTimePickerbilet.MaxDate = DateTime.Now.AddDays(14).Date;
            dateTimePickerbilet.MinDate = DateTime.Now.Date;
            dateTimePickerdgm.MaxDate = DateTime.Now.Date;

            baglanti.Open();
            DataTable datatablesehir = new DataTable();
            SqlDataAdapter adaptersehir = new SqlDataAdapter("SELECT Cities from SehirListe", baglanti); //sehirlistesine dbden veri çeker
            adaptersehir.Fill(datatablesehir);
            for (int var1 = 0; var1 < datatablesehir.Rows.Count; var1++)
            {

                string data1 = datatablesehir.Rows[var1]["Cities"].ToString();
                sehirlist.Items.Add(data1);
            }

            DataTable datatablesaat = new DataTable();
            SqlDataAdapter adaptersaat = new SqlDataAdapter("SELECT Saat from SaatListe", baglanti); //saatlistesine dbden veri çeker
            adaptersaat.Fill(datatablesaat);
            for (int var2 = 0; var2 < datatablesaat.Rows.Count; var2++)
            {
                string data2 = datatablesaat.Rows[var2]["Saat"].ToString();
                saatlist.Items.Add(data2);
            }
            baglanti.Close();

        }
        SqlConnection baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=biletdb;Integrated Security=True");
        DataSet Ds = new DataSet();
        public int vagoninf = 0, indiriminf = 0, ucret = 0;
        public string SecilenTarih;
        int sayac = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Loginscreen.acclvl == 1 || Loginscreen.acclvl == 2)
            {
                editbtn.Visible = true;
                panel2.Visible = true;
            }
            else if (Loginscreen.acclvl == 0)
            {
                textBoxmail.Text = Loginscreen.maildb;
                textBoxad.Text = Loginscreen.addb;
                textBoxsoyad.Text = Loginscreen.soyaddb;
                editbtn.Visible = false;
                panel2.Visible = false;
            }
            panel2.Visible = false;

            koltukolustur();
            listesehir();
            listesaat();
            foreach (Control c in panel1.Controls)
            {
                if (c is Button)
                {
                    c.Enabled = false;
                }
            }

            //groupBox3.Enabled = false;
            //comboBoxnereye.Enabled = false;

        }
        public void silsehir() //sehirlist de seçilen veriyi db den siler 
        {
            
            string sehirdel = sehirlist.GetItemText(sehirlist.SelectedItem);
            if (sehirdel == "")
            {
                MessageBox.Show("Lütfen bir şehir seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (MessageBox.Show(sehirdel + " şehrini silmeyi onaylıyor musunuz ?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                baglanti.Open();
                comboBoxnereden.Items.Clear();
                comboBoxnereye.Items.Clear();
                string sqlsehirdelete = "DELETE FROM SehirListe WHERE Cities like @Cities ";
                SqlCommand cmdsehirdelete = new SqlCommand(sqlsehirdelete, baglanti);
                cmdsehirdelete.Parameters.Add("@Cities", SqlDbType.NVarChar).Value = sehirdel;
                cmdsehirdelete.ExecuteNonQuery();
                sehirlist.Items.Remove(sehirdel);
                MessageBox.Show("Seçilen şehir silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                baglanti.Close();
                listesehir();
            }


        }
        private void silsaat() //saatlistde sçeilen veriyi dbden siler
        {
            string saatdel = saatlist.GetItemText(saatlist.SelectedItem);
            if (saatdel == "")
            {
                MessageBox.Show("Lütfen bir saat seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (MessageBox.Show(saatdel + " saatini silmeyi onaylıyor musunuz ?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                baglanti.Open();
                string sqlsehirdelete = "DELETE FROM SaatListe WHERE Saat like @Saat ";
                SqlCommand cmdsehirdelete = new SqlCommand(sqlsehirdelete, baglanti);
                cmdsehirdelete.Parameters.Add("@Saat", SqlDbType.NVarChar).Value = saatdel;
                cmdsehirdelete.ExecuteNonQuery();
                saatlist.Items.Remove(saatdel);
                MessageBox.Show("Seçilen saat silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listesaat();
                baglanti.Close();
                
            }


        }
        private void koltukolustur() //panele koltuk olstuurr
        {
            sayac = 1;
            for (int i = 0; i < 8; i++)
            {
                for (int s = 0; s < 5; s++)
                {

                    Button btn = new Button();
                    btn.BackColor = Color.White;
                    btn.Size = new Size(45, 40);
                    btn.ForeColor = Color.Red;
                    btn.Location = new Point(s * 50 + 10, i * 45 + 10);
                    btn.TextAlign = ContentAlignment.TopCenter;
                    btn.Image = Image.FromFile("C:\\Users\\Administrator\\source\\repos\\TrenBiletRezervasyon\\koltuk.png");
                    btn.Name = sayac.ToString();
                    btn.Text = sayac.ToString();
                    if (s == 2) continue;
                    if (i == 0) continue;
                    sayac++;
                    this.panel1.Controls.Add(btn);
                    btn.Click += btnclick;
                }
            }
        }
        private void enablekoltuk() //koltukların olduğu paneli etkinlestir
        {
            if (comboBoxnereden.SelectedItem == null || comboBoxnereden.SelectedItem == null || comboBoxnereye.SelectedItem == null || comboBoxvagon.SelectedItem == null)
            {

            }
            else
            {
                foreach (Control c in panel1.Controls) c.Enabled = true;

            }
        }
        private void koltukrenklendir() //tüm koltukları beyaz yapar
        {
            foreach (Control item in panel1.Controls)
            {

                if (item is Button)
                {
                    item.BackColor = Color.White;
                    button2.BackColor = Color.LightGray;
                    button4.BackColor = Color.Gold;
                    button3.BackColor = Color.Red;
                }

            }
        }
        private void koltukrenksari()//kırmızı olmayan tüm koltukları beyaz yapar
        {
            foreach (Control item in panel1.Controls)
            {
                if (item is Button)
                {
                    if (item.BackColor == Color.Gold)
                    {
                        item.BackColor = Color.White;
                        button2.BackColor = Color.LightGray;
                        button4.BackColor = Color.Gold;
                        button3.BackColor = Color.Red;
                    }
                }
            }
        }
        public void control() //satılan koltukları kırmızıya boyar
        {
            Ds.Clear();
            b.Items.Clear();
            try
            {
                DateTime dtime = dateTimePickerbilet.Value.Date;
                string datebilet = dtime.ToString().Substring(0, dtime.ToString().Length - 9);
                string kontrol1 = "select * from BiletBilgi2 where BiletTarih LIKE '" + datebilet + "' and Nereden LIKE'" + comboBoxnereden.SelectedItem + "' and Nereye LIKE'" + comboBoxnereye.SelectedItem + "'  and TrenSaati LIKE '" + comboBoxtrensaat.SelectedItem + "' and Vagon LIKE '" + comboBoxvagon.SelectedItem + "' ";
                baglanti.Open();
                SqlDataAdapter adp = new SqlDataAdapter(kontrol1, baglanti);
                adp.Fill(Ds, "BiletBilgi2");
                dataGridView1.DataSource = Ds.Tables["BiletBilgi2"];

                for (int i = 0; i <= dataGridView1.Rows.Count - 2; i++)
                {
                    b.Items.Add(dataGridView1.Rows[i].Cells[13].Value.ToString());

                }
                string[] veriler1 = new string[b.Items.Count];
                for (int i = 0; i < b.Items.Count; i++)
                {
                    veriler1[i] = b.Items[i].ToString();
                }

                for (int say = 0; say < b.Items.Count; say++)
                {
                    foreach (Control item in panel1.Controls)
                    {
                        if (item is Button)
                        {
                            if (veriler1[say] == item.Text)
                            {
                                item.BackColor = Color.Red;
                            }

                        }

                    }

                }
                baglanti.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                baglanti.Close();
            }

        }
        public void listesehir()//sehirlistteki verileri comboboxlara çeker
        {
            int sehirsayi = sehirlist.Items.Count;
            string[] sehirler = new string[sehirsayi];
            
            comboBoxnereye.Items.Clear();
            for (int d2 = 0; d2 < sehirlist.Items.Count; d2++) //sehirler arrayına listedeki itemleri atar
            {
                sehirler[d2] = sehirlist.Items[d2].ToString();
            }
            for (int say = 0; say < sehirlist.Items.Count; say++) //comboya itemlerı ekler
            {
                if (comboBoxnereden.Items.Contains(sehirler[say]) != true)
                {
                    comboBoxnereden.Items.Add(sehirler[say]);
                }

                if (comboBoxnereden.Text == sehirler[say])
                {
                    continue;
                }
                else comboBoxnereye.Items.Add(sehirler[say]);
            }
            

        }
        public void listesaat()//saatlistteki verileri saatcombosuna çeker
        {
            int saatsayi = saatlist.Items.Count;
            string[] saatler = new string[saatsayi];
            comboBoxtrensaat.Items.Clear();
            for (int d3 = 0; d3 < saatlist.Items.Count; d3++) //sehirler arrayına listedeki itemleri atar
            {
                saatler[d3] = saatlist.Items[d3].ToString();
            }
            for (int say2 = 0; say2 < saatlist.Items.Count; say2++) //comboya itemlerı ekler
            {
                comboBoxtrensaat.Items.Add(saatler[say2]);
            }

        }
        private void satisyap()
        {
            DateTime dtimenow = DateTime.Now;
            DateTime dtimedgm = dateTimePickerdgm.Value.Date;
            DateTime dtimebilet = dateTimePickerbilet.Value.Date;
            if (textBoxad.Text.Length == 0 || textBoxsoyad.Text.Length == 0 || textBoxkimlik.Text.Length == 0 || textBoxtel.MaskCompleted == false || textBoxmail.Text.Length == 0 || textBox7.Text.Length == 0 || comboBoxtrensaat.Text.Length == 0 || comboBoxnereden.Text.Length == 0 || comboBoxnereye.Text.Length == 0 || comboBoxvagon.Text.Length == 0 || comboBoxcinsiyet.Text.Length == 0 || comboBoxindirim.Text.Length == 0) MessageBox.Show("Lütfen tüm boşlukları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (textBox5.Text.Length == 0) MessageBox.Show("Lütfen koltuk seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else
            {
                int ucrett = Convert.ToInt32(textBox7.Text);
                if (MessageBox.Show("Girdiğiniz bilgilerin doğruluğunu onaylıyor musunuz ?" + "\n" + "\n" + "Ücret: " + ucrett.ToString() + "TL", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlCommand ekle = new SqlCommand(@"insert into BiletBilgi2 
               (Ad, Soyad, DogumTarih, KimlikNo, TelNo, EmailAdresi, Cinsiyet, Nereden, Nereye, BiletTarih, TrenSaati, Vagon, KoltukNo, Indirim, SatisTarihi, Ucret) values
			   (@Ad, @Soyad, @DogumTarih, @KimlikNo, @TelNo, @EmailAdresi, @Cinsiyet, @Nereden, @Nereye, @BiletTarih, @TrenSaati, @Vagon, @KoltukNo, @Indirim, @SatisTarihi, @Ucret)",
               baglanti))
                    {
                        string kimlik = textBoxkimlik.Text.ToString();

                        string datecnow = dtimenow.ToString().Substring(0, dtimenow.ToString().Length - 9);
                        string dtimebilet2 = dtimebilet.ToString().Substring(0, dtimebilet.ToString().Length - 9);
                        string dtimedgm2 = dtimedgm.ToString().Substring(0, dtimedgm.ToString().Length - 9);
                        ekle.Parameters.Add("@Ad", SqlDbType.NText).Value = textBoxad.Text.ToString();
                        decimal.TryParse(textBox7.Text, out decimal ucret);
                        ekle.Parameters.Add("@Soyad", SqlDbType.NText).Value = textBoxsoyad.Text.ToString();
                        ekle.Parameters.Add("@DogumTarih", SqlDbType.NText).Value = dtimedgm2;
                        ekle.Parameters.Add("@KimlikNo", SqlDbType.NText).Value = kimlik;
                        ekle.Parameters.Add("@TelNo", SqlDbType.NText).Value = textBoxtel.Text;
                        ekle.Parameters.Add("@EmailAdresi", SqlDbType.NText).Value = textBoxmail.Text.ToString();
                        ekle.Parameters.Add("@Cinsiyet", SqlDbType.NText).Value = comboBoxcinsiyet.Text.ToString();
                        ekle.Parameters.Add("@Nereden", SqlDbType.NText).Value = comboBoxnereden.Text.ToString();
                        ekle.Parameters.Add("@Nereye", SqlDbType.NText).Value = comboBoxnereye.Text.ToString();
                        ekle.Parameters.Add("@BiletTarih", SqlDbType.NText).Value = dtimebilet2;
                        ekle.Parameters.Add("@TrenSaati", SqlDbType.NText).Value = comboBoxtrensaat.Text.ToString();
                        ekle.Parameters.Add("@Vagon", SqlDbType.NText).Value = comboBoxvagon.Text.ToString();
                        ekle.Parameters.Add("@KoltukNo", SqlDbType.Int).Value = int.Parse(textBox5.Text);
                        ekle.Parameters.Add("@Indirim", SqlDbType.NText).Value = comboBoxindirim.Text.ToString();
                        ekle.Parameters.Add("@SatisTarihi", SqlDbType.NText).Value = datecnow;
                        ekle.Parameters.Add("@Ucret", SqlDbType.Int).Value = ucret;
                        baglanti.Open();
                        ekle.ExecuteNonQuery();
                    }

                    string kayit = "SELECT * from BiletBilgi2";
                    SqlCommand komut = new SqlCommand(kayit, baglanti);            
                    SqlDataAdapter da = new SqlDataAdapter(komut);                                                                         
                    DataTable dt = new DataTable();
                    da.Fill(dt);                                          

                    int rowcount = dt.Rows.Count - 1;
                    string PNRkod = dt.Rows[rowcount].ItemArray[0].ToString();
                    MessageBox.Show("Bilet Rezervasyon başarılı!" + "\n" + "\n" + "Bilet PNR kodunuz: " + PNRkod, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    baglanti.Close();
                    if (textBoxad.Text != Loginscreen.addb) textBoxad.Text = "";
                    if (textBoxsoyad.Text != Loginscreen.soyaddb) textBoxsoyad.Text = "";
                    if (textBoxmail.Text != Loginscreen.maildb) textBoxmail.Text = "";
                    textBoxkimlik.Text = "";
                    textBoxtel.Text = "";
                    textBox5.Text = "";
                    comboBoxtrensaat.SelectedItem = null;
                    comboBoxnereden.SelectedItem = null;
                    comboBoxnereye.SelectedItem = null;
                    comboBoxvagon.SelectedItem = null;
                    comboBoxcinsiyet.SelectedItem = null;
                    comboBoxindirim.SelectedItem = null;
                    textBox7.Text = "";
                    foreach (Control c in panel1.Controls) c.Enabled = false;
                    //groupBox3.Enabled = false;
                    
                }

            }
        }
        private void addsehir()
        {
            if (sehirText.Text == "")
            {
                MessageBox.Show("Boş veri girilemez.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    if (MessageBox.Show(sehirText.Text.ToString() + " verisini şehir olarak eklemek istediğinize emin misin?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        baglanti.Open();
                        SqlCommand cmdaddsehir = new SqlCommand(@"INSERT INTO SehirListe (Cities) values (@City)", baglanti);
                        cmdaddsehir.Parameters.Add("@City", SqlDbType.NVarChar).Value = sehirText.Text.ToString();
                        cmdaddsehir.ExecuteNonQuery();
                        sehirlist.Items.Add(sehirText.Text.ToString());
                        MessageBox.Show(sehirText.Text.ToString() + " şehri eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        sehirText.Text = "";
                        comboBoxnereden.Items.Clear();
                        listesehir();
                        baglanti.Close();
                    }
                    else return;
                }
                catch
                {
                    MessageBox.Show("Aynı şehir 2 kere girilemez.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }

        }
        private void addsaat()
        {
            if (saatText.Text == "")
            {
                MessageBox.Show("Boş veri girilemez.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    if (MessageBox.Show(saatText.Text.ToString() + " verisini saat olarak eklemek istediğinize emin misin?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        baglanti.Open();
                        SqlCommand cmdaddsaat = new SqlCommand(@"INSERT INTO SaatListe (Saat) values (@Saat2)", baglanti);
                        cmdaddsaat.Parameters.Add("@Saat2", SqlDbType.NVarChar).Value = saatText.Text.ToString();
                        cmdaddsaat.ExecuteNonQuery();
                        saatlist.Items.Add(saatText.Text.ToString());
                        MessageBox.Show(saatText.Text.ToString() + " saati eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        saatText.Clear();
                        listesaat();
                        baglanti.Close();
                    }
                    else return;
                }
                catch
                {
                    MessageBox.Show("Aynı saat 2 kere girilemez.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }
        private void fiyat()
        {
            if (comboBoxnereden.SelectedItem == null || comboBoxnereye.SelectedItem == null || comboBoxtrensaat.SelectedItem == null || comboBoxvagon.SelectedItem == null || comboBoxindirim.SelectedItem == null)
            {

            }
            else
            {

                if (comboBoxindirim.Text == "Tam") indiriminf = 30;
                else if (comboBoxindirim.Text == "Öğrenci/Çocuk") indiriminf = 20;


                if (comboBoxvagon.Text == "V1 (Ekonomi)") vagoninf = 40;
                else if (comboBoxvagon.Text == "V1 (Ekonomi)") vagoninf = 40;
                else if (comboBoxvagon.Text == "V2 (Ekonomi)") vagoninf = 40;
                else if (comboBoxvagon.Text == "V3 (Ekonomi)") vagoninf = 40;
                else if (comboBoxvagon.Text == "V4 (Ekonomi)") vagoninf = 40;
                else if (comboBoxvagon.Text == "V5 (Business)") vagoninf = 60;
                else if (comboBoxvagon.Text == "V6 (Business)") vagoninf = 60;
                else if (comboBoxvagon.Text == "V7 (Business)") vagoninf = 60;
                ucret = vagoninf + indiriminf;
                textBox7.Text = Convert.ToString(ucret);
                textBox7.Text = Convert.ToString(ucret);
            }

        }

        private void btnclick(object sender, EventArgs e) //paneldeki koltuk click eventi
        {

            Button b = (Button)sender;
            if (b.BackColor == Color.White)
            {
                koltukrenksari();
                textBox5.Text = b.Text;
                b.BackColor = Color.Gold;
            }
            if (b.BackColor == Color.Red)
            {
                //MessageBox.Show("Bu koltuk dolu","",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                koltukrenksari();
                textBox5.Text = "";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e) //Boşluk engelleme
        {
            e.Handled = Char.IsWhiteSpace(e.KeyChar); 
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e) //Boşluk engelleme
        {
            e.Handled = Char.IsWhiteSpace(e.KeyChar);
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)//sadece harf
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)//sadece harf
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_StyleChanged(object sender, EventArgs e)
        {

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)//Boşluk engelleme
        {
            e.Handled = Char.IsWhiteSpace(e.KeyChar);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            SatisListe satisliste = new SatisListe();
            satisliste.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e) //BILET SATIS
        {
            satisyap();
        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void comboBox7_SelectedValueChanged(object sender, EventArgs e) //Tam öğrenci bilet fiyatı
        {
            fiyat();
        }

        private void textBox9_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click_2(object sender, EventArgs e)
        {


        }

        private void button13_Click_3(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

            koltukrenklendir();
            control();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            enablekoltuk();
            koltukrenklendir();
            control();
            fiyat();
        }

        private void comboBox6_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            enablekoltuk();
            koltukrenklendir();
            control();
            listesehir();
            //listesaat();
            fiyat();
        }

        private void comboBox3_SelectedValueChanged(object sender, EventArgs e)
        {
            enablekoltuk();
            koltukrenklendir();
            control();
            fiyat();
        }

        private void textDatePicker2Copy_TextChanged(object sender, EventArgs e)
        {

        }

        private void b_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void b_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e) //panel1 için kenarlık
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel1.ClientRectangle, Color.White, ButtonBorderStyle.Solid);
        }

        private void comboBoxcinsiyet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxmail_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void sehirlist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBoxtel.Text);
        }

        private void textBoxtel_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            addsehir();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            addsaat();
            
        }

        private void saatsilbtn_Click(object sender, EventArgs e)
        {
            silsaat();
            
        }

        private void sehirsilbtn_Click(object sender, EventArgs e)
        {
            
            silsehir();
            
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel2.ClientRectangle, Color.White, ButtonBorderStyle.Solid);
        }
        public static bool a = false;
        private void editbtn_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == true)
            {
                panel1.Visible = false;
                panel2.Visible = true;
                editbtn.BackColor = Color.SteelBlue;
            }
            else if (panel2.Visible == true)
            {
                panel1.Visible = true;
                panel2.Visible = false;
                editbtn.BackColor = Color.LightBlue;
            }



        }

        private void sehirText_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) ;
        }

        private void sehirText_TextChanged(object sender, EventArgs e)
        {
            sehirText.CharacterCasing = CharacterCasing.Upper;
        }

        private void button13_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedValueChanged(object sender, EventArgs e) //vagon için fiyat
        {
            enablekoltuk();
            koltukrenklendir();
            control();
            fiyat();

        }
    }

}
