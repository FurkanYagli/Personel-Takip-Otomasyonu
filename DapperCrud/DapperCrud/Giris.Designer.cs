namespace DapperCrud
{
    partial class Giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            this.LblTC = new System.Windows.Forms.Label();
            this.maskedTextBoxTC = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxTel = new System.Windows.Forms.MaskedTextBox();
            this.LblTel = new System.Windows.Forms.Label();
            this.btnGiris = new System.Windows.Forms.Button();
            this.BtnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.BtnClose = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // LblTC
            // 
            this.LblTC.AutoSize = true;
            this.LblTC.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblTC.Location = new System.Drawing.Point(15, 94);
            this.LblTC.Name = "LblTC";
            this.LblTC.Size = new System.Drawing.Size(277, 37);
            this.LblTC.TabIndex = 1;
            this.LblTC.Text = "T.C Kimlik Numarası";
            // 
            // maskedTextBoxTC
            // 
            this.maskedTextBoxTC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(59)))), ((int)(((byte)(87)))));
            this.maskedTextBoxTC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedTextBoxTC.Location = new System.Drawing.Point(49, 148);
            this.maskedTextBoxTC.Mask = "00000000000";
            this.maskedTextBoxTC.Name = "maskedTextBoxTC";
            this.maskedTextBoxTC.Size = new System.Drawing.Size(321, 36);
            this.maskedTextBoxTC.TabIndex = 2;
            this.maskedTextBoxTC.ValidatingType = typeof(int);
            // 
            // maskedTextBoxTel
            // 
            this.maskedTextBoxTel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(59)))), ((int)(((byte)(87)))));
            this.maskedTextBoxTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedTextBoxTel.Location = new System.Drawing.Point(49, 255);
            this.maskedTextBoxTel.Mask = "00000000000";
            this.maskedTextBoxTel.Name = "maskedTextBoxTel";
            this.maskedTextBoxTel.Size = new System.Drawing.Size(321, 36);
            this.maskedTextBoxTel.TabIndex = 4;
            this.maskedTextBoxTel.ValidatingType = typeof(int);
            // 
            // LblTel
            // 
            this.LblTel.AutoSize = true;
            this.LblTel.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblTel.Location = new System.Drawing.Point(15, 201);
            this.LblTel.Name = "LblTel";
            this.LblTel.Size = new System.Drawing.Size(244, 37);
            this.LblTel.TabIndex = 3;
            this.LblTel.Text = "Telefon Numarası";
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(55, 331);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(275, 80);
            this.btnGiris.TabIndex = 5;
            this.btnGiris.Text = "GİRİŞ YAP";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // BtnKapat
            // 
            this.BtnKapat.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.BtnKapat.ImageOptions.Image = global::DapperCrud.Properties.Resources.icons8_cancel;
            this.BtnKapat.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.BtnKapat.Location = new System.Drawing.Point(298, 2);
            this.BtnKapat.Name = "BtnKapat";
            this.BtnKapat.Size = new System.Drawing.Size(88, 92);
            this.BtnKapat.TabIndex = 6;
            this.BtnKapat.Text = "BtnKapat";
            this.BtnKapat.Click += new System.EventHandler(this.BtnKapat_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.BtnClose.ImageOptions.Image = global::DapperCrud.Properties.Resources.icons8_cancel;
            this.BtnClose.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.BtnClose.Location = new System.Drawing.Point(307, 1);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(77, 75);
            this.BtnClose.TabIndex = 41;
            this.BtnClose.Text = "simpleButton1";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(59)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(385, 566);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.maskedTextBoxTel);
            this.Controls.Add(this.LblTel);
            this.Controls.Add(this.maskedTextBoxTC);
            this.Controls.Add(this.LblTC);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giris";
            this.Load += new System.EventHandler(this.Giris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTC;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTC;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTel;
        private System.Windows.Forms.Label LblTel;
        private System.Windows.Forms.Button btnGiris;
        private DevExpress.XtraEditors.SimpleButton BtnKapat;
        private DevExpress.XtraEditors.SimpleButton BtnClose;
    }
}