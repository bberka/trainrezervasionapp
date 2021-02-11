using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TrenBiletRezervasyon
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=biletdb;Integrated Security=True");

        private void AddUser_Load(object sender, EventArgs e)
        {

        }


        private void button12_Click(object sender, EventArgs e)
        {
            if (textad.Text.Contains(" ") || textsoyad.Text.Contains(" ") || textid.Text.Contains(" ") || textmail.Text.Contains(" ") || textpass.Text.Contains(" ") || textpass2.Text.Contains(" ")) MessageBox.Show("Girilen bilgiler boşluk içeremez", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (textad.Text.Length == 0 || textsoyad.Text.Length == 0 || textid.Text.Length == 0 || textpass.Text.Length == 0 || textmail.Text.Length == 0 || textpass2.Text.Length == 0) MessageBox.Show("Lütfen tüm boşlukları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (textid.Text.Length < 3 || textpass.Text.Length < 3 || textmail.Text.Length < 3) MessageBox.Show("Kullanıcı adı ,şifre ve email en az 3 karakter uzunluğunda olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (textpass.Text != textpass2.Text) MessageBox.Show("Girdiğiniz 2 şifre aynı olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (MessageBox.Show("Girdiğiniz bilgilerin doğruluğunu onaylıyor musunuz ?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    baglanti.Open();
                    SqlCommand cmd = new SqlCommand("select * from admin where email LIKE '" + textmail.Text + "' ", baglanti);
                    SqlDataReader Daread = cmd.ExecuteReader();

                    if (Daread.Read())
                    {
                        MessageBox.Show("Bu kullanıcı adı ya da mail zaten alınmış");
                        baglanti.Close();
                        Daread.Close();
                    }
                    else
                    {
                        Daread.Close();
                        giris();
                    }


                }

            }

        }
        private void giris()
        {
            try
            {
                using (SqlCommand ekle = new SqlCommand(@"insert into admin (role, username, password, ad, soyad, email) values  (@role, @username, @password, @ad, @soyad, @email)", baglanti))
                {
                    ekle.Parameters.Add("username", SqlDbType.NVarChar).Value = textid.Text;
                    ekle.Parameters.Add("@password", SqlDbType.NVarChar).Value = textpass.Text;
                    ekle.Parameters.Add("@ad", SqlDbType.NVarChar).Value = textad.Text;
                    ekle.Parameters.Add("@soyad", SqlDbType.NVarChar).Value = textsoyad.Text;
                    ekle.Parameters.Add("@email", SqlDbType.NVarChar).Value = textmail.Text;
                    ekle.Parameters.Add("@role", SqlDbType.NVarChar).Value = textBox1.Text;
                    ekle.ExecuteNonQuery();
                    baglanti.Close();
                }
                MessageBox.Show("Başarıyla kayıt olundu!" + "\n" + "Giriş yapınız.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textad.Text = "";
                textsoyad.Text = "";
                textid.Text = "";
                textpass.Text = "";
                textmail.Text = "";
                textpass2.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Bu kullanıcı adı ya da mail zaten alınmış");
                baglanti.Close();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textpass2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textad_KeyPress(object sender, KeyPressEventArgs e) //harf
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textsoyad_KeyPress(object sender, KeyPressEventArgs e)//harf
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textid_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textpass2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsWhiteSpace(e.KeyChar);
        }
    }

}