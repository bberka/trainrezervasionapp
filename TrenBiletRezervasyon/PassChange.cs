using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TrenBiletRezervasyon
{
    public partial class PassChange : Form
    {
        public PassChange()
        {
            InitializeComponent();
            labelmail.Text = Loginscreen.maildb;
            labelad.Text = Loginscreen.addb + Loginscreen.soyaddb;


        }
        SqlConnection baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=biletdb;Integrated Security=True");
        string oldp = Loginscreen.passdb.ToString();
        private void buttonSorgu_Click(object sender, EventArgs e)
        {

            if (oldpasstext.Text.Contains(" ") || newpasstext.Text.Contains(" ") || newpasstext2.Text.Contains(" ")) MessageBox.Show("Girilen bilgiler boşluk içeremez", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (newpasstext.Text.Length < 3) MessageBox.Show("Kullanıcı adı ,şifre ve email en az 3 karakter uzunluğunda olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (newpasstext.Text != newpasstext2.Text) MessageBox.Show("Yeni girilen şifreler uyuşmuyor.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (oldp == oldpasstext.Text)
            {
                try
                {
                    baglanti.Open();
                    SqlCommand sqlcmd = new SqlCommand("UPDATE admin SET password=@password WHERE email=@email", baglanti);
                    sqlcmd.Parameters.Add("@password", SqlDbType.NVarChar).Value = newpasstext.Text;
                    sqlcmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = labelmail.Text;
                    sqlcmd.ExecuteNonQuery();
                    MessageBox.Show("Şifreniz başarıyla değiştirildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    oldpasstext.Text = "";
                    newpasstext.Text = "";
                    newpasstext2.Text = "";
                    baglanti.Close();
                }
                catch (Exception er)
                {                    
                    MessageBox.Show(er.ToString());                    
                }
            }
            else if (oldpasstext.Text == newpasstext.Text) MessageBox.Show("Yeni şifreniz eskisi ile aynı olamaz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                MessageBox.Show("Eski şifreniz yanlış.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void oldpasstext_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void newpasstext_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void newpasstext2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
