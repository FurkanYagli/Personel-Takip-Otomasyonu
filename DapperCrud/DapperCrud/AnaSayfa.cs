using DapperCrud.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DapperCrud
{
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }
        //Giris gr = new Giris();


        private void BtnPersonelEkle_Click(object sender, EventArgs e)
        {
            FrmPersonel fr = new FrmPersonel();
            fr.Show();
            this.Hide();
        }
  
        private void BtnSistemAyarları_Click(object sender, EventArgs e)
        {
            FrmSistemAyarları fr = new FrmSistemAyarları();
            fr.Show();
            this.Hide();
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private Giris girisFormu;
        public FrmAnaSayfa(Giris form)
        {
            InitializeComponent();
            girisFormu = form;
        }

        string KullaniciId = Global.userId;
        string KullaniciTuru = Global.yetki;
        private void FrmAnaSayfa_Load(object sender, EventArgs e)
        {
            



            if (KullaniciTuru == "1")
            {
                
                BtnSistemAyarları.Visible = false;
                simpleButtonKullaniciOlustur.Visible = false;
            }
            else if (KullaniciTuru == "2")
            {
                
                simpleButtonKullaniciOlustur.Visible = true;
            }
            else if (KullaniciTuru == "3")
            {
                
            }
            else
            {
                BtnSistemAyarları.Visible = false;
                simpleButtonKullaniciOlustur.Visible = false;
                BtnPersonelEkle.Visible = false;
            }

        }

        private void simpleButtonKullaniciOlustur_Click(object sender, EventArgs e)
        {
            kullaniciOlustur formKullanici = new kullaniciOlustur();
            formKullanici.Show();
            this.Hide();
        }
    }
}
