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

    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
            //visual Studio'da tasarladığımız Windows Form, WPF gibi görsel arayüzlerin oluşturulması için kullanılan bir yöntemdir.
        }
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);        //Veri tabanımıza bağlantı sağlar.
        string sql = "";
        string sqlHareket = "";
        string patternAd = @"^(?!.*\d)(?!.*[_!@#$%^&*()+\=\[\]{};':""\\|,.<>\/?]).*[a-zA-ZğıüşöçİĞÜŞÖÇ]+\s*[a-zA-ZğıüşöçİĞÜŞÖÇ\s]*$";

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
            dataGridView1.DataSource = connection.Query<GenelView>("Select * from genel");
            dataGridView1.Columns["Id"].Visible = false;
            comboBoxMeslek.DataSource = connection.Query<Meslekler>("Select * from _Meslek");
            comboBoxSehir.DataSource = connection.Query<Sehirler>("Select * from _Sehir");
            //dataGridView1'e personelBilgi tablosundaki tüm verileri çekiyoruz.
            //comboBoxSehir.DataSource = connection.Query<Sehirler>("Select * from iller");

        }
        DateTime dateIslemTarihi = DateTime.Now;
        /* public int getirId()
         {
             using (var sqlConnection = new SqlConnection(@"Data Source=FURKANY\\SQLEXPRESS;Initial Catalog=DbPersonel;Integrated Security=True"))
             {
                 var identity = sqlConnection.QuerySingle<int>("INSERT INTO [dbo].[MyEntities] (Text) output inserted.Id VALUES (@Text);"
                     , new MyEntity { Text = "this is a text" });
             }
             return 
         }*/
        void perHareket(DynamicParameters dynamic = null)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();//Veri tabanı bağlantısını aç.
                //connection.State özelliği,C# programında bir veritabanı bağlantısının durumunu kontrol etmek için kullanılan bir özelliktir.
            }
            connection.Execute(sqlHareket, dynamic, commandType: CommandType.Text);
            //connection.Execute komutu bağlantı açıldı ve bir sorgu çalıştırılıyor anlamına gelir.
            connection.Close();//Bağlantıyı Kapat.

            sql = "select ";
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            dataGridView1.DataSource = connection.Query<GenelView>("Select * from genel");
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["Aktif"].Visible = false;
            dataGridView1.Columns["IslemTarihi"].Visible = false;
            comboBoxMeslek.DataSource = connection.Query<Meslekler>("Select * from _Meslek");
            comboBoxSehir.DataSource = connection.Query<Sehirler>("Select * from _Sehir");
            //dataGridView1'e personelBilgi tablosundaki tüm verileri çekiyoruz.
            //comboBoxSehir.DataSource = connection.Query<Sehirler>("Select * from iller");

        }
        public void SehirCagir()
        {
            connection.Open();
            SqlCommand komutSehir = new SqlCommand("select * from _Sehir", connection);
            SqlDataAdapter daSehir = new SqlDataAdapter(komutSehir);
            DataTable dtSehir = new DataTable();
            daSehir.Fill(dtSehir);
            comboBoxSehir.ValueMember = "Id";
            comboBoxSehir.DisplayMember = "Ad";
            comboBoxSehir.DataSource = dtSehir;
            connection.Close();
            comboBoxDuzenle();
        }
        public void MeslekCagir()
        {

            connection.Open();
            SqlCommand komutMeslek = new SqlCommand("select * from _Meslek", connection);
            SqlDataAdapter daMeslek = new SqlDataAdapter(komutMeslek);
            DataTable dtMeslek = new DataTable();
            daMeslek.Fill(dtMeslek);
            comboBoxMeslek.ValueMember = "Id";
            comboBoxMeslek.DisplayMember = "Ad";
            comboBoxMeslek.DataSource = dtMeslek;
            connection.Close();
            //comboBoxMeslek.Text = "Seçiniz";
            comboBoxDuzenle();
        }
        public void comboBoxDuzenle()
        {
            comboBoxMeslek.SelectedIndex = -1;
            comboBoxMeslek.Text = "Meslek Seçiniz";
            comboBoxSehir.SelectedIndex = -1;
            comboBoxSehir.Text = "Şehir Seçiniz";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        void KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        void Duzenle()
        {
            dataGridView1.KeyPress += KeyPress;
            comboBoxMeslek.DropDownStyle = ComboBoxStyle.DropDown;
            comboBoxMeslek.KeyPress += KeyPress;
            comboBoxSehir.DropDownStyle = ComboBoxStyle.DropDown;
            comboBoxSehir.KeyPress += KeyPress;
            LblId.Visible = false;
            LblAktiflikDurumu.Visible = false;
            TxtId.Visible = false;
            TxtAktiflikDurumu.Visible = false;
        }
        void kolonDuzenle()
        {
            dataGridView1.Columns["Id"].DisplayIndex = 0;
            dataGridView1.Columns["Ad"].DisplayIndex = 1;
            dataGridView1.Columns["Soyad"].DisplayIndex = 2;
            dataGridView1.Columns["Expr2"].DisplayIndex = 3;
            dataGridView1.Columns["Expr1"].DisplayIndex = 4;
            dataGridView1.Columns["Maas"].DisplayIndex = 5;
            DataGridViewColumn kolonMeslek = dataGridView1.Columns["Expr1"];
            DataGridViewColumn kolonSehir = dataGridView1.Columns["Expr2"];
            DataGridViewColumn kolonMaas = dataGridView1.Columns["Maas"];
            kolonMeslek.HeaderText = "Meslek";
            kolonSehir.HeaderText = "Şehir";
            kolonMaas.HeaderText = "Maaş";
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["Aktif"].Visible = false;
            if (KullaniciTuru == "2")
            {
                dataGridView1.Columns["Aktif"].Visible = true;
            }
            else if (KullaniciTuru == "3")
            {
                dataGridView1.Columns["Aktif"].Visible = true;
            }
            TxtId.Enabled = false;
            //TxtId isimli TextBox'a değer girilmesini kapattık.
            if (KullaniciTuru == "1")
            {
                BtnAktiflik.Visible = false;
                BtnAnaSayfa.Enabled = false;
                BtnAnaSayfa.Visible = false;
                dataGridView1.DataSource = connection.Query<GenelView>("Select * from genel where Aktif = 1");
            }
            else if (KullaniciTuru == "2")
            {
                //dataGridView1.Columns["Aktif"].Visible = true;
                BtnAktiflik.Visible = false;
                dataGridView1.DataSource = connection.Query<GenelView>("Select * from genel");

            }
            else if (KullaniciTuru == "3")
            {
                //dataGridView1.Columns["Aktif"].Visible = true;
                dataGridView1.DataSource = connection.Query<GenelView>("Select * from genel");
            }
            dataGridView1.ReadOnly = true;

        }

        int SayfaNo = 4;
        string KullaniciId = Global.userId;
        string KullaniciTuru = Global.yetki;

        private void DapperCrud_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = connection.Query<GenelView>("Select * from genel where Aktif = 1");

            Duzenle();
            kolonDuzenle();
            MeslekCagir();
            SehirCagir();
        }

        void trimAdSoyad()
        {
            TxtSoyad.Text = TxtSoyad.Text.Trim();
            TxtAd.Text = TxtAd.Text.Trim();
        }
        private string GetInsertCommand(string ad, string soyad, string sehir, int maas, string meslek)
        {
            string sql = "insert into personelBilgi values(@p1, @p2, @p3, @p4, @p5)";
            DynamicParameters param = new DynamicParameters();

            trimAdSoyad(); // Assuming this is a method that trims ad and soyad values.

            if (!string.IsNullOrWhiteSpace(ad) && ad.Length > 1 && !ad.StartsWith(" ") && !ad.EndsWith(" ") && Regex.IsMatch(ad, patternAd))
            {
                param.Add("@p1", ad);
            }
            else
            {
                // Handle invalid ad value
                // MessageBox.Show("Hata");
            }

            if (!string.IsNullOrWhiteSpace(soyad) && soyad.Length > 1 && !soyad.Contains(" ") && Regex.IsMatch(soyad, patternAd))
            {
                param.Add("@p2", soyad);
            }
            else
            {
                // Handle invalid soyad value
                // MessageBox.Show("Hata");
            }

            param.Add("@p3", sehir);
            param.Add("@p4", maas);
            param.Add("@p5", meslek);

            return sql;
        }
        private void BtnSil_Click(object sender, EventArgs e)
        {
            DynamicParameters param = new DynamicParameters();
            int IslemTuru = 3;
            int IslemYapan = int.Parse(KullaniciId);
            string IslemYapilan = "Personel Silme";
            DialogResult dialog = MessageBox.Show(TxtAd.Text + " Adlı kişiyi silmek istediğinize emin misiniz", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            {
                try
                {
                    bool aktifPasif = false;
                    param.Add(@"p10", aktifPasif);
                    param.Add(@"p1", TxtAd.Text);
                    param.Add(@"p2", TxtSoyad.Text);
                    param.Add("@p3", comboBoxSehir.SelectedValue);
                    param.Add("@p4", Convert.ToInt32(TxtMaas.Text));
                    param.Add("@p5", comboBoxMeslek.SelectedValue);
                    param.Add("@p6", int.Parse(TxtId.Text));
                    param.Add("@p7", dateIslemTarihi);
                    param.Add("@p8", IslemTuru);
                    param.Add("@p9", IslemYapan);
                    param.Add("@p11", IslemYapan);
                    param.Add("@p12", IslemYapilan);
                    param.Add("@p13", SayfaNo);

                    sqlHareket = "insert into personelHareketleri values (@p6,@p1,@p2,@p3,@p4,@p5,@p7,@p8,@p9)";
                    sql = "update personelBilgi set  IslemTarihi=@p7, Aktif=@p10 where Id=@p6";
                    //personelBilgi tablosundaki Id'si seçilen personelin bilgilerini silme.
                    CUD(param);
                    perHareket(param);
                    sql = "insert into Log values(@p11,@p7,@p8,@p12,@p13)";
                    CUD(param);
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
            kolonDuzenle();
        }
        //string IslemYapan = "11111111111";
        private void BtnGuncelle_Click_1(object sender, EventArgs e)
        {
            int IslemYapan = int.Parse(KullaniciId);
            string IslemYapilan = "Personel Güncelleme";
            int IslemTuru = 2;
            bool aktifPasif = true;
            // string IslemYapan = LblKullaniciId.Text;

            DialogResult dialog = MessageBox.Show(dataGridView1.CurrentRow.Cells[5].Value.ToString() + " Adlı kişiyi Ad:" + dataGridView1.CurrentRow.Cells[5].Value.ToString() + " Soyad:" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + " Şehir:" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + " Meslek:" + dataGridView1.CurrentRow.Cells[2].Value.ToString() + " Maaş:" + dataGridView1.CurrentRow.Cells[3].Value.ToString() + " " + " bilgilerinden" + " Ad:" + TxtAd.Text + " Soyad:" + TxtSoyad.Text + " Şehir:" + comboBoxSehir.Text + " Meslek:" + comboBoxMeslek.Text + " Maaş:" + TxtMaas.Text + " bilgilerine güncellemek istediğinize emin misiniz", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            {
                try
                {

                    DynamicParameters param = new DynamicParameters();
                    trimAdSoyad();
                    if (!string.IsNullOrWhiteSpace(TxtAd.Text) && TxtAd.Text.Length > 1 && !TxtAd.Text.StartsWith(" ") && !TxtAd.Text.EndsWith(" ") && Regex.IsMatch(TxtAd.Text, patternAd))
                    {
                        param.Add("@p1", TxtAd.Text);
                    }
                    else
                    {
                        //MessageBox.Show("Hata");
                    }
                    if (!string.IsNullOrWhiteSpace(TxtSoyad.Text) && TxtSoyad.Text.Length > 1 && !TxtSoyad.Text.Contains(" ") && Regex.IsMatch(TxtSoyad.Text, patternAd))
                    {
                        param.Add("@p2", TxtSoyad.Text);
                    }
                    else
                    {
                        //MessageBox.Show("Hata");
                    }
                    //p1 parametresine TxtAd'a girlen bilgiyi ata.
                    param.Add("@p3", comboBoxSehir.SelectedValue);
                    param.Add("@p4", Convert.ToInt32(TxtMaas.Text));
                    param.Add("@p5", comboBoxMeslek.SelectedValue);
                    param.Add("@p6", int.Parse(TxtId.Text));
                    param.Add("@p7", dateIslemTarihi);
                    param.Add("@p8", IslemTuru);
                    param.Add("@p9", IslemYapan);
                    param.Add("@p10", aktifPasif);
                    param.Add("@p11", IslemYapan);
                    param.Add("@p12", IslemYapilan);
                    param.Add("@p13", SayfaNo);

                    sqlHareket = "insert into personelHareketleri values (@p6,@p1,@p2,@p3,@p4,@p5,@p7,@p8,@p9)";
                    sql = "update personelBilgi set Ad=@p1, Soyad=@p2, SehirId=@p3, Maas=@p4, MeslekId=@p5, IslemTarihi=@p7, Aktif=@p10 where Id=@p6";
                    //personel bilgisini güncelledik.

                    CUD(param);
                    perHareket(param);
                    sql = "insert into Log values(@p11,@p7,@p8,@p12,@p13)";
                    CUD(param);
                    MessageBox.Show("Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comboBoxDuzenle();
                }
                catch (Exception ex)
                {
                    TxtAd.Text.Trim();
                    TxtSoyad.Text.Trim();
                    MessageBox.Show("HATA: " + ex.Message);
                }
            }
            kolonDuzenle();

        }
        bool durum;
        void mukerrer()
        {
            connection.Open();
            SqlCommand komutMukerrer = new SqlCommand("select * from personelBilgi where Ad=@p2 AND Soyad=@p3", connection);
            komutMukerrer.Parameters.AddWithValue("@p2", TxtAd.Text);
            komutMukerrer.Parameters.AddWithValue("@p3", TxtSoyad.Text);
            //komutMukerrer.Parameters.AddWithValue("@p3", TxtSoyad.Text);
            SqlDataReader drMukerrer = komutMukerrer.ExecuteReader();
            if (drMukerrer.Read())
            {
                durum = true;
            }
            else
            {
                durum = false;
            }
            connection.Close();
        }

        private void BtnEkle_Click_1(object sender, EventArgs e)
        {
            int IslemTuru = 1;
            bool aktifPasif = true;
            int IslemYapan = int.Parse(KullaniciId);
            string IslemYapilan = "Personel Ekleme";
            mukerrer();
            //param adında dynamic bir parametre aluşturduk.
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
                            param.Add("@p1", TxtAd.Text);
                        }
                        else
                        {
                            //MessageBox.Show("Hata");
                        }
                        if (!string.IsNullOrWhiteSpace(TxtSoyad.Text) && TxtSoyad.Text.Length > 1 && !TxtSoyad.Text.Contains(" ") && Regex.IsMatch(TxtSoyad.Text, patternAd))
                        {
                            param.Add("@p2", TxtSoyad.Text);
                        }
                        else
                        {
                            //MessageBox.Show("Hata");
                        }
                        param.Add("@p3", comboBoxSehir.SelectedValue);
                        param.Add("@p4", int.Parse(TxtMaas.Text));
                        param.Add("@p5", comboBoxMeslek.SelectedValue);
                        //param.Add("@p6", int.Parse(TxtId.Text));
                        param.Add("@p7", dateIslemTarihi);
                        param.Add("@p8", IslemTuru);
                        //param.Add("@p9", IslemYapan);
                        param.Add("@p10", aktifPasif);
                        param.Add("@p11", IslemYapan);
                        param.Add("@p12", IslemYapilan);
                        param.Add("@p13", SayfaNo);

                        sql = "insert into personelBilgi values(@p1,@p2,@p3,@p4,@p5,@p7,@p10)";
                        //perHareket(param);
                        CUD(param);
                        sql = "insert into Log values(@p11,@p7,@p8,@p12,@p13)";
                        CUD(param);
                        comboBoxDuzenle();
                        //try
                        //{
                        /* this.Refresh();
                         dataGridView1.ClearSelection(); // Önce tüm seçimleri temizleyin
                         int lastRowIndex = dataGridView1.Rows.Count - 1; // Son satırın indeksini alın
                         dataGridView1.Rows[lastRowIndex].Selected = true; // Son satırı seçin
                         dataGridView1.FirstDisplayedScrollingRowIndex = lastRowIndex; // Son satırı görünür hale getirin (eğer gerekiyorsa)
                         if (dataGridView1.Rows.Count > 0)
                         {
                             DataGridViewRow lastRow = dataGridView1.Rows[dataGridView1.Rows.Count - 1];

                             // DataGridView'in son satırını seçin
                             dataGridView1.ClearSelection();
                             lastRow.Selected = true;

                         // TextBox'lara verileri aktarın
                         //getirId();
                         TxtId.Text = lastRow.Cells["Id"].Value.ToString();
                         TxtAd.Text = lastRow.Cells["Ad"].Value.ToString();
                         TxtSoyad.Text = lastRow.Cells["Soyad"].Value.ToString();
                         comboBoxSehir.Text = lastRow.Cells["Expr2"].Value.ToString();
                         TxtMaas.Text = lastRow.Cells["Maas"].Value.ToString();
                         comboBoxMeslek.Text = lastRow.Cells["Expr1"].Value.ToString();
                         param.Add("@p1", TxtAd.Text);
                         param.Add("@p2", TxtSoyad.Text);
                         param.Add("@p3", comboBoxSehir.SelectedValue);
                         param.Add("@p4", int.Parse(TxtMaas.Text));
                         param.Add("@p5", comboBoxMeslek.SelectedValue);
                         param.Add("@p6", int.Parse(TxtId.Text));
                         param.Add("@p7", dateIslemTarihi);
                         param.Add("@p8", IslemTuru);
                         param.Add("@p9", IslemYapan);
                         param.Add("@p10", aktifPasif);
                         sqlHareket = "insert into personelHareketleri values (@p6,@p1,@p2,@p3,@p4,@p5,@p7,@p8,@p9)";
                         perHareket(param);
                         }*/

                        //}
                        /*catch (Exception)
                        {

                            MessageBox.Show("Personel Hareketliliği eklenemedi.");
                        }*/

                        MessageBox.Show("Başarıyla Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {



                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
                //this.Refresh();
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Personelleriniz arasında " + TxtAd.Text + " " + TxtSoyad.Text + " zatene mevcut yeniden eklemek istediğinize emin misiniz", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialog == DialogResult.Yes)
                {
                    try
                    {
                        DynamicParameters param = new DynamicParameters();
                        TxtAd.Text = TxtAd.Text.Trim();
                        TxtSoyad.Text = TxtSoyad.Text.Trim();
                        if (!string.IsNullOrWhiteSpace(TxtAd.Text) && TxtAd.Text.Length > 1 && !TxtAd.Text.StartsWith(" ") && !TxtAd.Text.EndsWith(" ") && Regex.IsMatch(TxtAd.Text, patternAd))
                        {
                            param.Add("@p1", TxtAd.Text);
                        }
                        else
                        {
                            //MessageBox.Show("Hata");
                        }
                        if (!string.IsNullOrWhiteSpace(TxtSoyad.Text) && TxtSoyad.Text.Length > 1 && !TxtSoyad.Text.Contains(" ") && Regex.IsMatch(TxtSoyad.Text, patternAd))
                        {
                            param.Add("@p2", TxtSoyad.Text);
                        }
                        else
                        {
                            //MessageBox.Show("Hata");
                        }
                        param.Add("@p3", comboBoxSehir.SelectedValue);
                        param.Add("@p4", int.Parse(TxtMaas.Text));
                        param.Add("@p5", comboBoxMeslek.SelectedValue);
                        param.Add("@p6", int.Parse(TxtId.Text));
                        param.Add("@p7", dateIslemTarihi);
                        param.Add("@p8", IslemTuru);
                        param.Add("@p9", IslemYapan);
                        param.Add("@p10", aktifPasif);
                        param.Add("@p11", IslemYapan);
                        param.Add("@p12", IslemYapilan);
                        param.Add("@p13", SayfaNo);

                        sql = "insert into personelBilgi values(@p1,@p2,@p3,@p4,@p5,@p7,@p10)";
                        //Tablomuza yeni kayıt eklemek için 'insort into' komutunu kullandık.

                        CUD(param);

                        sql = "insert into Log values(@p11,@p7,@p8,@p12,@p13)";
                        CUD(param);
                        comboBoxDuzenle();
                        kolonDuzenle();
                        // this.Refresh();
                        /* try
                         {
                             dataGridView1.ClearSelection(); // Önce tüm seçimleri temizleyin
                             int lastRowIndex = dataGridView1.Rows.Count - 1; // Son satırın indeksini alın
                             dataGridView1.Rows[lastRowIndex].Selected = true; // Son satırı seçin
                             dataGridView1.FirstDisplayedScrollingRowIndex = lastRowIndex; // Son satırı görünür hale getirin (eğer gerekiyorsa)
                             if (dataGridView1.Rows.Count > 0)
                             {
                                 DataGridViewRow lastRow = dataGridView1.Rows[dataGridView1.Rows.Count - 1];

                                 // DataGridView'in son satırını seçin
                                 dataGridView1.ClearSelection();
                                 lastRow.Selected = true;

                                 // TextBox'lara verileri aktarın
                                 TxtId.Text = lastRow.Cells["Id"].Value.ToString();
                                 TxtAd.Text = lastRow.Cells["Ad"].Value.ToString();
                                 TxtSoyad.Text = lastRow.Cells["Soyad"].Value.ToString();
                                 comboBoxSehir.Text = lastRow.Cells["Expr2"].Value.ToString();
                                 TxtMaas.Text = lastRow.Cells["Maas"].Value.ToString();
                                 comboBoxMeslek.Text = lastRow.Cells["Expr1"].Value.ToString();
                                 param.Add("@p1", TxtAd.Text);
                                 param.Add("@p2", TxtSoyad.Text);
                                 param.Add("@p3", comboBoxSehir.SelectedValue);
                                 param.Add("@p4", int.Parse(TxtMaas.Text));
                                 param.Add("@p5", comboBoxMeslek.SelectedValue);
                                 param.Add("@p6", int.Parse(TxtId.Text));
                                 param.Add("@p7", dateIslemTarihi);
                                 param.Add("@p8", IslemTuru);
                                 param.Add("@p9", IslemYapan);
                                 param.Add("@p10", aktifPasif);
                                 sqlHareket = "insert into personelHareketleri values (@p6,@p1,@p2,@p3,@p4,@p5,@p7,@p8,@p9)";
                                 perHareket(param);
                             }*/

                        /*}
                        catch (Exception)
                        {

                            MessageBox.Show("Personel Hareketliliği eklenemedi.");
                        }*/

                        MessageBox.Show("Başarıyla Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        kolonDuzenle();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
                else
                {

                }
            }
            kolonDuzenle();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridView1'de tıkladığımız personelin bilgilerini ilgili TextBoxlara gönderme.
            TxtId.Text = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
            TxtAktiflikDurumu.Text = dataGridView1.CurrentRow.Cells["Aktif"].Value.ToString();
            TxtAd.Text = dataGridView1.CurrentRow.Cells["Ad"].Value.ToString();
            TxtSoyad.Text = dataGridView1.CurrentRow.Cells["Soyad"].Value.ToString();
            comboBoxSehir.Text = dataGridView1.CurrentRow.Cells["Expr2"].Value.ToString();
            TxtMaas.Text = dataGridView1.CurrentRow.Cells["Maas"].Value.ToString();
            comboBoxMeslek.Text = dataGridView1.CurrentRow.Cells["Expr1"].Value.ToString();


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

        private void comboBoxSehir_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBoxMeslek_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TxtMaas_TextChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
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
            Application.Exit();
        }

        private void BtnClose_Click(object sender, EventArgs e)
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

        private void simpleButton2_Click(object sender, EventArgs e)
        {

            DateTime date = DateTime.Now;
            int IslemYapan = int.Parse(KullaniciId);
            int SayfaNo = 2;
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

        private void button1_Click(object sender, EventArgs e)
        {
            int IslemTuru = 6;
            int IslemYapan = int.Parse(KullaniciId);
            string IslemYapilan = "Personel aktif etme";
            DynamicParameters param = new DynamicParameters();
            bool aktifPasif = true;
            param.Add(@"p10", aktifPasif);
            param.Add(@"p1", TxtAd.Text);
            param.Add(@"p2", TxtSoyad.Text);
            param.Add("@p3", comboBoxSehir.SelectedValue);
            param.Add("@p4", Convert.ToInt32(TxtMaas.Text));
            param.Add("@p5", comboBoxMeslek.SelectedValue);
            param.Add("@p6", int.Parse(TxtId.Text));
            param.Add("@p7", dateIslemTarihi);
            param.Add("@p8", IslemTuru);
            param.Add("@p9", IslemYapan);
            param.Add("@p11", IslemYapan);
            param.Add("@p12", IslemYapilan);
            param.Add("@p13", SayfaNo);

            sqlHareket = "insert into personelHareketleri values (@p6,@p1,@p2,@p3,@p4,@p5,@p7,@p8,@p9)";
            sql = "update personelBilgi set  IslemTarihi=@p7, Aktif=@p10 where Id=@p6";
            //personelBilgi tablosundaki Id'si seçilen personelin bilgilerini silme.
            CUD(param);
            perHareket(param);
            sql = "insert into Log values(@p11,@p7,@p8,@p12,@p13)";
            CUD(param);
            kolonDuzenle();
            MessageBox.Show("Başarıyla Aktifleştirildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
