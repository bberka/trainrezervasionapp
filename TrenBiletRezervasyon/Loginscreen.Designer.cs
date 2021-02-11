namespace TrenBiletRezervasyon
{
    partial class Loginscreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loginscreen));
            this.idtext = new System.Windows.Forms.TextBox();
            this.passtext = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.pictureBoxlogin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxlogin)).BeginInit();
            this.SuspendLayout();
            // 
            // idtext
            // 
            this.idtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.idtext.Location = new System.Drawing.Point(84, 152);
            this.idtext.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.idtext.MaxLength = 25;
            this.idtext.Name = "idtext";
            this.idtext.Size = new System.Drawing.Size(185, 26);
            this.idtext.TabIndex = 1;
            this.idtext.TextChanged += new System.EventHandler(this.idtext_TextChanged);
            this.idtext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.idtext_KeyPress);
            // 
            // passtext
            // 
            this.passtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passtext.Location = new System.Drawing.Point(84, 214);
            this.passtext.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.passtext.MaxLength = 25;
            this.passtext.Name = "passtext";
            this.passtext.PasswordChar = '*';
            this.passtext.Size = new System.Drawing.Size(185, 26);
            this.passtext.TabIndex = 2;
            this.passtext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passtext_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(141, 188);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 24);
            this.label6.TabIndex = 17;
            this.label6.Text = "SIFRE:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(87, 123);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "KULLANICI ADI:";
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.LightBlue;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button12.Image = ((System.Drawing.Image)(resources.GetObject("button12.Image")));
            this.button12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button12.Location = new System.Drawing.Point(15, 260);
            this.button12.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(310, 64);
            this.button12.TabIndex = 3;
            this.button12.Text = "GIRIS YAP     ";
            this.button12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // pictureBoxlogin
            // 
            this.pictureBoxlogin.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxlogin.Image")));
            this.pictureBoxlogin.Location = new System.Drawing.Point(135, 12);
            this.pictureBoxlogin.Name = "pictureBoxlogin";
            this.pictureBoxlogin.Size = new System.Drawing.Size(82, 100);
            this.pictureBoxlogin.TabIndex = 0;
            this.pictureBoxlogin.TabStop = false;
            // 
            // Loginscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(344, 340);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.passtext);
            this.Controls.Add(this.idtext);
            this.Controls.Add(this.pictureBoxlogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Loginscreen";
            this.Text = "Admin Giriş";
            this.Load += new System.EventHandler(this.Loginscreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxlogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxlogin;
        private System.Windows.Forms.TextBox idtext;
        private System.Windows.Forms.TextBox passtext;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button12;
    }
}