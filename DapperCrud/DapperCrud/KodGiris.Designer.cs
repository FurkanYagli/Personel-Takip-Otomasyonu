namespace DapperCrud
{
    partial class KodGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KodGiris));
            this.LblKod = new System.Windows.Forms.Label();
            this.TxtKod = new System.Windows.Forms.TextBox();
            this.BtnGiris = new System.Windows.Forms.Button();
            this.BtnYeniKod = new System.Windows.Forms.Button();
            this.BtnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // LblKod
            // 
            this.LblKod.AutoSize = true;
            this.LblKod.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblKod.Location = new System.Drawing.Point(85, 69);
            this.LblKod.Name = "LblKod";
            this.LblKod.Size = new System.Drawing.Size(67, 29);
            this.LblKod.TabIndex = 0;
            this.LblKod.Text = "Kod:";
            // 
            // TxtKod
            // 
            this.TxtKod.Location = new System.Drawing.Point(158, 76);
            this.TxtKod.Name = "TxtKod";
            this.TxtKod.Size = new System.Drawing.Size(236, 22);
            this.TxtKod.TabIndex = 1;
            // 
            // BtnGiris
            // 
            this.BtnGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGiris.Location = new System.Drawing.Point(91, 109);
            this.BtnGiris.Name = "BtnGiris";
            this.BtnGiris.Size = new System.Drawing.Size(127, 41);
            this.BtnGiris.TabIndex = 2;
            this.BtnGiris.Text = "Giriş";
            this.BtnGiris.UseVisualStyleBackColor = true;
            this.BtnGiris.Click += new System.EventHandler(this.BtnGiris_Click);
            // 
            // BtnYeniKod
            // 
            this.BtnYeniKod.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnYeniKod.Location = new System.Drawing.Point(224, 109);
            this.BtnYeniKod.Name = "BtnYeniKod";
            this.BtnYeniKod.Size = new System.Drawing.Size(171, 41);
            this.BtnYeniKod.TabIndex = 5;
            this.BtnYeniKod.Text = "Yeni Kod";
            this.BtnYeniKod.UseVisualStyleBackColor = true;
            this.BtnYeniKod.Click += new System.EventHandler(this.BtnYeniKod_Click);
            // 
            // BtnKapat
            // 
            this.BtnKapat.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.BtnKapat.ImageOptions.Image = global::DapperCrud.Properties.Resources.icons8_cancel;
            this.BtnKapat.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.BtnKapat.Location = new System.Drawing.Point(373, -1);
            this.BtnKapat.Name = "BtnKapat";
            this.BtnKapat.Size = new System.Drawing.Size(75, 69);
            this.BtnKapat.TabIndex = 7;
            this.BtnKapat.Text = "BtnKapat";
            this.BtnKapat.Click += new System.EventHandler(this.BtnKapat_Click);
            // 
            // KodGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(59)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(448, 220);
            this.Controls.Add(this.BtnKapat);
            this.Controls.Add(this.BtnYeniKod);
            this.Controls.Add(this.BtnGiris);
            this.Controls.Add(this.TxtKod);
            this.Controls.Add(this.LblKod);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KodGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KodGiris";
            this.Load += new System.EventHandler(this.KodGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblKod;
        private System.Windows.Forms.TextBox TxtKod;
        private System.Windows.Forms.Button BtnGiris;
        private System.Windows.Forms.Button BtnYeniKod;
        private DevExpress.XtraEditors.SimpleButton BtnKapat;
    }
}