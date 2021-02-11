namespace TrenBiletRezervasyon
{
    partial class AdminList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminList));
            this.adminlistgrid = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textuser = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.adminlistgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // adminlistgrid
            // 
            this.adminlistgrid.AllowUserToAddRows = false;
            this.adminlistgrid.AllowUserToDeleteRows = false;
            this.adminlistgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminlistgrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.role,
            this.username,
            this.password,
            this.ad,
            this.soyad,
            this.email});
            this.adminlistgrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.adminlistgrid.Location = new System.Drawing.Point(0, 0);
            this.adminlistgrid.Name = "adminlistgrid";
            this.adminlistgrid.ReadOnly = true;
            this.adminlistgrid.Size = new System.Drawing.Size(639, 325);
            this.adminlistgrid.TabIndex = 0;
            this.adminlistgrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.adminlistgrid_CellClick);
            this.adminlistgrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.adminlistgrid_CellContentClick);
            this.adminlistgrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.adminlistgrid_CellEndEdit);
            this.adminlistgrid.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.adminlistgrid_CellValidating);
            this.adminlistgrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.adminlistgrid_CellValueChanged);
            this.adminlistgrid.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.adminlistgrid_RowPostPaint);
            this.adminlistgrid.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.adminlistgrid_RowPrePaint);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightGray;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(150, 414);
            this.button4.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(294, 52);
            this.button4.TabIndex = 50;
            this.button4.Text = "    GERİ DÖN";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(15, 340);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(314, 52);
            this.button1.TabIndex = 51;
            this.button1.Text = "     SEÇİLENİ SİL";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textuser
            // 
            this.textuser.Enabled = false;
            this.textuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textuser.Location = new System.Drawing.Point(1224, 48);
            this.textuser.Name = "textuser";
            this.textuser.Size = new System.Drawing.Size(10, 10);
            this.textuser.TabIndex = 52;
            this.textuser.Text = "user";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LightBlue;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(348, 340);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(276, 52);
            this.btnUpdate.TabIndex = 53;
            this.btnUpdate.Text = "GÜNCELLE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.button2_Click);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id.Width = 40;
            // 
            // role
            // 
            this.role.DataPropertyName = "role";
            this.role.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.role.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.role.HeaderText = "Rol";
            this.role.Items.AddRange(new object[] {
            "user",
            "admin",
            "owner"});
            this.role.Name = "role";
            this.role.ReadOnly = true;
            this.role.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.role.Width = 60;
            // 
            // username
            // 
            this.username.DataPropertyName = "username";
            this.username.HeaderText = "Kullanıcı Adı";
            this.username.Name = "username";
            this.username.ReadOnly = true;
            this.username.Width = 90;
            // 
            // password
            // 
            this.password.DataPropertyName = "password";
            this.password.HeaderText = "Şifre";
            this.password.Name = "password";
            this.password.ReadOnly = true;
            this.password.Width = 80;
            // 
            // ad
            // 
            this.ad.DataPropertyName = "ad";
            this.ad.HeaderText = "Ad";
            this.ad.Name = "ad";
            this.ad.ReadOnly = true;
            this.ad.Width = 80;
            // 
            // soyad
            // 
            this.soyad.DataPropertyName = "soyad";
            this.soyad.HeaderText = "Soyad";
            this.soyad.Name = "soyad";
            this.soyad.ReadOnly = true;
            this.soyad.Width = 80;
            // 
            // email
            // 
            this.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // AdminList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(639, 405);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.textuser);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.adminlistgrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminList";
            this.Text = "Kullanıcı Liste";
            this.Load += new System.EventHandler(this.AdminList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adminlistgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView adminlistgrid;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textuser;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewComboBoxColumn role;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
    }
}