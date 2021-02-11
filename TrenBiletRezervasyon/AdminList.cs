using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace TrenBiletRezervasyon
{
    public partial class AdminList : Form
    {
        DataTable dt;
        SqlConnection baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=biletdb;Integrated Security=True");
        SqlDataAdapter da;
        SqlCommandBuilder cmdbld;
        SqlCommand komut;
        DataSet ds;
        public AdminList()
        {
            InitializeComponent();
            

        }
        
        void KayıtSil(int Ticket)
        {
            string sql = "DELETE FROM admin WHERE id=@id";
            komut = new SqlCommand(sql, baglanti);
            komut.Parameters.AddWithValue("@id", Ticket);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void AdminList_Load(object sender, EventArgs e)
        {
            if (Loginscreen.acclvl == 1)
            {
                btnUpdate.Enabled = false;
                btnUpdate.BackColor = Color.Gray;
            }
            else if (Loginscreen.acclvl == 2)
            {
                btnUpdate.Enabled = true;
                btnUpdate.BackColor = Color.LightBlue;
            }
            else return;
            griddoldur();
        }
        
        private void griddoldur()
        {            
            baglanti.Open();
            
            if (Loginscreen.acclvl == 1) //log as admin 
            {
                da = new SqlDataAdapter("select * from admin where role like 'user'", baglanti);
                dt = new DataTable();
                da.Fill(dt);
                adminlistgrid.DataSource = dt;
                adminlistgrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                baglanti.Close();
                adminlistgrid.ReadOnly = true;
            }
            else if (Loginscreen.acclvl == 2)
            {
                da = new SqlDataAdapter("select * from admin where not role like 'owner' ", baglanti);
                ds = new DataSet();
                da.Fill(ds, "AccDetails");
                adminlistgrid.DataSource = ds.Tables[0];
                adminlistgrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                baglanti.Close();
                adminlistgrid.ReadOnly = false;
                adminlistgrid.Columns["ID"].ReadOnly = true;

            }
            else return;
        }


        private void button1_Click(object sender, EventArgs e)
        {            
            if (adminlistgrid.Rows.Count == 0)
            {
                MessageBox.Show("Seçilen bir kullanıcı yok", "Onay", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (MessageBox.Show("Seçili olan kayıt(lar)ı silmek istediğinize emin misiniz ?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (DataGridViewRow drow in adminlistgrid.SelectedRows)  //Seçili Satırları Silme
                {
                    int Ticket = Convert.ToInt32(drow.Cells[1].Value);
                    KayıtSil(Ticket);

                }
                MessageBox.Show("Seçili kayıt(lar) silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                griddoldur();
            }
        }

        private void adminlistgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Yapılan değişiklikler veritabanına kaydetmek istediğinize emin misiniz ?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmdbld = new SqlCommandBuilder(da);
                    da.Update(ds, "AccDetails");
                    MessageBox.Show("Yapılan değişiklikler veritabanına kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else return;
            }
            catch (Exception xe)
            {
                MessageBox.Show(xe.ToString());
            }
        }
        
        private void adminlistgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void adminlistgrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void adminlistgrid_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            

        }

        private void adminlistgrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void adminlistgrid_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {

            foreach (DataGridViewRow row in adminlistgrid.Rows)

            {

                if (((DataRowView)row.DataBoundItem).Row.RowState == DataRowState.Modified)

                {
                    row.DefaultCellStyle.BackColor = Color.LightPink;
                    
                }

                else

                {

                }
            }
        }

        private void adminlistgrid_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            
            
        }
    }

}
