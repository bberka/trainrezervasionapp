using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TrenBiletRezervasyon
{
    public partial class Loginscreen : Form
    {
        public Loginscreen()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=biletdb;Integrated Security=True");
        public static int acclvl = 0;
        public static string maildb = "";
        public static string addb = "";
        public static string soyaddb = "";
        public static string passdb = "";
        private void ValidateUser()
        {
            if (idtext.Text.Contains(" ") || passtext.Text.Contains(" ")) MessageBox.Show("Kullanıcı adı yada şifre boşluk içeremez", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (idtext.Text.Length == 0 || passtext.Text.Length == 0) MessageBox.Show("Kullanıcı adı yada şifrenizi giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                SqlCommand sqlcmd = new SqlCommand("SELECT role from admin WHERE username = @username and password = @password", baglanti);
                sqlcmd.Parameters.AddWithValue("@username", idtext.Text);
                sqlcmd.Parameters.AddWithValue("@password", passtext.Text);
                DataTable dtbl = new DataTable();

                SqlDataAdapter sqlsda = new SqlDataAdapter(sqlcmd);
                sqlsda.Fill(dtbl);

                baglanti.Close();
                if (dtbl.Rows.Count == 1)
                {
                    this.Hide();

                    baglanti.Open();
                    SqlDataAdapter da = new SqlDataAdapter("select * from admin where username like '" + idtext.Text + "%'", baglanti);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    maildb = dt.Rows[0].ItemArray[6].ToString();
                    addb = dt.Rows[0].ItemArray[4].ToString();
                    soyaddb = dt.Rows[0].ItemArray[5].ToString();
                    baglanti.Close();


                    if (dtbl.Rows[0]["role"].ToString().Equals("owner"))
                    {
                        passdb = passtext.Text;
                        acclvl = 2;
                        this.Close();
                        Application.OpenForms["homepage"].Width = 177;
                        Application.OpenForms["homepage"].Height = 369;
                        Application.OpenForms["homepage"].Hide();
                        //MessageBox.Show("Sahip olarak giriş yaptınız");
                        baglanti.Close();
                        nloginfrm log = new nloginfrm();
                        log.Show();

                    }
                    else if (dtbl.Rows[0]["role"].ToString().Equals("admin"))
                    {
                        passdb = passtext.Text;
                        acclvl = 1;
                        this.Close();
                        Application.OpenForms["homepage"].Width = 177;
                        Application.OpenForms["homepage"].Height = 369;
                        Application.OpenForms["homepage"].Hide();
                        //MessageBox.Show("Admin olarak giriş yaptınız");
                        nloginfrm log = new nloginfrm();
                        log.Show();
                        baglanti.Close();

                    }
                    else
                    {
                        passdb = passtext.Text;
                        acclvl = 0;
                        this.Close();
                        Application.OpenForms["homepage"].Width = 177;
                        Application.OpenForms["homepage"].Height = 369;
                        Application.OpenForms["homepage"].Hide();
                        //MessageBox.Show("Kullanıcı olarak giriş yaptınız");
                        nloginfrm log = new nloginfrm();
                        log.Show();
                        baglanti.Close();

                    }
                }
                else
                {
                    MessageBox.Show("Şifre ya da kullanıcı adı yanlış", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }



        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

            ValidateUser();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void Loginscreen_Load(object sender, EventArgs e)
        {

        }

        private void idtext_TextChanged(object sender, EventArgs e)
        {

        }

        private void idtext_KeyPress(object sender, KeyPressEventArgs e) //sayı harf silme enable
        {
            e.Handled = !char.IsNumber(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void passtext_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
