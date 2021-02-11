using System;
using System.Drawing;
using System.Windows.Forms;

namespace TrenBiletRezervasyon
{
    public partial class nloginfrm : Form
    {
        public nloginfrm()
        {
            InitializeComponent();

        }

        private void tusenable()
        {
            btnRzvYap.Enabled = true;
            btnAdmListe.Enabled = true;
            btnSatisList.Enabled = true;
            btnAdmListe.BackColor = Color.Teal;
            btnRzvYap.BackColor = Color.Teal;
            btnSatisList.BackColor = Color.Teal;
            buttonBiletSatilan.Enabled = true;
            buttonBiletSatilan.BackColor = Color.Teal;
            buttoninfo.Enabled = true;
            buttoninfo.BackColor = Color.Teal;

        }
        private void acclvlcheck()
        {
            this.Width = 195;
            if (Loginscreen.acclvl == 1) //admin
            {
                btnAdmListe.Enabled = true;
                btnSatisList.Enabled = true;
                buttonBiletSatilan.Visible = false;
                this.Height = 370 + 60;

            }

            else if (Loginscreen.acclvl == 2) //owner
            {
                btnAdmListe.Visible = true;
                btnSatisList.Visible = true;
                buttonBiletSatilan.Visible = false;
                this.Height = 370 + 60;
            }
            else if (Loginscreen.acclvl == 0)//User
            {
                btnAdmListe.Visible = false;
                btnSatisList.Visible = false;
                buttonBiletSatilan.Visible = true;
                this.Height = 312 + 60;
            }
        }
        private void nloginfrm_Load(object sender, EventArgs e)
        {
            acclvlcheck();


        }
        private Form activeForm = null;
        public void openfrm(Form childform)
        {
            if (activeForm != null) activeForm.Hide();

            activeForm = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panelContain.Controls.Add(childform);
            panelContain.Tag = childform;
            childform.BringToFront();
            childform.Show();

        }

        private void btnRzvYap_Click(object sender, EventArgs e)
        {
            tusenable();
            openfrm(new Satis());
            this.Width = 1005 + 180;
            this.Height = 502;
            btnRzvYap.BackColor = Color.Turquoise;
            btnRzvYap.Enabled = false;

        }

        private void btnSatisList_Click(object sender, EventArgs e)
        {
            tusenable();
            openfrm(new SatisListe());
            this.Width = 1345 + 188;
            this.Height = 473;
            btnSatisList.Enabled = false;
            btnSatisList.BackColor = Color.Turquoise;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (activeForm != null) activeForm.Close();
            acclvlcheck();
            tusenable();
        }


        private void btnAdmListe_Click(object sender, EventArgs e)
        {
            tusenable();
            openfrm(new AdminList());
            this.Width = 645 + 188;
            this.Height = 370 + 60;
            btnAdmListe.Enabled = false;
            btnAdmListe.BackColor = Color.Turquoise;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Çıkış yapmak istediğinize emin misiniz ?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                Application.OpenForms["homepage"].Show();
                Loginscreen.acclvl = 0;
                acclvlcheck();
                Satis.a = false;
                Loginscreen.passdb = "";
                Loginscreen.maildb = "";
                Loginscreen.addb = "";
                Loginscreen.soyaddb = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openfrm(new Biletİptal());
            this.Width = 860 + 170;
            this.Height = 429;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            tusenable();
            buttonBiletSatilan.Enabled = false;
            buttonBiletSatilan.BackColor = Color.Turquoise;
            openfrm(new Biletİptal());
            this.Width = 853 + 195;
            this.Height = 372;

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            tusenable();
            buttoninfo.Enabled = false;
            buttoninfo.BackColor = Color.Turquoise;
            openfrm(new PassChange());
            this.Width = 356 + 195;
            this.Height = 370 + 60;
        }
    }



}
