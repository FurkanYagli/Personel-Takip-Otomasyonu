using Dapper;
using DapperCrud.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DapperCrud
{
    public partial class kullaniciOlustur : Form
    {
        public kullaniciOlustur()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
        string sql = "";
        int SayfaNo = 6;
        string patternAd = @"^(?!.*\d)(?!.*[_!@#$%^&*()+\=\[\]{};':""\\|,.<>\/?]).*[a-zA-ZğıüşöçİĞÜŞÖÇ]+\s*[a-zA-ZğıüşöçİĞÜŞÖÇ\s]*$";
        private void BtnSil_Click(object sender, EventArgs e)
        {
            DynamicParameters param = new DynamicParameters();
            int IslemYapan = int.Parse(KullaniciId);
            string IslemYapilan = "Kullanıcı Silme";
            int IslemTuru = 3;
            if (int.Parse(KullaniciId) == int.Parse(LblId.Text))
            {
                MessageBox.Show("Kendinizi silemezsiniz");
            }
            else
            {
                if (KullaniciTuru == "3" && LblKullaniciTuru.Text == "3")
                {
                    if (int.Parse(KullaniciId) < int.Parse(TxtId.Text))
                    {
                        DialogResult dialo = MessageBox.Show(TxtAd.Text + " Adlı kişiyi silmek istediğinize emin misiniz", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (dialo == DialogResult.Yes)
                        {
                            try
                            {
                                bool aktifPasif = false;
                                param.Add(@"p10", aktifPasif);
                                param.Add(@"p1", TxtAd.Text);
                                param.Add(@"p2", TxtSoyad.Text); ;
                                param.Add("@p6", int.Parse(TxtId.Text));
                                param.Add("@p7", dateIslemTarihi);

                                sql = "update kullanici set  IslemTarihi=@p7, Aktif=@p10 where Id=@p6";
                                //personelBilgi tablosundaki Id'si seçilen personelin bilgilerini silme.
                                CUD(param);

                                param.Add("@p11", IslemYapan);
                                param.Add("@p5", IslemTuru);
                                param.Add("@p12", IslemYapilan);
                                param.Add("@p13", SayfaNo);

                                sql = "insert into Log values(@p11,@p7,@p5,@p12,@p13)";
                                CUD(param);
                                kolonDuzenle();
                                MessageBox.Show("Başarıyla Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch
                            {
                                MessageBox.Show("HATA");
                                connection.Close();
                            }
                        }
                        else
                        {
                            connection.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Siz bu kullanıcıyı silemezsiniz");
                    }
                }
                else
                {
                    DialogResult dialog = MessageBox.Show(TxtAd.Text + " Adlı kişiyi silmek istediğinize emin misiniz", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialog == DialogResult.Yes)
                    {
                        try
                        {
                            bool aktifPasif = false;
                            param.Add(@"p10", aktifPasif);
                            param.Add(@"p1", TxtAd.Text);
                            param.Add(@"p2", TxtSoyad.Text); ;
                            param.Add("@p6", int.Parse(TxtId.Text));
                            param.Add("@p7", dateIslemTarihi);

                            sql = "update kullanici set  IslemTarihi=@p7, Aktif=@p10 where Id=@p6";
                            //personelBilgi tablosundaki Id'si seçilen personelin bilgilerini silme.
                            CUD(param);

                            param.Add("@p11", IslemYapan);
                            param.Add("@p5", IslemTuru);
                            param.Add("@p12", IslemYapilan);
                            param.Add("@p13", SayfaNo);

                            sql = "insert into Log values(@p11,@p7,@p5,@p12,@p13)";
                            CUD(param);
                            kolonDuzenle();
                            MessageBox.Show("Başarıyla Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch
                        {
                            MessageBox.Show("HATA");
                            connection.Close();
                        }
                    }
                    else
                    {
                        connection.Close();
                    }

                }

            }
        }
        bool durum;
        public void mukerrer()
        {
            connection.Open();
            SqlCommand komutMukerrer = new SqlCommand("select * from kullanici where TC=@p1 OR Tel=@p2", connection);
            komutMukerrer.Parameters.AddWithValue("@p3", TxtAd.Text);
            komutMukerrer.Parameters.AddWithValue("@p4", TxtSoyad.Text);
            komutMukerrer.Parameters.AddWithValue("@p1", TxtTc.Text);
            komutMukerrer.Parameters.AddWithValue("@p2", TxtTel.Text);

            //komutMukerrer.Parameters.AddWithValue("@p3", TxtSoyad.Text);
            SqlDataReader drMukerrer = komutMukerrer.ExecuteReader();
            if (drMukerrer.Read())
            {
                durum = true;
                connection.Close();
            }
            else
            {
                durum = false;
                connection.Close();
            }
            connection.Close();
        }
        void CUD(DynamicParameters dynamic = null)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();//Veri tabanı bağlantısını aç.
                //connection.State özelliği,C# programında bir veritabanı bağlantısının durumunu kontrol etmek için kullanılan bir özelliktir.
            }
            connection.Execute(sql, dynamic, commandType: CommandType.Text);
            //connection.Execute komutu bağlantı açıldı ve bir sorgu çalıştırılıyor anlamına gelir.
            connection.Close();//Bağlantıyı Kapat.
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            dataGridView1.DataSource = connection.Query<Kullanicilar>("Select * from kullanici");
            dataGridView1.Columns["Id"].Visible = false;
            kolonDuzenle();
            //dataGridView1'e personelBilgi tablosundaki tüm verileri çekiyoruz.
            //comboBoxSehir.DataSource = connection.Query<Sehirler>("Select * from iller");

        }



        DateTime dateIslemTarihi = DateTime.Now;
        void kolonDuzenle()
        {
            dataGridView1.Columns["Id"].DisplayIndex = 0;
            dataGridView1.Columns["Ad"].DisplayIndex = 1;
            dataGridView1.Columns["Soyad"].DisplayIndex = 2;
            dataGridView1.Columns["Tel"].DisplayIndex = 3;
            dataGridView1.Columns["TC"].DisplayIndex = 4;
            dataGridView1.Columns["KullaniciTuru"].DisplayIndex = 5;
            dataGridView1.Columns["Aktif"].DisplayIndex = 6;
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["Aktif"].Visible = false;
            dataGridView1.Columns["IslemTarihi"].Visible = false;
            dataGridView1.ReadOnly = true;
            if (KullaniciTuru == "2")
            {
                dataGridView1.DataSource = connection.Query<Kullanicilar>("Select * from Kullanici where KullaniciTuru=1 OR KullaniciTuru=2 AND Aktif = 1 ");
                BtnAktifEt.Enabled = false;
            }
            if (KullaniciTuru == "3")
            {
                dataGridView1.DataSource = connection.Query<Kullanicilar>("Select * from Kullanici");
                dataGridView1.Columns["Aktif"].Visible = true;
                dataGridView1.Columns["Id"].Visible = true;
            }
            TxtId.Enabled = false;
            LblId.Visible = false;
            LblAktiflikDurumu.Visible = false;
            TxtId.Visible = false;

            TxtAktiflikDurumu.Visible = false;
            if (KullaniciTuru == "2")
            {
                BtnAdmin.Enabled = false;
            }
            else if (KullaniciTuru == "3")
            {

            }
        }
        string KullaniciId = Global.userId;
        string KullaniciTuru = Global.yetki;
        private void kullaniciOlustur_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = connection.Query<Kullanicilar>("Select * from Kullanici where Aktif = 1");
            kolonDuzenle();
            TxtId.Enabled = false;
            LblId.Visible = false;
            LblKullaniciTuru.Visible = false;
            LblAktiflikDurumu.Visible = false;
            TxtId.Visible = false;
            dataGridView1.Columns["Id"].Visible = false;
            //dataGridView1.Columns["Aktif"].Visible = false;



            TxtAktiflikDurumu.Visible = false;
            if (KullaniciTuru == "2")
            {
                BtnSuperAdmin.Visible = false;
                BtnAdmin.Enabled = false;
                BtnSuper.Enabled = false;
            }
            else if (KullaniciTuru == "3")
            {

            }
            else if (KullaniciTuru == "1")
            {
                MessageBox.Show("Yetkisiz Kullanıcılar bu sayfaya giremez");
                FrmPersonel fr = new FrmPersonel();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("HATALI KULLANICI GİRİŞİ");
                Application.Exit();
            }
        }

        private void BtnAnaSayfa_Click(object sender, EventArgs e)
        {
            int IslemYapan = int.Parse(KullaniciId);
            string Aciklama = "Ana Sayfaya dönme";
            int IslemTuru = 4;
            DynamicParameters param = new DynamicParameters();
            param.Add("@p3", IslemYapan);
            param.Add("@p4", dateIslemTarihi);
            param.Add("@p5", IslemTuru);
            param.Add("@p6", Aciklama);
            param.Add("@p7", SayfaNo);

            sql = "insert into Log values(@p3,@p4,@p5,@p6,@p7)";
            CUD(param);


            FrmAnaSayfa fr = new FrmAnaSayfa();
            fr.Show();
            this.Hide();
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            int IslemYapan = int.Parse(KullaniciId);
            string Aciklama = "Çıkış yapma";
            int IslemTuru = 5;
            DynamicParameters param = new DynamicParameters();
            param.Add("@p3", IslemYapan);
            param.Add("@p4", dateIslemTarihi);
            param.Add("@p5", IslemTuru);
            param.Add("@p6", Aciklama);
            param.Add("@p7", SayfaNo);

            sql = "insert into Log values(@p3,@p4,@p5,@p6,@p7)";
            CUD(param);
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtId.Text = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
            LblId.Text = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
            TxtAktiflikDurumu.Text = dataGridView1.CurrentRow.Cells["Aktif"].Value.ToString();
            LblKullaniciTuru.Text = dataGridView1.CurrentRow.Cells["KullaniciTuru"].Value.ToString();
            TxtAd.Text = dataGridView1.CurrentRow.Cells["Ad"].Value.ToString();
            TxtSoyad.Text = dataGridView1.CurrentRow.Cells["Soyad"].Value.ToString();
            TxtTc.Text = dataGridView1.CurrentRow.Cells["TC"].Value.ToString();
            TxtTel.Text = dataGridView1.CurrentRow.Cells["Tel"].Value.ToString();
        }
        void trimAdSoyad()
        {
            TxtSoyad.Text = TxtSoyad.Text.Trim();
            TxtAd.Text = TxtAd.Text.Trim();
        }
        private void BtnEkle_Click(object sender, EventArgs e)
        {

            int IslemYapan = int.Parse(KullaniciId);
            string IslemYapilan = "Kullanıcı Kaydetme";
            int IslemTuru = 1;
            int kullanici = 1;
            mukerrer();
            bool aktifPasif = true;
            //param adında dynamic bir parametre aluşturduk.
            if (int.Parse(TxtTc.Text.Substring(TxtTc.Text.Length - 1)) % 2 == 0)
            {
                if (durum == false)
                {
                    DialogResult dialog = MessageBox.Show(TxtAd.Text + " Adlı kişiyi eklemek istediğinize emin misiniz", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialog == DialogResult.Yes)
                    {
                        try
                        {
                            DynamicParameters param = new DynamicParameters();
                            trimAdSoyad();
                            if (!string.IsNullOrWhiteSpace(TxtAd.Text) && TxtAd.Text.Length > 1 && !TxtAd.Text.StartsWith(" ") && !TxtAd.Text.EndsWith(" ") && Regex.IsMatch(TxtAd.Text, patternAd))
                            {
                                param.Add("@p3", TxtAd.Text);
                            }
                            else
                            {
                                //MessageBox.Show("Hata");
                            }
                            if (!string.IsNullOrWhiteSpace(TxtSoyad.Text) && TxtSoyad.Text.Length > 1 && !TxtSoyad.Text.Contains(" ") && Regex.IsMatch(TxtSoyad.Text, patternAd))
                            {
                                param.Add("@p4", TxtSoyad.Text);
                            }
                            else
                            {
                                //MessageBox.Show("Hata");
                            }
                            if (BtnAdmin.Checked == true)
                            {
                                kullanici = 2;
                            }
                            else if (BtnYetkisiz.Checked == true)
                            {
                                kullanici = 1;
                            }
                            param.Add("@p1", TxtTc.Text);
                            param.Add("@p2", TxtTel.Text);
                            // param.Add("@p6", int.Parse(TxtId.Text));
                            param.Add("@p7", dateIslemTarihi);
                            param.Add("@p5", kullanici);
                            param.Add("@p10", aktifPasif);


                            sql = "insert into kullanici values(@p1,@p2,@p3,@p4,@p5,@p10,@p7)";
                            //Tablomuza yeni kayıt eklemek için 'insort into' komutunu kullandık.
                            CUD(param);
                            param.Add("@p11", IslemYapan);
                            param.Add("@p5", IslemTuru);
                            param.Add("@p12", IslemYapilan);
                            param.Add("@p13", SayfaNo);

                            sql = "insert into Log values(@p11,@p7,@p5,@p12,@p13)";
                            CUD(param);
                            kolonDuzenle();

                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show("Hata: " + ex.Message);
                            connection.Close();
                        }
                    }
                    //this.Refresh();
                }
                else
                {
                    /*DialogResult dialog =*/
                    MessageBox.Show("Kullanıcılarınız arasında " + TxtAd.Text + " " + TxtSoyad.Text + " " + "TC: " + TxtTc.Text + " Tel:" + TxtTel.Text + " zaten mevcut yeniden eklemek istediğinize emin misiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    /*if (dialog == DialogResult.Yes)
                    {
                        try
                        {
                            DynamicParameters param = new DynamicParameters();
                            TxtAd.Text = TxtAd.Text.Trim();
                            TxtSoyad.Text = TxtSoyad.Text.Trim();
                            if (!string.IsNullOrWhiteSpace(TxtAd.Text) && TxtAd.Text.Length > 1 && !TxtAd.Text.StartsWith(" ") && !TxtAd.Text.EndsWith(" ") && Regex.IsMatch(TxtAd.Text, patternAd))
                            {
                                param.Add("@p3", TxtAd.Text);
                            }
                            else
                            {
                                //MessageBox.Show("Hata");
                            }
                            if (!string.IsNullOrWhiteSpace(TxtSoyad.Text) && TxtSoyad.Text.Length > 1 && !TxtSoyad.Text.Contains(" ") && Regex.IsMatch(TxtSoyad.Text, patternAd))
                            {
                                param.Add("@p4", TxtSoyad.Text);
                            }
                            else
                            {
                                //MessageBox.Show("Hata");
                            }
                            if (BtnAdmin.Checked == true)
                            {
                                kullanici = 2;
                            }
                            else if (BtnYetkisiz.Checked == true)
                            {
                                kullanici = 1;
                            }
                            param.Add("@p1", TxtTc.Text);
                            param.Add("@p2", TxtTel.Text);
                            param.Add("@p6", int.Parse(TxtId.Text));
                            param.Add("@p7", dateIslemTarihi);
                            param.Add("@p5", kullanici);
                            param.Add("@p10", aktifPasif);

                            sql = "insert into kullanici values(@p1,@p2,@p3,@p4,@p5,@p10,@p7)";
                            //Tablomuza yeni kayıt eklemek için 'insort into' komutunu kullandık.

                            CUD(param);

                            MessageBox.Show("Başarıyla Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show("Hata: " + ex.Message);
                        }
                    }*/
                }

            }
            else
            {
                MessageBox.Show("Hatalı kayıt oluşturdunuz lütfen bilgilerinizi tekrar gözden geçiriniz");
            }
            kolonDuzenle();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int IslemYapan = int.Parse(KullaniciId);
            string IslemYapilan = "Kullanıcı Güncelleme";
            int IslemTuru = 2;
            string aktifPasif = TxtAktiflikDurumu.Text;
            int kullanici = 1;

            if (KullaniciId != LblId.Text)
            {
                if (KullaniciTuru == "2")
                {
                    if (LblKullaniciTuru.Text == "3")
                    {
                        MessageBox.Show("Siz Bu kullanıcıyı güncelleyemezsiniz");
                    }
                    else
                    {
                        DialogResult dialog = MessageBox.Show(dataGridView1.CurrentRow.Cells["Ad"].Value.ToString() + " Adlı kişiyi Ad:" + dataGridView1.CurrentRow.Cells["Ad"].Value.ToString() + " Soyad:" + dataGridView1.CurrentRow.Cells["Soyad"].Value.ToString() + " " + " bilgilerinden" + " Ad:" + TxtAd.Text + " Soyad:" + TxtSoyad.Text + " bilgilerine güncellemek istediğinize emin misiniz", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (dialog == DialogResult.Yes)
                        {
                            try
                            {

                                DynamicParameters param = new DynamicParameters();
                                trimAdSoyad();
                                if (!string.IsNullOrWhiteSpace(TxtAd.Text) && TxtAd.Text.Length > 1 && !TxtAd.Text.StartsWith(" ") && !TxtAd.Text.EndsWith(" ") && Regex.IsMatch(TxtAd.Text, patternAd))
                                {
                                    param.Add("@p3", TxtAd.Text);
                                }
                                else
                                {
                                    //MessageBox.Show("Hata");
                                }
                                if (!string.IsNullOrWhiteSpace(TxtSoyad.Text) && TxtSoyad.Text.Length > 1 && !TxtSoyad.Text.Contains(" ") && Regex.IsMatch(TxtSoyad.Text, patternAd))
                                {
                                    param.Add("@p4", TxtSoyad.Text);
                                }
                                else
                                {
                                    //MessageBox.Show("Hata");
                                }
                                if (KullaniciTuru == "2")
                                {
                                    if (BtnAdmin.Checked == true)
                                    {
                                        BtnYetkisiz.Enabled = false;
                                        kullanici = 2;
                                    }
                                    else if (BtnYetkisiz.Checked == true)
                                    {
                                        kullanici = 1;
                                    }
                                    else
                                    {
                                        kullanici = int.Parse(LblKullaniciTuru.Text);
                                    }
                                }
                                else if (KullaniciTuru == "3")
                                {
                                    if (BtnYetkisiz.Checked)
                                    {
                                        kullanici = 1;

                                    }
                                    else if (BtnAdmin.Checked)
                                    {
                                        kullanici = 2;
                                    }
                                    else { kullanici = int.Parse(LblKullaniciTuru.Text); }
                                }

                                //p1 parametresine TxtAd'a girlen bilgiyi ata.
                                param.Add("@p1", TxtTc.Text);
                                param.Add("@p2", TxtTel.Text);
                                param.Add("@p6", int.Parse(TxtId.Text));
                                param.Add("@p7", dateIslemTarihi);
                                param.Add("@p5", kullanici);
                                param.Add("@p10", aktifPasif);

                                sql = "update kullanici set Ad=@p3, Soyad=@p4, TC=@p1, Tel=@p2, IslemTarihi=@p7, KullaniciTuru=@p5, Aktif=@p10 where Id=@p6";
                                //personel bilgisini güncelledik.

                                CUD(param);
                                kolonDuzenle();
                                param.Add("@p11", IslemYapan);
                                param.Add("@p5", IslemTuru);
                                param.Add("@p12", IslemYapilan);
                                param.Add("@p13", SayfaNo);

                                sql = "insert into Log values(@p11,@p7,@p5,@p12,@p13)";
                                CUD(param);
                                MessageBox.Show("Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                TxtAd.Text.Trim();
                                TxtSoyad.Text.Trim();
                                MessageBox.Show("HATA: " + ex.Message);
                            }
                        }
                    }
                }
                else if (KullaniciTuru == "3")
                {
                    if (LblKullaniciTuru.Text == "3" && int.Parse(KullaniciId) < int.Parse(TxtId.Text) || LblKullaniciTuru.Text == "2" || LblKullaniciTuru.Text == "1")
                    {
                        DialogResult dialog = MessageBox.Show(dataGridView1.CurrentRow.Cells["Ad"].Value.ToString() + " Adlı kişiyi Ad:" + dataGridView1.CurrentRow.Cells["Ad"].Value.ToString() + " Soyad:" + dataGridView1.CurrentRow.Cells["Soyad"].Value.ToString() + " " + " bilgilerinden" + " Ad:" + TxtAd.Text + " Soyad:" + TxtSoyad.Text + " bilgilerine güncellemek istediğinize emin misiniz", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (dialog == DialogResult.Yes)
                        {
                            try
                            {

                                DynamicParameters param = new DynamicParameters();
                                trimAdSoyad();
                                if (!string.IsNullOrWhiteSpace(TxtAd.Text) && TxtAd.Text.Length > 1 && !TxtAd.Text.StartsWith(" ") && !TxtAd.Text.EndsWith(" ") && Regex.IsMatch(TxtAd.Text, patternAd))
                                {
                                    param.Add("@p3", TxtAd.Text);
                                }
                                else
                                {
                                    //MessageBox.Show("Hata");
                                }
                                if (!string.IsNullOrWhiteSpace(TxtSoyad.Text) && TxtSoyad.Text.Length > 1 && !TxtSoyad.Text.Contains(" ") && Regex.IsMatch(TxtSoyad.Text, patternAd))
                                {
                                    param.Add("@p4", TxtSoyad.Text);
                                }
                                else
                                {
                                    //MessageBox.Show("Hata");
                                }
                                if (KullaniciTuru == "2")
                                {
                                    if (BtnAdmin.Checked == true)
                                    {
                                        BtnYetkisiz.Enabled = false;
                                        kullanici = 2;
                                    }
                                    else if (BtnYetkisiz.Checked == true)
                                    {
                                        kullanici = 1;
                                    }
                                    else
                                    {
                                        kullanici = 1;
                                    }
                                }
                                else if (KullaniciTuru == "3")
                                {
                                    if (LblKullaniciTuru.Text == "3" && int.Parse(KullaniciId) < int.Parse(TxtId.Text))
                                    {
                                        if (BtnYetkisiz.Checked)
                                        {
                                            kullanici = 1;

                                        }
                                        else if (BtnAdmin.Checked)
                                        {
                                            kullanici = 2;
                                        }
                                        else if (BtnSuper.Checked)
                                        {
                                            kullanici = 3;
                                        }
                                        else { kullanici = 3; }
                                    }
                                    else if (LblKullaniciTuru.Text == "2" || LblKullaniciTuru.Text == "1")
                                    {
                                        if (BtnYetkisiz.Checked)
                                        {
                                            kullanici = 1;

                                        }
                                        else if (BtnAdmin.Checked)
                                        {
                                            kullanici = 2;
                                        }
                                        else if (BtnSuper.Checked)
                                        {
                                            kullanici = 3;
                                        }
                                        else { kullanici = int.Parse(LblKullaniciTuru.Text); }
                                    }
                                    else
                                    {
                                        kullanici.ToString("a");
                                        MessageBox.Show("Sizin bu kullanıcıyı güncellemeye yetkiniz yetmiyor");
                                    }

                                }

                                //p1 parametresine TxtAd'a girlen bilgiyi ata.
                                param.Add("@p1", TxtTc.Text);
                                param.Add("@p2", TxtTel.Text);
                                param.Add("@p6", int.Parse(TxtId.Text));
                                param.Add("@p7", dateIslemTarihi);
                                param.Add("@p5", kullanici);
                                param.Add("@p10", aktifPasif);

                                sql = "update kullanici set Ad=@p3, Soyad=@p4, TC=@p1, Tel=@p2, IslemTarihi=@p7, KullaniciTuru=@p5, Aktif=@p10 where Id=@p6";
                                //personel bilgisini güncelledik.

                                CUD(param);
                                kolonDuzenle();
                                param.Add("@p11", IslemYapan);
                                param.Add("@p5", IslemTuru);
                                param.Add("@p12", IslemYapilan);
                                param.Add("@p13", SayfaNo);

                                sql = "insert into Log values(@p11,@p7,@p5,@p12,@p13)";
                                CUD(param);
                                MessageBox.Show("Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                TxtAd.Text.Trim();
                                TxtSoyad.Text.Trim();
                                MessageBox.Show("HATA: " + ex.Message);
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Siz bu kullanıcıyı güncelleyemezsiniz");
                    }
                }



            }


        }

        private void BtnAktifEt_Click(object sender, EventArgs e)
        {
            DynamicParameters param = new DynamicParameters();
            int IslemYapan = int.Parse(KullaniciId);
            string IslemYapilan = "Kullanıcı Kaydetme";
            int IslemTuru = 1;
            bool aktifPasif = true;
            if (KullaniciTuru == "2")
            {
                if (LblKullaniciTuru.Text == "3")
                {
                    MessageBox.Show("Yetkiniz bu kullanıcıyı aktif etmek için yetersiz");
                }
                else if (LblKullaniciTuru.Text == "2")
                {
                    MessageBox.Show("Yetkiniz bu kullanıcıyı aktif etmek için yetersiz");
                }
                else
                {
                    try
                    {

                        param.Add("@p10", aktifPasif);
                        param.Add("@p6", int.Parse(TxtId.Text));
                        sql = "update kullanici set Aktif=@p10 where Id=@p6";
                        CUD(param);

                        param.Add("@p11", IslemYapan);
                        param.Add("@p7", dateIslemTarihi);
                        param.Add("@p5", IslemTuru);
                        param.Add("@p12", IslemYapilan);
                        param.Add("@p13", IslemTuru);

                        sql = "insert into Log values(@p11,@p7,@p5,@p12,@p13)";
                        CUD(param);
                        kolonDuzenle();
                        MessageBox.Show("Başarılı bir şekilde aktif edildi");
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("HATA");
                    }

                }
            }
            else if (KullaniciTuru == "3")
            {
                if (LblKullaniciTuru.Text == "3")
                {
                    if (int.Parse(KullaniciId) < int.Parse(TxtId.Text))
                    {
                        try
                        {

                            param.Add("@p10", aktifPasif);
                            param.Add("@p6", int.Parse(TxtId.Text));
                            sql = "update kullanici set Aktif=@p10 where Id=@p6";
                            CUD(param);

                            param.Add("@p11", IslemYapan);
                            param.Add("@p7", dateIslemTarihi);
                            param.Add("@p5", IslemTuru);
                            param.Add("@p12", IslemYapilan);
                            param.Add("@p13", IslemTuru);

                            sql = "insert into Log values(@p11,@p7,@p5,@p12,@p13)";
                            CUD(param);
                            kolonDuzenle();
                            MessageBox.Show("Başarılı bir şekilde aktif edildi");
                        }
                        catch (Exception)
                        {

                            MessageBox.Show("HATA");
                        }

                    }
                }
                else
                {
                    try
                    {

                        param.Add("@p10", aktifPasif);
                        param.Add("@p6", int.Parse(TxtId.Text));
                        sql = "update kullanici set Aktif=@p10 where Id=@p6";
                        CUD(param);

                        param.Add("@p11", IslemYapan);
                        param.Add("@p7", dateIslemTarihi);
                        param.Add("@p5", IslemTuru);
                        param.Add("@p12", IslemYapilan);
                        param.Add("@p13", IslemTuru);

                        sql = "insert into Log values(@p11,@p7,@p5,@p12,@p13)";
                        CUD(param);
                        kolonDuzenle();
                        MessageBox.Show("Başarılı bir şekilde aktif edildi");
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("HATA");
                    }

                }
            }

        }

        private void BtnSuperAdmin_Click(object sender, EventArgs e)
        {
            int IslemYapan = int.Parse(KullaniciId);
            string IslemYapilan = "Kullanıcı Kaydetme";
            int IslemTuru = 1;
            int kullanici = 3;
            bool aktifPasif = true;
            mukerrer();

            //param adında dynamic bir parametre aluşturduk.
            if (int.Parse(TxtTc.Text.Substring(TxtTc.Text.Length - 1)) % 2 == 0)
            {
                if (durum == false)
                {
                    DialogResult dialog = MessageBox.Show(" Süper Admin oluşturmak istediğinize emin misiniz", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialog == DialogResult.Yes)
                    {
                        try
                        {
                            DynamicParameters param = new DynamicParameters();
                            trimAdSoyad();
                            if (!string.IsNullOrWhiteSpace(TxtAd.Text) && TxtAd.Text.Length > 1 && !TxtAd.Text.StartsWith(" ") && !TxtAd.Text.EndsWith(" ") && Regex.IsMatch(TxtAd.Text, patternAd))
                            {
                                param.Add("@p3", TxtAd.Text);
                            }
                            else
                            {
                                //MessageBox.Show("Hata");
                            }
                            if (!string.IsNullOrWhiteSpace(TxtSoyad.Text) && TxtSoyad.Text.Length > 1 && !TxtSoyad.Text.Contains(" ") && Regex.IsMatch(TxtSoyad.Text, patternAd))
                            {
                                param.Add("@p4", TxtSoyad.Text);
                            }
                            else
                            {
                                //MessageBox.Show("Hata");
                            }
                            if (BtnAdmin.Checked == true)
                            {
                                kullanici = 3;
                            }
                            else if (BtnYetkisiz.Checked == true)
                            {
                                kullanici = 3;
                            }
                            param.Add("@p1", TxtTc.Text);
                            param.Add("@p2", TxtTel.Text);
                            //param.Add("@p6", int.Parse(TxtId.Text));
                            param.Add("@p7", dateIslemTarihi);
                            param.Add("@p5", kullanici);
                            param.Add("@p10", aktifPasif);


                            sql = "insert into kullanici values(@p1,@p2,@p3,@p4,@p5,@p10,@p7)";
                            //Tablomuza yeni kayıt eklemek için 'insort into' komutunu kullandık.
                            CUD(param);
                            param.Add("@p11", IslemYapan);
                            param.Add("@p5", IslemTuru);
                            param.Add("@p12", IslemYapilan);
                            param.Add("@p13", SayfaNo);

                            sql = "insert into Log values(@p11,@p7,@p5,@p12,@p13)";
                            CUD(param);
                            kolonDuzenle();

                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show("Hata: " + ex.Message);
                            connection.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Kullanıcılarınız arasında " + TxtAd.Text + " " + TxtSoyad.Text + " " + "TC: " + TxtTc.Text + " Tel:" + TxtTel.Text + " zaten mevcut yeniden eklemek istediğinize emin misiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            else
            {
                MessageBox.Show("Hatalı kayıt oluşturdunuz lütfen bilgilerinizi tekrar gözden geçiriniz");
            }
            kolonDuzenle();
        }

    }
}




