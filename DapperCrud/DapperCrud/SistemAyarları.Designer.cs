namespace DapperCrud
{
    partial class FrmSistemAyarları
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSistemAyarları));
            this.DGVSehir = new System.Windows.Forms.DataGridView();
            this.DGVMeslek = new System.Windows.Forms.DataGridView();
            this.TxtSehir = new System.Windows.Forms.TextBox();
            this.TxtMeslek = new System.Windows.Forms.TextBox();
            this.LblIL = new System.Windows.Forms.Label();
            this.LblMeslek = new System.Windows.Forms.Label();
            this.BtnKaydetMeslek = new System.Windows.Forms.Button();
            this.BtnAnaSayfa = new DevExpress.XtraEditors.SimpleButton();
            this.BtnKaydetSehir = new System.Windows.Forms.Button();
            this.BtnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageSehir = new System.Windows.Forms.TabPage();
            this.BtnSehirSil = new System.Windows.Forms.Button();
            this.BtnSehirGuncelle = new System.Windows.Forms.Button();
            this.tabPageMeslek = new System.Windows.Forms.TabPage();
            this.BtnMeslekSil = new System.Windows.Forms.Button();
            this.BtnMeslekGuncelle = new System.Windows.Forms.Button();
            this.LblSehirId = new System.Windows.Forms.Label();
            this.LblMeslekId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSehir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMeslek)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageSehir.SuspendLayout();
            this.tabPageMeslek.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVSehir
            // 
            this.DGVSehir.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVSehir.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVSehir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVSehir.Location = new System.Drawing.Point(-4, 3);
            this.DGVSehir.Name = "DGVSehir";
            this.DGVSehir.RowTemplate.Height = 24;
            this.DGVSehir.Size = new System.Drawing.Size(1015, 442);
            this.DGVSehir.TabIndex = 0;
            this.DGVSehir.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVSehir_CellClick);
            // 
            // DGVMeslek
            // 
            this.DGVMeslek.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVMeslek.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVMeslek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMeslek.Location = new System.Drawing.Point(-4, 3);
            this.DGVMeslek.Name = "DGVMeslek";
            this.DGVMeslek.RowTemplate.Height = 24;
            this.DGVMeslek.Size = new System.Drawing.Size(1015, 442);
            this.DGVMeslek.TabIndex = 1;
            this.DGVMeslek.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVMeslek_CellClick);
            this.DGVMeslek.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVMeslek_CellContentClick);
            // 
            // TxtSehir
            // 
            this.TxtSehir.Location = new System.Drawing.Point(93, 482);
            this.TxtSehir.Name = "TxtSehir";
            this.TxtSehir.Size = new System.Drawing.Size(281, 36);
            this.TxtSehir.TabIndex = 2;
            // 
            // TxtMeslek
            // 
            this.TxtMeslek.Location = new System.Drawing.Point(131, 491);
            this.TxtMeslek.Name = "TxtMeslek";
            this.TxtMeslek.Size = new System.Drawing.Size(281, 36);
            this.TxtMeslek.TabIndex = 3;
            // 
            // LblIL
            // 
            this.LblIL.AutoSize = true;
            this.LblIL.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblIL.Location = new System.Drawing.Point(-3, 481);
            this.LblIL.Name = "LblIL";
            this.LblIL.Size = new System.Drawing.Size(90, 37);
            this.LblIL.TabIndex = 4;
            this.LblIL.Text = "Şehir:";
            // 
            // LblMeslek
            // 
            this.LblMeslek.AutoSize = true;
            this.LblMeslek.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblMeslek.Location = new System.Drawing.Point(11, 491);
            this.LblMeslek.Name = "LblMeslek";
            this.LblMeslek.Size = new System.Drawing.Size(114, 37);
            this.LblMeslek.TabIndex = 5;
            this.LblMeslek.Text = "Meslek:";
            // 
            // BtnKaydetMeslek
            // 
            this.BtnKaydetMeslek.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKaydetMeslek.Location = new System.Drawing.Point(424, 481);
            this.BtnKaydetMeslek.Name = "BtnKaydetMeslek";
            this.BtnKaydetMeslek.Size = new System.Drawing.Size(189, 63);
            this.BtnKaydetMeslek.TabIndex = 6;
            this.BtnKaydetMeslek.Text = "Meslek Kaydet";
            this.BtnKaydetMeslek.UseVisualStyleBackColor = true;
            this.BtnKaydetMeslek.Click += new System.EventHandler(this.BtnKaydetMeslek_Click);
            // 
            // BtnAnaSayfa
            // 
            this.BtnAnaSayfa.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAnaSayfa.Appearance.Options.UseFont = true;
            this.BtnAnaSayfa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.BtnAnaSayfa.ImageOptions.Image = global::DapperCrud.Properties.Resources.icons8_house;
            this.BtnAnaSayfa.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.BtnAnaSayfa.Location = new System.Drawing.Point(1039, 129);
            this.BtnAnaSayfa.Name = "BtnAnaSayfa";
            this.BtnAnaSayfa.Size = new System.Drawing.Size(160, 149);
            this.BtnAnaSayfa.TabIndex = 7;
            this.BtnAnaSayfa.Text = "Ana Sayfa";
            this.BtnAnaSayfa.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // BtnKaydetSehir
            // 
            this.BtnKaydetSehir.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKaydetSehir.Location = new System.Drawing.Point(389, 471);
            this.BtnKaydetSehir.Name = "BtnKaydetSehir";
            this.BtnKaydetSehir.Size = new System.Drawing.Size(189, 63);
            this.BtnKaydetSehir.TabIndex = 8;
            this.BtnKaydetSehir.Text = "Sehir Kaydet";
            this.BtnKaydetSehir.UseVisualStyleBackColor = true;
            this.BtnKaydetSehir.Click += new System.EventHandler(this.BtnKaydetSehir_Click);
            // 
            // BtnKapat
            // 
            this.BtnKapat.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.BtnKapat.ImageOptions.Image = global::DapperCrud.Properties.Resources.icons8_cancel;
            this.BtnKapat.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.BtnKapat.Location = new System.Drawing.Point(1080, 1);
            this.BtnKapat.Name = "BtnKapat";
            this.BtnKapat.Size = new System.Drawing.Size(117, 122);
            this.BtnKapat.TabIndex = 9;
            this.BtnKapat.Text = "BtnKapat";
            this.BtnKapat.Click += new System.EventHandler(this.BtnKapat_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageSehir);
            this.tabControl1.Controls.Add(this.tabPageMeslek);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1037, 637);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPageSehir
            // 
            this.tabPageSehir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(59)))), ((int)(((byte)(87)))));
            this.tabPageSehir.Controls.Add(this.BtnSehirSil);
            this.tabPageSehir.Controls.Add(this.BtnSehirGuncelle);
            this.tabPageSehir.Controls.Add(this.DGVSehir);
            this.tabPageSehir.Controls.Add(this.TxtSehir);
            this.tabPageSehir.Controls.Add(this.BtnKaydetSehir);
            this.tabPageSehir.Controls.Add(this.LblIL);
            this.tabPageSehir.Location = new System.Drawing.Point(4, 37);
            this.tabPageSehir.Name = "tabPageSehir";
            this.tabPageSehir.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSehir.Size = new System.Drawing.Size(1029, 596);
            this.tabPageSehir.TabIndex = 0;
            this.tabPageSehir.Text = "Şehir";
            // 
            // BtnSehirSil
            // 
            this.BtnSehirSil.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSehirSil.Location = new System.Drawing.Point(779, 471);
            this.BtnSehirSil.Name = "BtnSehirSil";
            this.BtnSehirSil.Size = new System.Drawing.Size(189, 63);
            this.BtnSehirSil.TabIndex = 10;
            this.BtnSehirSil.Text = "Sehir Sil";
            this.BtnSehirSil.UseVisualStyleBackColor = true;
            this.BtnSehirSil.Click += new System.EventHandler(this.BtnSehirSil_Click);
            // 
            // BtnSehirGuncelle
            // 
            this.BtnSehirGuncelle.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSehirGuncelle.Location = new System.Drawing.Point(584, 471);
            this.BtnSehirGuncelle.Name = "BtnSehirGuncelle";
            this.BtnSehirGuncelle.Size = new System.Drawing.Size(189, 63);
            this.BtnSehirGuncelle.TabIndex = 9;
            this.BtnSehirGuncelle.Text = "Sehir Güncelle";
            this.BtnSehirGuncelle.UseVisualStyleBackColor = true;
            this.BtnSehirGuncelle.Click += new System.EventHandler(this.BtnSehirGuncelle_Click);
            // 
            // tabPageMeslek
            // 
            this.tabPageMeslek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(59)))), ((int)(((byte)(87)))));
            this.tabPageMeslek.Controls.Add(this.BtnMeslekSil);
            this.tabPageMeslek.Controls.Add(this.BtnMeslekGuncelle);
            this.tabPageMeslek.Controls.Add(this.DGVMeslek);
            this.tabPageMeslek.Controls.Add(this.BtnKaydetMeslek);
            this.tabPageMeslek.Controls.Add(this.TxtMeslek);
            this.tabPageMeslek.Controls.Add(this.LblMeslek);
            this.tabPageMeslek.Location = new System.Drawing.Point(4, 37);
            this.tabPageMeslek.Name = "tabPageMeslek";
            this.tabPageMeslek.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMeslek.Size = new System.Drawing.Size(1029, 596);
            this.tabPageMeslek.TabIndex = 1;
            this.tabPageMeslek.Text = "Meslek";
            // 
            // BtnMeslekSil
            // 
            this.BtnMeslekSil.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnMeslekSil.Location = new System.Drawing.Point(814, 481);
            this.BtnMeslekSil.Name = "BtnMeslekSil";
            this.BtnMeslekSil.Size = new System.Drawing.Size(189, 63);
            this.BtnMeslekSil.TabIndex = 12;
            this.BtnMeslekSil.Text = "Meslek Sil";
            this.BtnMeslekSil.UseVisualStyleBackColor = true;
            this.BtnMeslekSil.Click += new System.EventHandler(this.BtnMeslekSil_Click);
            // 
            // BtnMeslekGuncelle
            // 
            this.BtnMeslekGuncelle.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnMeslekGuncelle.Location = new System.Drawing.Point(619, 481);
            this.BtnMeslekGuncelle.Name = "BtnMeslekGuncelle";
            this.BtnMeslekGuncelle.Size = new System.Drawing.Size(189, 63);
            this.BtnMeslekGuncelle.TabIndex = 11;
            this.BtnMeslekGuncelle.Text = "Meslek Güncelle";
            this.BtnMeslekGuncelle.UseVisualStyleBackColor = true;
            this.BtnMeslekGuncelle.Click += new System.EventHandler(this.BtnMeslekGuncelle_Click);
            // 
            // LblSehirId
            // 
            this.LblSehirId.AutoSize = true;
            this.LblSehirId.Location = new System.Drawing.Point(1107, 378);
            this.LblSehirId.Name = "LblSehirId";
            this.LblSehirId.Size = new System.Drawing.Size(84, 29);
            this.LblSehirId.TabIndex = 11;
            this.LblSehirId.Text = "SehirId";
            // 
            // LblMeslekId
            // 
            this.LblMeslekId.AutoSize = true;
            this.LblMeslekId.Location = new System.Drawing.Point(1084, 416);
            this.LblMeslekId.Name = "LblMeslekId";
            this.LblMeslekId.Size = new System.Drawing.Size(104, 29);
            this.LblMeslekId.TabIndex = 12;
            this.LblMeslekId.Text = "MeslekId";
            // 
            // FrmSistemAyarları
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(59)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(1200, 633);
            this.Controls.Add(this.LblMeslekId);
            this.Controls.Add(this.LblSehirId);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.BtnKapat);
            this.Controls.Add(this.BtnAnaSayfa);
            this.Font = new System.Drawing.Font("Corbel", 13.8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmSistemAyarları";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistem Ayarları";
            this.Load += new System.EventHandler(this.FrmSistemAyarları_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVSehir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMeslek)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageSehir.ResumeLayout(false);
            this.tabPageSehir.PerformLayout();
            this.tabPageMeslek.ResumeLayout(false);
            this.tabPageMeslek.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVSehir;
        private System.Windows.Forms.DataGridView DGVMeslek;
        private System.Windows.Forms.TextBox TxtSehir;
        private System.Windows.Forms.TextBox TxtMeslek;
        private System.Windows.Forms.Label LblIL;
        private System.Windows.Forms.Label LblMeslek;
        private System.Windows.Forms.Button BtnKaydetMeslek;
        private DevExpress.XtraEditors.SimpleButton BtnAnaSayfa;
        private System.Windows.Forms.Button BtnKaydetSehir;
        private DevExpress.XtraEditors.SimpleButton BtnKapat;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageSehir;
        private System.Windows.Forms.TabPage tabPageMeslek;
        private System.Windows.Forms.Button BtnSehirSil;
        private System.Windows.Forms.Button BtnSehirGuncelle;
        private System.Windows.Forms.Button BtnMeslekSil;
        private System.Windows.Forms.Button BtnMeslekGuncelle;
        private System.Windows.Forms.Label LblSehirId;
        private System.Windows.Forms.Label LblMeslekId;
    }
}