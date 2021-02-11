namespace TrenBiletRezervasyon
{
    partial class PassChange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PassChange));
            this.label3 = new System.Windows.Forms.Label();
            this.oldpasstext = new System.Windows.Forms.TextBox();
            this.newpasstext = new System.Windows.Forms.TextBox();
            this.newpasstext2 = new System.Windows.Forms.TextBox();
            this.labelmail = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonSorgu = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(15, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 24);
            this.label3.TabIndex = 28;
            this.label3.Text = "AD SOYAD:";
            // 
            // oldpasstext
            // 
            this.oldpasstext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.oldpasstext.Location = new System.Drawing.Point(169, 188);
            this.oldpasstext.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.oldpasstext.MaxLength = 25;
            this.oldpasstext.Name = "oldpasstext";
            this.oldpasstext.PasswordChar = '*';
            this.oldpasstext.Size = new System.Drawing.Size(172, 26);
            this.oldpasstext.TabIndex = 27;
            this.oldpasstext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.oldpasstext_KeyPress);
            // 
            // newpasstext
            // 
            this.newpasstext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.newpasstext.Location = new System.Drawing.Point(169, 235);
            this.newpasstext.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.newpasstext.MaxLength = 25;
            this.newpasstext.Name = "newpasstext";
            this.newpasstext.PasswordChar = '*';
            this.newpasstext.Size = new System.Drawing.Size(172, 26);
            this.newpasstext.TabIndex = 29;
            this.newpasstext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.newpasstext_KeyPress);
            // 
            // newpasstext2
            // 
            this.newpasstext2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.newpasstext2.Location = new System.Drawing.Point(169, 281);
            this.newpasstext2.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.newpasstext2.MaxLength = 25;
            this.newpasstext2.Name = "newpasstext2";
            this.newpasstext2.PasswordChar = '*';
            this.newpasstext2.Size = new System.Drawing.Size(172, 26);
            this.newpasstext2.TabIndex = 31;
            this.newpasstext2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.newpasstext2_KeyPress);
            // 
            // labelmail
            // 
            this.labelmail.AutoSize = true;
            this.labelmail.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelmail.Location = new System.Drawing.Point(97, 130);
            this.labelmail.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelmail.Name = "labelmail";
            this.labelmail.Size = new System.Drawing.Size(22, 24);
            this.labelmail.TabIndex = 34;
            this.labelmail.Text = "X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(15, 237);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 24);
            this.label5.TabIndex = 35;
            this.label5.Text = "YENİ ŞİFRE:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(15, 190);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 24);
            this.label6.TabIndex = 36;
            this.label6.Text = "ESKİ ŞİFRE:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(15, 283);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 24);
            this.label7.TabIndex = 37;
            this.label7.Text = "YENİ ŞİFRE:";
            // 
            // buttonSorgu
            // 
            this.buttonSorgu.BackColor = System.Drawing.Color.LightBlue;
            this.buttonSorgu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSorgu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSorgu.Image = ((System.Drawing.Image)(resources.GetObject("buttonSorgu.Image")));
            this.buttonSorgu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSorgu.Location = new System.Drawing.Point(19, 326);
            this.buttonSorgu.Name = "buttonSorgu";
            this.buttonSorgu.Size = new System.Drawing.Size(322, 63);
            this.buttonSorgu.TabIndex = 58;
            this.buttonSorgu.Text = "ŞİFREYİ GÜNCELLE       ";
            this.buttonSorgu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSorgu.UseVisualStyleBackColor = false;
            this.buttonSorgu.Click += new System.EventHandler(this.buttonSorgu_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(59, 9);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(240, 32);
            this.label10.TabIndex = 59;
            this.label10.Text = "HESAP BİLGİLERİ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(15, 130);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 60;
            this.label1.Text = "EMAIL:";
            // 
            // labelad
            // 
            this.labelad.AutoSize = true;
            this.labelad.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelad.Location = new System.Drawing.Point(145, 80);
            this.labelad.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelad.Name = "labelad";
            this.labelad.Size = new System.Drawing.Size(22, 24);
            this.labelad.TabIndex = 61;
            this.labelad.Text = "X";
            // 
            // PassChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(356, 401);
            this.Controls.Add(this.labelad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.buttonSorgu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelmail);
            this.Controls.Add(this.newpasstext2);
            this.Controls.Add(this.newpasstext);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.oldpasstext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PassChange";
            this.ShowIcon = false;
            this.Text = "PassChange";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox oldpasstext;
        private System.Windows.Forms.TextBox newpasstext;
        private System.Windows.Forms.TextBox newpasstext2;
        private System.Windows.Forms.Label labelmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonSorgu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelad;
    }
}