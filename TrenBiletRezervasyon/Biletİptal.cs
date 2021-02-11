using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TrenBiletRezervasyon
{
    public partial class Biletİptal : Form
    {
        public Biletİptal()
        {
            InitializeComponent();

        }
        SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=biletdb;Integrated Security=True");
        SqlDataAdapter adp;
        DataTable dt;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        void gridoldur()
        {
            con.Open();
            adp = new SqlDataAdapter("select *from BiletBilgi2 where EmailAdresi like '" + Loginscreen.maildb + "'", con);
            dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        void KayıtSil(int Ticket)
        {
            string sql = "DELETE FROM BiletBilgi2 WHERE TicketID=@TicketID";
            SqlCommand komut = new SqlCommand(sql, con);
            komut.Parameters.AddWithValue("@TicketID", Ticket);
            con.Open();
            komut.ExecuteNonQuery();
            con.Close();
        }
        private void Sorgu_Load(object sender, EventArgs e)
        {
            gridoldur();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Satın aldığınız bir bilet yok", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                if (MessageBox.Show("Seçili olan biletleri iptal etmek istediğinize emin misiniz ?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    foreach (DataGridViewRow drow in dataGridView1.SelectedRows)  //Seçili Satırları Silme
                    {
                        int Ticket = Convert.ToInt32(drow.Cells[0].Value);
                        KayıtSil(Ticket);

                    }
                    gridoldur();
                    MessageBox.Show("Seçili biletler iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
           
        }
    }
}
