using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace TrenBiletRezervasyon
{
    public partial class SatisListe : Form
    {
        StringFormat strFormat;
        ArrayList arrColumnLefts = new ArrayList();
        ArrayList arrColumnWidths = new ArrayList();
        int iCellHeight = 0;
        int iTotalWidth = 0;
        int iRow = 0;
        bool bFirstPage = false;
        bool bNewPage = false;
        int iHeaderHeight = 0;
        public SatisListe()
        {
            InitializeComponent();


        }

        SqlConnection baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=biletdb;Integrated Security=True");
        private void aramadisable()
        {
            if (comboara.SelectedItem == null || textara.Text == "" && maskedTextBox1.Text == "")
            {
                buttonSorgu.Enabled = false;
                buttonSorgu.BackColor = Color.Gray;

            }

            else
            {
                buttonSorgu.Enabled = true;
                buttonSorgu.BackColor = Color.LightBlue;

            }

        }
        public int toplam = 0;
        private void toplamsatis()
        {
            toplam = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                toplam += Convert.ToInt32(dataGridView1.Rows[i].Cells["Ucret"].Value);
            }
            labelucret.Text = toplam.ToString() + " TL";
        }
        void griddoldur()
        {
            baglanti.Open();
            string kayit = "SELECT * from BiletBilgi2";
            SqlCommand komut = new SqlCommand(kayit, baglanti);            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            SqlDataAdapter da = new SqlDataAdapter(komut);            //SqlDataAdapter sınıfı verilerin databaseden aktarılması işlemini gerçekleştirir.
            //DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(dt);                                          //Bir DataTable oluşturarak DataAdapter ile getirilen verileri tablo içerisine dolduruyoruz.
            dataGridView1.DataSource = dt;                            //Formumuzdaki DataGridViewin veri kaynağını oluşturduğumuz tablo olarak gösteriyoruz.
            baglanti.Close();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        void KayıtSil(int Ticket)
        {
            string sql = "DELETE FROM BiletBilgi2 WHERE TicketID=@TicketID";
            SqlCommand komut = new SqlCommand(sql, baglanti);
            komut.Parameters.AddWithValue("@TicketID", Ticket);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void SatisListe_Load(object sender, EventArgs e)
        {
            
            dateTimePicker1.MaxDate = DateTime.Now.Date;
            griddoldur();
            aramadisable();
            toplamsatis();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)                
            {
                MessageBox.Show("Seçilen bir bilet yok", "Onay", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (MessageBox.Show("Seçili olan kayıtları silmek istediğinize emin misiniz ?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (DataGridViewRow drow in dataGridView1.SelectedRows)  //Seçili Satırları Silme
                {
                    int Ticket = Convert.ToInt32(drow.Cells[0].Value);
                    KayıtSil(Ticket);

                }
                griddoldur();
                MessageBox.Show("Seçili kayıtlar silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                toplamsatis();
            }

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            try
            {
                int iLeftMargin = e.MarginBounds.Left;
                int iTopMargin = e.MarginBounds.Top;
                bool bMorePagesToPrint = false;
                int iTmpWidth = 0;
                bFirstPage = true;

                if (bFirstPage)
                {
                    foreach (DataGridViewColumn GridCol in dataGridView1.Columns)
                    {
                        iTmpWidth = (int)(Math.Floor((double)((double)GridCol.Width /
                                       (double)iTotalWidth * (double)iTotalWidth *
                                       ((double)e.MarginBounds.Width / (double)iTotalWidth))));

                        iHeaderHeight = (int)(e.Graphics.MeasureString(GridCol.HeaderText,
                                    GridCol.InheritedStyle.Font, iTmpWidth).Height) + 11;


                        arrColumnLefts.Add(iLeftMargin);
                        arrColumnWidths.Add(iTmpWidth);
                        iLeftMargin += iTmpWidth;
                    }
                }

                while (iRow <= dataGridView1.Rows.Count - 1)
                {
                    DataGridViewRow GridRow = dataGridView1.Rows[iRow];

                    iCellHeight = GridRow.Height + 30;
                    int iCount = 0;

                    if (iTopMargin + iCellHeight >= e.MarginBounds.Height + e.MarginBounds.Top)
                    {
                        bNewPage = true;
                        bFirstPage = false;
                        bMorePagesToPrint = true;
                        break;
                    }
                    else
                    {
                        if (bNewPage)
                        {
                            //Satılan biletler kelimesini sayfa sol yukarısına ekler
                            e.Graphics.DrawString("Satılan Biletler", new Font(buttonSorgu.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top -
                                    e.Graphics.MeasureString("Satılan Biletler", new Font(buttonSorgu.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Height - 5);


                            String strDate = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString();
                            //bugünün tarihini sayfanın sağına ekler
                            e.Graphics.DrawString(strDate + "  ", new Font(buttonSorgu.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left + (e.MarginBounds.Width -
                                    e.Graphics.MeasureString(strDate + "  ", new Font(buttonSorgu.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Width - 10), e.MarginBounds.Top -
                                    e.Graphics.MeasureString("Satılan Biletler", new Font(new Font(buttonSorgu.Font,
                                    FontStyle.Bold), FontStyle.Bold), e.MarginBounds.Width).Height - 5);

                            //toplam ücreti sayfa sol altına ekler
                            e.Graphics.DrawString("Toplam ücret: " + toplam + "TL", new Font(buttonSorgu.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left + (e.MarginBounds.Width -
                                    e.Graphics.MeasureString("TOPLAM ÜCRET: " + toplam + "TL", new Font(buttonSorgu.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Width - 10), e.MarginBounds.Bottom -
                                    e.Graphics.MeasureString("Satılan Biletler", new Font(new Font(buttonSorgu.Font,
                                    FontStyle.Bold), FontStyle.Bold), e.MarginBounds.Width).Height - 5);


                            iTopMargin = e.MarginBounds.Top;
                            foreach (DataGridViewColumn GridCol in dataGridView1.Columns)
                            {
                                e.Graphics.FillRectangle(new SolidBrush(Color.LightGray),
                                    new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawRectangle(Pens.Black,
                                    new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawString(GridCol.HeaderText, GridCol.InheritedStyle.Font,
                                    new SolidBrush(GridCol.InheritedStyle.ForeColor),
                                    new RectangleF((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight), strFormat);
                                iCount++;
                            }
                            bNewPage = false;
                            iTopMargin += iHeaderHeight;
                        }
                        iCount = 0;

                        foreach (DataGridViewCell Cel in GridRow.Cells)
                        {
                            if (Cel.Value != null)
                            {
                                e.Graphics.DrawString(Cel.Value.ToString(), Cel.InheritedStyle.Font,
                                            new SolidBrush(Cel.InheritedStyle.ForeColor),
                                            new RectangleF((int)arrColumnLefts[iCount], (float)iTopMargin,
                                            (int)arrColumnWidths[iCount], (float)iCellHeight), strFormat);
                            }

                            e.Graphics.DrawRectangle(Pens.Black, new Rectangle((int)arrColumnLefts[iCount],
                                    iTopMargin, (int)arrColumnWidths[iCount], iCellHeight));

                            iCount++;
                        }
                    }
                    iRow++;
                    iTopMargin += iCellHeight;
                }


                if (bMorePagesToPrint)
                    e.HasMorePages = true;
                else
                    e.HasMorePages = false;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            //print formunu oluşturur
            PrintPreviewDialog onizleme = new PrintPreviewDialog();
            onizleme.ShowIcon = false;
            onizleme.Width = 1200;
            onizleme.Height = 900;
            onizleme.Document = printDocument1;
            onizleme.ShowDialog();
            
        }

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                strFormat = new StringFormat();
                strFormat.Alignment = StringAlignment.Near;
                strFormat.LineAlignment = StringAlignment.Center;
                strFormat.Trimming = StringTrimming.EllipsisCharacter;
                printDocument1.OriginAtMargins = true;
                printDocument1.DefaultPageSettings.Margins.Left = 5;
                printDocument1.DefaultPageSettings.Margins.Right = 5;
                printDocument1.DefaultPageSettings.Margins.Top = 20;
                printDocument1.DefaultPageSettings.Margins.Bottom = 20;
                printDocument1.DefaultPageSettings.Landscape = true;
                arrColumnLefts.Clear();
                arrColumnWidths.Clear();
                iCellHeight = 0;
                iRow = 0;
                bFirstPage = true;
                bNewPage = true;
                
                iTotalWidth = 0;
                foreach (DataGridViewColumn dgvGridCol in dataGridView1.Columns)
                {
                    iTotalWidth += dgvGridCol.Width;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonSorgu_Click(object sender, EventArgs e)
        {
            if (comboara.SelectedItem == null) MessageBox.Show("Lütfen arama türü seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //else if (textara.Text =="" && maskedTextBox1.Text == "") MessageBox.Show("Lütfen arama bilgisine veri giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (comboara.Text == "PNR Kodu")
            {
                baglanti.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from BiletBilgi2 where TicketID like '" + textara.Text + "%'", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                baglanti.Close();
                toplamsatis();
            }
            else if (comboara.Text == "Ad")
            {
                baglanti.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from BiletBilgi2 where Ad like '" + textara.Text + "%'", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                baglanti.Close();
                toplamsatis();
            }
            else if (comboara.Text == "Email")
            {
                baglanti.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from BiletBilgi2 where EmailAdresi like '" + textara.Text + "%'", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                baglanti.Close();
                toplamsatis();
            }
            else if (comboara.Text == "TelNo")
            {
                baglanti.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from BiletBilgi2 where TelNo like '" + maskedTextBox1.Text + "%'", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                baglanti.Close();
                toplamsatis();
            }
            else if (comboara.Text == "KimlikNo")
            {
                baglanti.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from BiletBilgi2 where KimlikNo like '" + textara.Text + "%'", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                baglanti.Close();
                toplamsatis();
            }
            else { toplamsatis(); }

        }

        private void buttontemizle_Click(object sender, EventArgs e)
        {
            comboara.SelectedItem = null;
            textara.Visible = true;
            textara.Text = "";
            maskedTextBox1.Visible = false;
            maskedTextBox1.Clear();
            griddoldur();
            toplamsatis();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboara_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboara.SelectedItem == null)
            {
                return;
            }
            else
            {
                textara.Text = "";
                maskedTextBox1.Clear();
                textara.Visible = true;
                maskedTextBox1.Visible = false;                
                griddoldur();
                toplamsatis();
                if (comboara.Text == "TelNo")
                {
                    maskedTextBox1.Visible = true;
                    textara.Visible = false;
                }
                else if (comboara.SelectedItem.ToString() == "KimlikNo") textara.MaxLength = 11;
                else if (comboara.SelectedItem.ToString() == "Ad") textara.MaxLength = 15;
                else if (comboara.SelectedItem.ToString() == "PNR Kodu") textara.MaxLength = 15;
                else if (comboara.SelectedItem.ToString() == "Email") textara.MaxLength = 15;
                else if (comboara.SelectedItem.ToString() == "KimlikNo") textara.MaxLength = 11;

            }

        }

        private void dateTimePicker1_ValueChanged_2(object sender, EventArgs e)
        {
            DateTime dtime = dateTimePicker1.Value.Date;
            string datec = dtime.ToString().Substring(0, dtime.ToString().Length - 9);
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from BiletBilgi2 where SatisTarihi like '" + datec + "'", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
            toplamsatis();
            comboara.SelectedItem = null;
            textara.Text = "";
            maskedTextBox1.Clear();

        }

        private void datebox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textara_TextChanged(object sender, EventArgs e)
        {
            aramadisable();
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {

            

        }

        private void textara_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (comboara.SelectedItem == null)
            {
                return;                
            }
            else if (comboara.SelectedItem.ToString() == "KimlikNo")
            {
                e.Handled = Char.IsWhiteSpace(e.KeyChar);
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            else if (comboara.SelectedItem.ToString() == "Ad")
            {
                e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar);      //&& !char.IsSeparator(e.KeyChar)          
            }
            else if (comboara.SelectedItem.ToString() == "PNR Kodu")
            {
                e.Handled = Char.IsWhiteSpace(e.KeyChar);
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            aramadisable();
        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void labelucret_Click(object sender, EventArgs e)
        {

        }
    }
}
