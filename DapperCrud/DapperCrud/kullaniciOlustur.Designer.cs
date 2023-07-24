namespace DapperCrud
{
    partial class kullaniciOlustur
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
            this.TxtAktiflikDurumu = new System.Windows.Forms.TextBox();
            this.LblAktiflikDurumu = new System.Windows.Forms.Label();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.LblSoyad = new System.Windows.Forms.Label();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.LblAd = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.LblId = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.BtnAnaSayfa = new DevExpress.XtraEditors.SimpleButton();
            this.BtnAdmin = new System.Windows.Forms.RadioButton();
            this.BtnYetkisiz = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtTc = new System.Windows.Forms.MaskedTextBox();
            this.TxtTel = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnAktifEt = new System.Windows.Forms.Button();
            this.LblKullaniciTuru = new System.Windows.Forms.Label();
            this.BtnSuperAdmin = new System.Windows.Forms.Button();
            this.BtnSuper = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtAktiflikDurumu
            // 
            this.TxtAktiflikDurumu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtAktiflikDurumu.BackColor = System.Drawing.Color.White;
            this.TxtAktiflikDurumu.ForeColor = System.Drawing.Color.Black;
            this.TxtAktiflikDurumu.Location = new System.Drawing.Point(1105, 334);
            this.TxtAktiflikDurumu.Name = "TxtAktiflikDurumu";
            this.TxtAktiflikDurumu.Size = new System.Drawing.Size(71, 36);
            this.TxtAktiflikDurumu.TabIndex = 42;
            // 
            // LblAktiflikDurumu
            // 
            this.LblAktiflikDurumu.AutoSize = true;
            this.LblAktiflikDurumu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblAktiflikDurumu.Location = new System.Drawing.Point(929, 333);
            this.LblAktiflikDurumu.Name = "LblAktiflikDurumu";
            this.LblAktiflikDurumu.Size = new System.Drawing.Size(170, 29);
            this.LblAktiflikDurumu.TabIndex = 41;
            this.LblAktiflikDurumu.Text = "Aktiflik Durumu";
            // 
            // BtnSil
            // 
            this.BtnSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSil.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnSil.Location = new System.Drawing.Point(950, 518);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(220, 56);
            this.BtnSil.TabIndex = 36;
            this.BtnSil.Text = "&Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGuncelle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnGuncelle.Location = new System.Drawing.Point(330, 518);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(220, 56);
            this.BtnGuncelle.TabIndex = 35;
            this.BtnGuncelle.Text = "&Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnEkle
            // 
            this.BtnEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEkle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnEkle.Location = new System.Drawing.Point(12, 519);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(220, 56);
            this.BtnEkle.TabIndex = 34;
            this.BtnEkle.Text = "&Ekle";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSoyad.Location = new System.Drawing.Point(239, 339);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(684, 36);
            this.TxtSoyad.TabIndex = 29;
            // 
            // LblSoyad
            // 
            this.LblSoyad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LblSoyad.AutoSize = true;
            this.LblSoyad.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold);
            this.LblSoyad.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblSoyad.Location = new System.Drawing.Point(126, 334);
            this.LblSoyad.Name = "LblSoyad";
            this.LblSoyad.Size = new System.Drawing.Size(107, 37);
            this.LblSoyad.TabIndex = 28;
            this.LblSoyad.Text = "Soyad:";
            // 
            // TxtAd
            // 
            this.TxtAd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtAd.Location = new System.Drawing.Point(239, 297);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(684, 36);
            this.TxtAd.TabIndex = 27;
            // 
            // LblAd
            // 
            this.LblAd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LblAd.AutoSize = true;
            this.LblAd.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold);
            this.LblAd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblAd.Location = new System.Drawing.Point(170, 292);
            this.LblAd.Name = "LblAd";
            this.LblAd.Size = new System.Drawing.Size(63, 37);
            this.LblAd.TabIndex = 26;
            this.LblAd.Text = "Ad:";
            // 
            // TxtId
            // 
            this.TxtId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtId.BackColor = System.Drawing.Color.White;
            this.TxtId.ForeColor = System.Drawing.Color.Transparent;
            this.TxtId.Location = new System.Drawing.Point(1097, 270);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(71, 36);
            this.TxtId.TabIndex = 25;
            // 
            // LblId
            // 
            this.LblId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LblId.AutoSize = true;
            this.LblId.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold);
            this.LblId.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblId.Location = new System.Drawing.Point(1042, 265);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(51, 37);
            this.LblId.TabIndex = 24;
            this.LblId.Text = "Id:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1035, 287);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // BtnKapat
            // 
            this.BtnKapat.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.BtnKapat.ImageOptions.Image = global::DapperCrud.Properties.Resources.icons8_cancel;
            this.BtnKapat.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.BtnKapat.Location = new System.Drawing.Point(1034, -6);
            this.BtnKapat.Name = "BtnKapat";
            this.BtnKapat.Size = new System.Drawing.Size(156, 144);
            this.BtnKapat.TabIndex = 40;
            this.BtnKapat.Text = "BtnKapat";
            this.BtnKapat.Click += new System.EventHandler(this.BtnKapat_Click);
            // 
            // BtnAnaSayfa
            // 
            this.BtnAnaSayfa.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold);
            this.BtnAnaSayfa.Appearance.Options.UseFont = true;
            this.BtnAnaSayfa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.BtnAnaSayfa.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnAnaSayfa.ImageOptions.Image = global::DapperCrud.Properties.Resources.icons8_house;
            this.BtnAnaSayfa.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.BtnAnaSayfa.Location = new System.Drawing.Point(1034, 136);
            this.BtnAnaSayfa.Name = "BtnAnaSayfa";
            this.BtnAnaSayfa.Size = new System.Drawing.Size(156, 136);
            this.BtnAnaSayfa.TabIndex = 37;
            this.BtnAnaSayfa.Text = "Ana Sayfa";
            this.BtnAnaSayfa.Click += new System.EventHandler(this.BtnAnaSayfa_Click);
            // 
            // BtnAdmin
            // 
            this.BtnAdmin.AutoSize = true;
            this.BtnAdmin.Location = new System.Drawing.Point(21, 35);
            this.BtnAdmin.Name = "BtnAdmin";
            this.BtnAdmin.Size = new System.Drawing.Size(101, 33);
            this.BtnAdmin.TabIndex = 44;
            this.BtnAdmin.Text = "Admin";
            this.BtnAdmin.UseVisualStyleBackColor = true;
            // 
            // BtnYetkisiz
            // 
            this.BtnYetkisiz.AutoSize = true;
            this.BtnYetkisiz.Location = new System.Drawing.Point(21, 65);
            this.BtnYetkisiz.Name = "BtnYetkisiz";
            this.BtnYetkisiz.Size = new System.Drawing.Size(74, 33);
            this.BtnYetkisiz.TabIndex = 45;
            this.BtnYetkisiz.Text = "Üye";
            this.BtnYetkisiz.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(170, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 37);
            this.label1.TabIndex = 46;
            this.label1.Text = "TC:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(166, 419);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 37);
            this.label2.TabIndex = 48;
            this.label2.Text = "Tel:";
            // 
            // TxtTc
            // 
            this.TxtTc.Location = new System.Drawing.Point(239, 381);
            this.TxtTc.Mask = "00000000000";
            this.TxtTc.Name = "TxtTc";
            this.TxtTc.Size = new System.Drawing.Size(684, 36);
            this.TxtTc.TabIndex = 50;
            this.TxtTc.ValidatingType = typeof(int);
            // 
            // TxtTel
            // 
            this.TxtTel.Location = new System.Drawing.Point(239, 423);
            this.TxtTel.Mask = "00000000000";
            this.TxtTel.Name = "TxtTel";
            this.TxtTel.Size = new System.Drawing.Size(684, 36);
            this.TxtTel.TabIndex = 51;
            this.TxtTel.ValidatingType = typeof(int);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnSuper);
            this.groupBox1.Controls.Add(this.BtnYetkisiz);
            this.groupBox1.Controls.Add(this.BtnAdmin);
            this.groupBox1.Location = new System.Drawing.Point(571, 465);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 110);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı Türü";
            // 
            // BtnAktifEt
            // 
            this.BtnAktifEt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAktifEt.BackColor = System.Drawing.Color.Transparent;
            this.BtnAktifEt.ForeColor = System.Drawing.Color.Black;
            this.BtnAktifEt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnAktifEt.Location = new System.Drawing.Point(1087, 440);
            this.BtnAktifEt.Name = "BtnAktifEt";
            this.BtnAktifEt.Size = new System.Drawing.Size(83, 72);
            this.BtnAktifEt.TabIndex = 54;
            this.BtnAktifEt.Text = "Aktif Et";
            this.BtnAktifEt.UseVisualStyleBackColor = false;
            this.BtnAktifEt.Click += new System.EventHandler(this.BtnAktifEt_Click);
            // 
            // LblKullaniciTuru
            // 
            this.LblKullaniciTuru.AutoSize = true;
            this.LblKullaniciTuru.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblKullaniciTuru.Location = new System.Drawing.Point(998, 388);
            this.LblKullaniciTuru.Name = "LblKullaniciTuru";
            this.LblKullaniciTuru.Size = new System.Drawing.Size(170, 29);
            this.LblKullaniciTuru.TabIndex = 55;
            this.LblKullaniciTuru.Text = "Aktiflik Durumu";
            // 
            // BtnSuperAdmin
            // 
            this.BtnSuperAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSuperAdmin.BackColor = System.Drawing.Color.Transparent;
            this.BtnSuperAdmin.ForeColor = System.Drawing.Color.Black;
            this.BtnSuperAdmin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnSuperAdmin.Location = new System.Drawing.Point(12, 441);
            this.BtnSuperAdmin.Name = "BtnSuperAdmin";
            this.BtnSuperAdmin.Size = new System.Drawing.Size(95, 72);
            this.BtnSuperAdmin.TabIndex = 56;
            this.BtnSuperAdmin.Text = "Süper Admin Oluştur";
            this.BtnSuperAdmin.UseVisualStyleBackColor = false;
            this.BtnSuperAdmin.Click += new System.EventHandler(this.BtnSuperAdmin_Click);
            // 
            // BtnSuper
            // 
            this.BtnSuper.AutoSize = true;
            this.BtnSuper.Location = new System.Drawing.Point(143, 48);
            this.BtnSuper.Name = "BtnSuper";
            this.BtnSuper.Size = new System.Drawing.Size(163, 33);
            this.BtnSuper.TabIndex = 46;
            this.BtnSuper.Text = "Süper Admin";
            this.BtnSuper.UseVisualStyleBackColor = true;
            // 
            // kullaniciOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(59)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(1182, 587);
            this.Controls.Add(this.BtnSuperAdmin);
            this.Controls.Add(this.LblKullaniciTuru);
            this.Controls.Add(this.BtnAktifEt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TxtTel);
            this.Controls.Add(this.TxtTc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtAktiflikDurumu);
            this.Controls.Add(this.LblAktiflikDurumu);
            this.Controls.Add(this.BtnKapat);
            this.Controls.Add(this.BtnAnaSayfa);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.TxtSoyad);
            this.Controls.Add(this.LblSoyad);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.LblAd);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.LblId);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "kullaniciOlustur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "kullaniciOlustur";
            this.Load += new System.EventHandler(this.kullaniciOlustur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtAktiflikDurumu;
        private System.Windows.Forms.Label LblAktiflikDurumu;
        private DevExpress.XtraEditors.SimpleButton BtnKapat;
        private DevExpress.XtraEditors.SimpleButton BtnAnaSayfa;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.Label LblSoyad;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Label LblAd;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton BtnAdmin;
        private System.Windows.Forms.RadioButton BtnYetkisiz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox TxtTc;
        private System.Windows.Forms.MaskedTextBox TxtTel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnAktifEt;
        private System.Windows.Forms.Label LblKullaniciTuru;
        private System.Windows.Forms.Button BtnSuperAdmin;
        private System.Windows.Forms.RadioButton BtnSuper;
    }
}