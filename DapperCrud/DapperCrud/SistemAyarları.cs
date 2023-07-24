using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using DapperCrud.Resources;

namespace DapperCrud
{
    public partial class FrmSistemAyarları : Form
    {
        public FrmSistemAyarları()
        {
            InitializeComponent();
        }
        bool durumSehir;
        bool durumMeslek;
        void mukerrerSehir()
        {
            connection.Open();
            SqlCommand komutMukerrerSehir = new SqlCommand("select * from _Sehir where Ad=@p1", connection);
            komutMukerrerSehir.Parameters.AddWithValue("@p1", TxtSehir.Text);
            //komutMukerrer.Parameters.AddWithValue("@p3", TxtSehir.Text);
            //komutMukerrer.Parameters.AddWithValue("@p3", TxtSoyad.Text);
            SqlDataReader drMukerrerSehir = komutMukerrerSehir.ExecuteReader();
            if (drMukerrerSehir.Read())
            {
                durumSehir = true;
            }
            else
            {
                durumSehir = false;
            }
            connection.Close();
        }
        DateTime date = DateTime.Now;
        void mukerrerMeslek()
        {
            connection.Open();
            SqlCommand komutMukerrerMeslek = new SqlCommand("select * from  _Meslek where Ad=@p1", connection);
            komutMukerrerMeslek.Parameters.AddWithValue("@p1", TxtMeslek.Text);
            //komutMukerrer.Parameters.AddWithValue("@p3", TxtSehir.Text);
            //komutMukerrer.Parameters.AddWithValue("@p3", TxtSoyad.Text);
            SqlDataReader drMukerrerMeslek = komutMukerrerMeslek.ExecuteReader();
            if (drMukerrerMeslek.Read())
            {
                durumMeslek = true;
            }
            else
            {
                durumMeslek = false;
            }
            connection.Close();
        }
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
        string sql = "";
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
            DGVSehir.DataSource = connection.Query<Sehirler>("Select * from _Sehir");
            DGVMeslek.DataSource = connection.Query<Meslekler>("Select * from _Meslek");
        }
        bool Aktif;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            int IslemYapan = int.Parse(KullaniciId);
            string Aciklama = "Ana Sayfaya dönme";
            int IslemTuru = 4;
            DynamicParameters param = new DynamicParameters();
            param.Add("@p3", IslemYapan);
            param.Add("@p4", date);
            param.Add("@p5", IslemTuru);
            param.Add("@p6", Aciklama);
            param.Add("@p7", SayfaNo);

            sql = "insert into Log values(@p3,@p4,@p5,@p6,@p7)";
            CUD(param);
            FrmAnaSayfa fr = new FrmAnaSayfa();
            fr.Show();
            this.Hide();
        }
        void kolonDuzenle()
        {
            DGVSehir.Columns["Id"].DisplayIndex = 0;
            DGVSehir.Columns["Ad"].DisplayIndex = 1;
            DGVSehir.Columns["Aktif"].DisplayIndex = 2;

            DGVMeslek.Columns["Id"].DisplayIndex = 0;
            DGVMeslek.Columns["Ad"].DisplayIndex = 1;
            DGVMeslek.Columns["Aktif"].DisplayIndex = 2;
            DataGridViewColumn kolonAd = DGVSehir.Columns["Ad"];
            DataGridViewColumn kolonAdMeslek = DGVMeslek.Columns["Ad"];
            DGVSehir.Columns["IslemTarihi"].Visible = false;
            DGVMeslek.Columns["IslemTarihi"].Visible = false;
            kolonAd.HeaderText = "Şehir";
            kolonAdMeslek.HeaderText = "Meslek";
            DGVMeslek.Columns["Aktif"].Visible = false;
            DGVSehir.Columns["Aktif"].Visible = false;
            DGVSehir.DataSource = connection.Query<Sehirler>("Select * from _Sehir Where Aktif=1");
            DGVMeslek.DataSource = connection.Query<Meslekler>("Select * from _Meslek Where Aktif=1");
            DGVMeslek.ReadOnly = true;
            DGVSehir.ReadOnly = true;
            LblSehirId.Visible = false;
            LblMeslekId.Visible = false;

        }
        string KullaniciId = Global.userId;
        string KullaniciTuru = Global.yetki;
        int SayfaNo = 5;


        private void FrmSistemAyarları_Load(object sender, EventArgs e)
        {
            DGVSehir.DataSource = connection.Query<Sehirler>("Select * from _Sehir Where Aktif=1");
            DGVMeslek.DataSource = connection.Query<Meslekler>("Select * from _Meslek Where Aktif=1");
            kolonDuzenle();

        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            int IslemYapan = int.Parse(KullaniciId);
            string Aciklama = "Çıkış yapma";
            int IslemTuru = 5;
            DynamicParameters param = new DynamicParameters();
            param.Add("@p3", IslemYapan);
            param.Add("@p4", date);
            param.Add("@p5", IslemTuru);
            param.Add("@p6", Aciklama);
            param.Add("@p7", SayfaNo);

            sql = "insert into Log values(@p3,@p4,@p5,@p6,@p7)";
            CUD(param);

            Application.Exit();
        }

        private void DGVMeslek_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void BtnKaydetMeslek_Click(object sender, EventArgs e)
        {
            int IslemYapan = int.Parse(KullaniciId);
            string Aciklama = "Meslek Kaydetme";
            int IslemTuru = 1;
            Aktif = true;
            DynamicParameters param = new DynamicParameters();
            //param adında dynamic bir parametre aluşturduk.
            mukerrerMeslek();
            if (durumMeslek == false)
            {
                DialogResult dialog = MessageBox.Show(TxtMeslek.Text + " Mesleğini kaydetmek istediğinize emin misiniz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialog == DialogResult.Yes)
                {
                    if (TxtMeslek.Text != "")
                    {
                        //try
                        //{
                        param.Add("@p1", TxtMeslek.Text);
                        param.Add("@p2", Aktif);
                        sql = "insert into _Meslek values(@p1,@p2) ";
                        //Tablomuza yeni kayıt eklemek için 'insort into' komutunu kullandık.

                        CUD(param);
                        param.Add("@p3", IslemYapan);
                        param.Add("@p4", date);
                        param.Add("@p5", IslemTuru);
                        param.Add("@p6", Aciklama);
                        param.Add("@p7", SayfaNo);

                        sql = "insert into Log values(@p3,@p4,@p5,@p6,@p7)";
                        CUD(param);
                        kolonDuzenle();
                        MessageBox.Show("Başarıyla Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //}
                        /*catch (Exception)
                        {

                            MessageBox.Show("HATA");
                            connection.Close();
                        }*/
                    }
                    else
                    {
                        MessageBox.Show("Meslek İsmi Yazmadınız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {

                }

            }
            else
            {
                MessageBox.Show("Bu meslek zaten mevcut");
            }



        }

        private void BtnKaydetSehir_Click(object sender, EventArgs e)
        {
            int IslemYapan = int.Parse(KullaniciId);
            string Aciklama = "Şehir Kaydetme";
            int IslemTuru = 1;
            Aktif = true;
            DynamicParameters param = new DynamicParameters();
            //param adında dynamic bir parametre aluşturduk.
            mukerrerSehir();
            if (durumSehir == false)
            {
                if (TxtSehir.Text != "")
                {
                    try
                    {
                        param.Add("@p1", TxtSehir.Text.ToUpper());
                        param.Add("@p2", Aktif);

                        sql = "insert into _Sehir values(@p1,@p2) ";
                        //Tablomuza yeni kayıt eklemek için 'insort into' komutunu kullandık.

                        CUD(param);
                        param.Add("@p3", IslemYapan);
                        param.Add("@p4", date);
                        param.Add("@p5", IslemTuru);
                        param.Add("@p6", Aciklama);
                        param.Add("@p7", SayfaNo);

                        sql = "insert into Log values(@p3,@p4,@p5,@p6,@p7)";
                        CUD(param);
                        kolonDuzenle();
                        MessageBox.Show("Başarıyla Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("HATA");
                    }
                }
                else
                {
                    MessageBox.Show("Şehir İsmi Yazmadınız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Kaydetmek istediğiniz şehir zaten mevcut");
            }
        }

        private void BtnSehirGuncelle_Click(object sender, EventArgs e)
        {
            int IslemYapan = int.Parse(KullaniciId);
            string Aciklama = "Şehir Güncelleme";
            int IslemTuru = 2;
            Aktif = true;
            DynamicParameters param = new DynamicParameters();
            //param adında dynamic bir parametre aluşturduk.
            mukerrerSehir();
            if (durumSehir == false)
            {
                if (TxtSehir.Text != "")
                {
                    try
                    {
                        param.Add("@p1", TxtSehir.Text.ToUpper());
                        param.Add("@p2", int.Parse(LblSehirId.Text));
                        param.Add("@p3", Aktif);
                        sql = "update _Sehir set Ad=@p1 where Id=@p2";
                        //Tablomuza yeni kayıt eklemek için 'insort into' komutunu kullandık.

                        CUD(param);
                        param.Add("@p3", IslemYapan);
                        param.Add("@p4", date);
                        param.Add("@p5", IslemTuru);
                        param.Add("@p6", Aciklama);
                        param.Add("@p7", SayfaNo);

                        sql = "insert into Log values(@p3,@p4,@p5,@p6,@p7)";
                        CUD(param);
                        kolonDuzenle();
                        MessageBox.Show("Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("HATA");
                    }
                }
                else
                {
                    MessageBox.Show("Şehir İsmi Yazmadınız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Şehri güncellemek için önce ismini değiştirmelisiniz");
            }
        }

        void araSehir()
        {
            connection.Open();
            SqlCommand komutMukerrerSehir = new SqlCommand("select * from personelBilgi where SehirId=@p1", connection);
            komutMukerrerSehir.Parameters.AddWithValue("@p1", LblSehirId.Text);
            //komutMukerrer.Parameters.AddWithValue("@p3", TxtSehir.Text);
            //komutMukerrer.Parameters.AddWithValue("@p3", TxtSoyad.Text);
            SqlDataReader drMukerrerSehir = komutMukerrerSehir.ExecuteReader();
            if (drMukerrerSehir.Read())
            {
                durumSehir = true;
            }
            else
            {
                durumSehir = false;
            }
            connection.Close();
        }


        private void BtnSehirSil_Click(object sender, EventArgs e)
        {

            int IslemYapan = int.Parse(KullaniciId);
            string Aciklama = "Şehir Silme";
            int IslemTuru = 3;
            Aktif = false;
            DynamicParameters param = new DynamicParameters();

            araSehir();
            if (durumSehir == false)
            {
                if (TxtSehir.Text != "")
                {
                    try
                    {

                        param.Add("@p1", int.Parse(LblSehirId.Text));
                        param.Add("@p2", Aktif);
                        //sql = "delete from _Sehir where Id=@p1 ";
                        sql = "update _Sehir set Aktif=@p2 where Id=@p1";
                        //personelBilgi tablosundaki Id'si seçilen personelin bilgilerini silme.
                        CUD(param);

                        param.Add("@p3", IslemYapan);
                        param.Add("@p4", date);
                        param.Add("@p5", IslemTuru);
                        param.Add("@p6", Aciklama);
                        param.Add("@p7", SayfaNo);

                        sql = "insert into Log values(@p3,@p4,@p5,@p6,@p7)";
                        CUD(param);
                        kolonDuzenle();
                        DGVSehir.DataSource = connection.Query<Sehirler>("Select * from _Sehir Where Aktif=1");


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
                    MessageBox.Show("Meslek Kısmı Boş");
                }
            }
            else
            {
                MessageBox.Show(TxtSehir.Text + "şehrinde personeliniz bulunduğu için bu şehri silemezsiniz");
            }

        }

        private void DGVSehir_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LblSehirId.Text = DGVSehir.CurrentRow.Cells["Id"].Value.ToString();
            TxtSehir.Text = DGVSehir.CurrentRow.Cells["Ad"].Value.ToString();
        }

        private void BtnMeslekGuncelle_Click(object sender, EventArgs e)
        {

            int IslemYapan = int.Parse(KullaniciId);
            string Aciklama = "Meslek Güncelleme";
            int IslemTuru = 2;
            Aktif = true;
            DynamicParameters param = new DynamicParameters();
            mukerrerMeslek();
            if (durumMeslek == false)
            {

                DialogResult dialog = MessageBox.Show(DGVMeslek.CurrentRow.Cells["Ad"].Value.ToString() + " Mesleğini " + TxtMeslek.Text + " olarak güncellemek istediğinize emin misiniz", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialog == DialogResult.Yes)
                {
                    // param adında dynamic bir parametre aluşturduk.
                    if (TxtMeslek.Text != "")
                    {
                        try
                        {
                            param.Add("@p1", TxtMeslek.Text);
                            param.Add("@p2", int.Parse(LblMeslekId.Text));
                            param.Add("@p3", Aktif);
                            sql = "update _Meslek set Ad=@p1, Aktif=@p3 where Id=@p2";
                            //Tablomuza yeni kayıt eklemek için 'insort into' komutunu kullandık.

                            CUD(param);
                            param.Add("@p3", IslemYapan);
                            param.Add("@p4", date);
                            param.Add("@p5", IslemTuru);
                            param.Add("@p6", Aciklama);
                            param.Add("@p7", SayfaNo);

                            sql = "insert into Log values(@p3,@p4,@p5,@p6,@p7)";
                            CUD(param);
                            kolonDuzenle();

                            MessageBox.Show("Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception)
                        {

                            MessageBox.Show("HATA");
                        }
                    }
                }
                else
                {

                }
            }
            else
            {
                MessageBox.Show("Mesleği güncellemek için meleğin adını değiştirmeniz gerek");
            }


        }
        void araMeslek()
        {
            connection.Open();
            SqlCommand komutMukerrerMeslek = new SqlCommand("select * from personelBilgi where MeslekId=@p1", connection);
            komutMukerrerMeslek.Parameters.AddWithValue("@p1", LblMeslekId.Text);
            SqlDataReader drMukerrerMeeslek = komutMukerrerMeslek.ExecuteReader();
            if (drMukerrerMeeslek.Read())
            {
                durumMeslek = true;
            }
            else
            {
                durumMeslek = false;
            }
            connection.Close();
        }
        private void BtnMeslekSil_Click(object sender, EventArgs e)
        {
            int IslemYapan = int.Parse(KullaniciId);
            string Aciklama = "Meslek Silme";
            int IslemTuru = 3;
            Aktif = false;
            DynamicParameters param = new DynamicParameters();
            araMeslek();
            if (durumMeslek == false)
            {
                if (TxtMeslek.Text != "")
                {
                    DialogResult dialog = MessageBox.Show(DGVMeslek.CurrentRow.Cells["Ad"].Value.ToString() + " Mesleğini silmek istediğinize emin misiniz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialog == DialogResult.Yes)
                    {
                        try
                        {
                            param.Add("@p1", int.Parse(LblMeslekId.Text));
                            param.Add("@p2", Aktif);
                            sql = "update _Meslek set Aktif=@p2 where Id=@p1";
                            //personelBilgi tablosundaki Id'si seçilen personelin bilgilerini silme.
                            CUD(param);

                            param.Add("@p3", IslemYapan);
                            param.Add("@p4", date);
                            param.Add("@p5", IslemTuru);
                            param.Add("@p6", Aciklama);
                            param.Add("@p7", SayfaNo);

                            sql = "insert into Log values(@p3,@p4,@p5,@p6,@p7)";
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

                    }
                }
            }
            else
            {
                MessageBox.Show(TxtMeslek.Text + "mesleğinde personel olduğu için bu mesleği silemezsiniz");
            }

        }

        private void DGVMeslek_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LblMeslekId.Text = DGVMeslek.CurrentRow.Cells["Id"].Value.ToString();
            TxtMeslek.Text = DGVMeslek.CurrentRow.Cells["Ad"].Value.ToString();
        }
    }
}
