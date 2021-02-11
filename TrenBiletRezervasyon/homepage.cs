using System;
using System.Drawing;
using System.Windows.Forms;

namespace TrenBiletRezervasyon
{
    public partial class homepage : Form
    {
        public homepage()
        {
            InitializeComponent();
        }
        private Form activeFormm = null;

        public void tusenable2()
        {
            this.buttonLogin.Enabled = true;
            this.buttonRegister.Enabled = true;
            this.buttonHelp.Enabled = true;
            this.buttonLogin.BackColor = Color.Teal;
            this.buttonRegister.BackColor = Color.Teal;
            this.buttonHelp.BackColor = Color.Teal;
        }
        private void openfrm(Form childform)
        {
            if (activeFormm != null) activeFormm.Hide();

            activeFormm = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panelCenter.Controls.Add(childform);
            panelCenter.Tag = childform;
            childform.BringToFront();
            childform.Show();

        }
        private void homepage_Load(object sender, EventArgs e)
        {


        }

        private void btnRzvYap_Click(object sender, EventArgs e)
        {
            tusenable2();
            openfrm(new Loginscreen());
            this.Width = 340 + 177;
            this.Height = 349 + 20;
            buttonLogin.Enabled = false;
            buttonLogin.BackColor = Color.Turquoise;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tusenable2();
            openfrm(new AddUser());
            this.Width = 400 + 177;
            //this.Height = 431+30;
            buttonRegister.Enabled = false;
            buttonRegister.BackColor = Color.Turquoise;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tusenable2();
            if (activeFormm != null) activeFormm.Close();
            this.Width = 177;
            this.Height = 369;

        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            tusenable2();
            if (activeFormm != null) activeFormm.Hide();
            this.Width = 660;
            this.Height = 369;
            buttonHelp.Enabled = false;
            buttonHelp.BackColor = Color.Turquoise;

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void timerbtn_Tick(object sender, EventArgs e)
        {
            if (Application.OpenForms["homepage"].Visible == false)
            {
                tusenable2();
            }
            else
            {

            }
        }
    }
}
