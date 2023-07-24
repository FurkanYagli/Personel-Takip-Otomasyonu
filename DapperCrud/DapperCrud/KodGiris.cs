using Dapper;
using DapperCrud.Resources;
//using DapperCrud.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DapperCrud
{
    public partial class KodGiris : Form
    {
        public KodGiris()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);

        public string GelenDeger { get; set; }
        public string kodGelen { get; set; }
        public string IdGetir { get; set; }
        DateTime Tarih = DateTime.Now;
        private void KodGiris_Load(object sender, EventArgs e)
        {

        }
        string Id = Global.userId;
        string Kod = Global.login;
        string KullaniciTuru = Global.yetki;

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            FrmAnaSayfa fr = new FrmAnaSayfa();
            if (Kod == TxtKod.Text)
            {
                if (KullaniciTuru == "1")
                {

                    FrmPersonel personelKayit = new FrmPersonel();
                    personelKayit.Show();


                    this.Hide();
                }
                else if (KullaniciTuru == "2")
                {
                    fr.Show();
                    this.Hide();
                }
                else if (KullaniciTuru == "3")
                {
                    fr.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı giriş yaptınız");
                }
            }
            else
            {
                MessageBox.Show("Hatalı giriş yaptınız lütfen yeniden deneyin yada yeni kod isteyin");
            }
        }
        string sql = "";
        void CUD(DynamicParameters dynamic = null)
        {
            connection.Close();
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
        }
        private void BtnYeniKod_Click(object sender, EventArgs e)
        {
            DynamicParameters param = new DynamicParameters();
            Random rnd = new Random();
            int kod = rnd.Next(100000, 999999);
            param.Add("@p1", int.Parse(Id));
            param.Add("@p2", Kod);
            param.Add("@p3", Tarih);
            sql = "insert into GirisHareketleri values (@p1,@p2,@p3)";
            CUD(param);
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            int IslemYapan = int.Parse(Id);
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

        private void LblId_Click(object sender, EventArgs e)
        {

        }
    }
}
