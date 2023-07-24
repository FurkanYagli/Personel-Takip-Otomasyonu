namespace DapperCrud
{
    partial class FrmPersonel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonel));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.LblAd = new System.Windows.Forms.Label();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.LblSoyad = new System.Windows.Forms.Label();
            this.LblSehir = new System.Windows.Forms.Label();
            this.LblMeslek = new System.Windows.Forms.Label();
            this.TxtMaas = new System.Windows.Forms.TextBox();
            this.LblMaas = new System.Windows.Forms.Label();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.LblId = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.BtnAnaSayfa = new DevExpress.XtraEditors.SimpleButton();
            this.comboBoxSehir = new System.Windows.Forms.ComboBox();
            this.comboBoxMeslek = new System.Windows.Forms.ComboBox();
            this.BtnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.LblAktiflikDurumu = new System.Windows.Forms.Label();
            this.TxtAktiflikDurumu = new System.Windows.Forms.TextBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.BtnClose = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.BtnAktiflik = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // TxtAd
            // 
            resources.ApplyResources(this.TxtAd, "TxtAd");
            this.TxtAd.Name = "TxtAd";
            // 
            // LblAd
            // 
            resources.ApplyResources(this.LblAd, "LblAd");
            this.LblAd.Name = "LblAd";
            // 
            // TxtSoyad
            // 
            resources.ApplyResources(this.TxtSoyad, "TxtSoyad");
            this.TxtSoyad.Name = "TxtSoyad";
            // 
            // LblSoyad
            // 
            resources.ApplyResources(this.LblSoyad, "LblSoyad");
            this.LblSoyad.Name = "LblSoyad";
            // 
            // LblSehir
            // 
            resources.ApplyResources(this.LblSehir, "LblSehir");
            this.LblSehir.Name = "LblSehir";
            // 
            // LblMeslek
            // 
            resources.ApplyResources(this.LblMeslek, "LblMeslek");
            this.LblMeslek.Name = "LblMeslek";
            // 
            // TxtMaas
            // 
            resources.ApplyResources(this.TxtMaas, "TxtMaas");
            this.TxtMaas.Name = "TxtMaas";
            this.TxtMaas.TextChanged += new System.EventHandler(this.TxtMaas_TextChanged);
            // 
            // LblMaas
            // 
            resources.ApplyResources(this.LblMaas, "LblMaas");
            this.LblMaas.Name = "LblMaas";
            // 
            // BtnEkle
            // 
            resources.ApplyResources(this.BtnEkle, "BtnEkle");
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click_1);
            // 
            // BtnGuncelle
            // 
            resources.ApplyResources(this.BtnGuncelle, "BtnGuncelle");
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click_1);
            // 
            // BtnSil
            // 
            resources.ApplyResources(this.BtnSil, "BtnSil");
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // LblId
            // 
            resources.ApplyResources(this.LblId, "LblId");
            this.LblId.Name = "LblId";
            // 
            // TxtId
            // 
            resources.ApplyResources(this.TxtId, "TxtId");
            this.TxtId.BackColor = System.Drawing.Color.White;
            this.TxtId.ForeColor = System.Drawing.Color.Transparent;
            this.TxtId.Name = "TxtId";
            this.TxtId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BtnAnaSayfa
            // 
            this.BtnAnaSayfa.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("BtnAnaSayfa.Appearance.Font")));
            this.BtnAnaSayfa.Appearance.Options.UseFont = true;
            this.BtnAnaSayfa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.BtnAnaSayfa.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnAnaSayfa.ImageOptions.Image = global::DapperCrud.Properties.Resources.icons8_house;
            this.BtnAnaSayfa.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            resources.ApplyResources(this.BtnAnaSayfa, "BtnAnaSayfa");
            this.BtnAnaSayfa.Name = "BtnAnaSayfa";
            this.BtnAnaSayfa.Click += new System.EventHandler(this.BtnAnaSayfa_Click);
            // 
            // comboBoxSehir
            // 
            this.comboBoxSehir.FormattingEnabled = true;
            resources.ApplyResources(this.comboBoxSehir, "comboBoxSehir");
            this.comboBoxSehir.Name = "comboBoxSehir";
            this.comboBoxSehir.SelectedIndexChanged += new System.EventHandler(this.comboBoxSehir_SelectedIndexChanged);
            // 
            // comboBoxMeslek
            // 
            this.comboBoxMeslek.FormattingEnabled = true;
            resources.ApplyResources(this.comboBoxMeslek, "comboBoxMeslek");
            this.comboBoxMeslek.Name = "comboBoxMeslek";
            this.comboBoxMeslek.SelectedIndexChanged += new System.EventHandler(this.comboBoxMeslek_SelectedIndexChanged);
            // 
            // BtnKapat
            // 
            this.BtnKapat.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.BtnKapat.ImageOptions.Image = global::DapperCrud.Properties.Resources.icons8_cancel;
            this.BtnKapat.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            resources.ApplyResources(this.BtnKapat, "BtnKapat");
            this.BtnKapat.Name = "BtnKapat";
            this.BtnKapat.Click += new System.EventHandler(this.BtnKapat_Click);
            // 
            // LblAktiflikDurumu
            // 
            resources.ApplyResources(this.LblAktiflikDurumu, "LblAktiflikDurumu");
            this.LblAktiflikDurumu.Name = "LblAktiflikDurumu";
            // 
            // TxtAktiflikDurumu
            // 
            resources.ApplyResources(this.TxtAktiflikDurumu, "TxtAktiflikDurumu");
            this.TxtAktiflikDurumu.BackColor = System.Drawing.Color.White;
            this.TxtAktiflikDurumu.ForeColor = System.Drawing.Color.Black;
            this.TxtAktiflikDurumu.Name = "TxtAktiflikDurumu";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.simpleButton1.ImageOptions.Image = global::DapperCrud.Properties.Resources.icons8_cancel;
            this.simpleButton1.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            resources.ApplyResources(this.simpleButton1, "simpleButton1");
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.BtnClose.ImageOptions.Image = global::DapperCrud.Properties.Resources.icons8_cancel;
            this.BtnClose.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            resources.ApplyResources(this.BtnClose, "BtnClose");
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.simpleButton2.ImageOptions.Image = global::DapperCrud.Properties.Resources.icons8_cancel;
            this.simpleButton2.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            resources.ApplyResources(this.simpleButton2, "simpleButton2");
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // BtnAktiflik
            // 
            resources.ApplyResources(this.BtnAktiflik, "BtnAktiflik");
            this.BtnAktiflik.Name = "BtnAktiflik";
            this.BtnAktiflik.UseVisualStyleBackColor = true;
            this.BtnAktiflik.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmPersonel
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(59)))), ((int)(((byte)(87)))));
            this.Controls.Add(this.BtnAktiflik);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.TxtAktiflikDurumu);
            this.Controls.Add(this.LblAktiflikDurumu);
            this.Controls.Add(this.comboBoxMeslek);
            this.Controls.Add(this.comboBoxSehir);
            this.Controls.Add(this.BtnAnaSayfa);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.TxtMaas);
            this.Controls.Add(this.LblMaas);
            this.Controls.Add(this.LblMeslek);
            this.Controls.Add(this.LblSehir);
            this.Controls.Add(this.TxtSoyad);
            this.Controls.Add(this.LblSoyad);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.LblAd);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.LblId);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPersonel";
            this.TransparencyKey = System.Drawing.Color.DarkGray;
            this.Load += new System.EventHandler(this.DapperCrud_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Label LblAd;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.Label LblSoyad;
        private System.Windows.Forms.Label LblSehir;
        private System.Windows.Forms.Label LblMeslek;
        private System.Windows.Forms.TextBox TxtMaas;
        private System.Windows.Forms.Label LblMaas;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.TextBox TxtId;
        private DevExpress.XtraEditors.SimpleButton BtnAnaSayfa;
        private System.Windows.Forms.ComboBox comboBoxSehir;
        private System.Windows.Forms.ComboBox comboBoxMeslek;
        private DevExpress.XtraEditors.SimpleButton BtnKapat;
        private System.Windows.Forms.Label LblAktiflikDurumu;
        private System.Windows.Forms.TextBox TxtAktiflikDurumu;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton BtnClose;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.Button BtnAktiflik;
    }
}

