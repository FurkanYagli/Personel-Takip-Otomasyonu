namespace DapperCrud
{
    partial class FrmAnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaSayfa));
            this.simpleButtonKullaniciOlustur = new DevExpress.XtraEditors.SimpleButton();
            this.BtnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSistemAyarları = new DevExpress.XtraEditors.SimpleButton();
            this.BtnPersonelEkle = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // simpleButtonKullaniciOlustur
            // 
            this.simpleButtonKullaniciOlustur.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButtonKullaniciOlustur.Appearance.Options.UseFont = true;
            this.simpleButtonKullaniciOlustur.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.simpleButtonKullaniciOlustur.ImageOptions.Image = global::DapperCrud.Properties.Resources.icons8_Add_Male_User_Group;
            this.simpleButtonKullaniciOlustur.Location = new System.Drawing.Point(453, 324);
            this.simpleButtonKullaniciOlustur.Name = "simpleButtonKullaniciOlustur";
            this.simpleButtonKullaniciOlustur.Size = new System.Drawing.Size(295, 235);
            this.simpleButtonKullaniciOlustur.TabIndex = 3;
            this.simpleButtonKullaniciOlustur.Text = "Kullanıcı Oluştur";
            this.simpleButtonKullaniciOlustur.Click += new System.EventHandler(this.simpleButtonKullaniciOlustur_Click);
            // 
            // BtnKapat
            // 
            this.BtnKapat.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.BtnKapat.ImageOptions.Image = global::DapperCrud.Properties.Resources.icons8_cancel;
            this.BtnKapat.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.BtnKapat.Location = new System.Drawing.Point(1080, -1);
            this.BtnKapat.Name = "BtnKapat";
            this.BtnKapat.Size = new System.Drawing.Size(117, 122);
            this.BtnKapat.TabIndex = 2;
            this.BtnKapat.Text = "BtnKapat";
            this.BtnKapat.Click += new System.EventHandler(this.BtnKapat_Click);
            // 
            // BtnSistemAyarları
            // 
            this.BtnSistemAyarları.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSistemAyarları.Appearance.Options.UseFont = true;
            this.BtnSistemAyarları.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.BtnSistemAyarları.ImageOptions.Image = global::DapperCrud.Properties.Resources.icons8_administrative_tools_5;
            this.BtnSistemAyarları.Location = new System.Drawing.Point(658, 74);
            this.BtnSistemAyarları.Name = "BtnSistemAyarları";
            this.BtnSistemAyarları.Size = new System.Drawing.Size(295, 235);
            this.BtnSistemAyarları.TabIndex = 1;
            this.BtnSistemAyarları.Text = "Sistem Ayarları";
            this.BtnSistemAyarları.Click += new System.EventHandler(this.BtnSistemAyarları_Click);
            // 
            // BtnPersonelEkle
            // 
            this.BtnPersonelEkle.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnPersonelEkle.Appearance.Options.UseFont = true;
            this.BtnPersonelEkle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.BtnPersonelEkle.ImageOptions.Image = global::DapperCrud.Properties.Resources.icons8_add_administrator;
            this.BtnPersonelEkle.Location = new System.Drawing.Point(248, 74);
            this.BtnPersonelEkle.Name = "BtnPersonelEkle";
            this.BtnPersonelEkle.Size = new System.Drawing.Size(295, 235);
            this.BtnPersonelEkle.TabIndex = 0;
            this.BtnPersonelEkle.Text = "Personel Ekle";
            this.BtnPersonelEkle.Click += new System.EventHandler(this.BtnPersonelEkle_Click);
            // 
            // FrmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(59)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(1200, 633);
            this.Controls.Add(this.simpleButtonKullaniciOlustur);
            this.Controls.Add(this.BtnKapat);
            this.Controls.Add(this.BtnSistemAyarları);
            this.Controls.Add(this.BtnPersonelEkle);
            this.Font = new System.Drawing.Font("Corbel", 13.8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmAnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.FrmAnaSayfa_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton BtnPersonelEkle;
        private DevExpress.XtraEditors.SimpleButton BtnSistemAyarları;
        private DevExpress.XtraEditors.SimpleButton BtnKapat;
        private DevExpress.XtraEditors.SimpleButton simpleButtonKullaniciOlustur;
    }
}