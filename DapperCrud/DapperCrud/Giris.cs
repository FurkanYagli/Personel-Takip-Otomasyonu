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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DapperCrud
{

    public partial class Giris : Form
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
        SqlConnection baglanti = new SqlConnection("Data Source=FURKANY\\SQLEXPRESS;Initial Catalog=DbPersonel;Integrated Security=True");

        private FrmAnaSayfa formAnasayfa;
        public Giris()
        {
            InitializeComponent();
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


        private void Giris_Load(object sender, EventArgs e)
        {
        }
        bool isThere;
        string kullaniciTuruTxt;


        private void btnGiris_Click(object sender, EventArgs e)
        {

            string TC = maskedTextBoxTC.Text.ToString();
            string Tel = maskedTextBoxTel.Text.ToString();
            int superAdmin = 3;
            int admin = 2;
            int yetkisizKullanici = 1;
            connection.Open();
            SqlCommand komut = new SqlCommand("Select * From kullanici", connection);
            SqlCommand komutKullanicituru = new SqlCommand("Select KullaniciTuru From kullanici Where Id", connection);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (TC == read["TC"].ToString() && Tel == read["Tel"].ToString())
                {
                    isThere = true;
                    break;
                }
                else
                {
                    isThere = false;
                }
            }
            if (isThere)
            {
                string Aktif = read["Aktif"].ToString();
                if (Aktif == "True")
                {
                    DynamicParameters param = new DynamicParameters();

                    DateTime Tarih = DateTime.Now;
                    Random rnd = new Random();

                    int kod = rnd.Next(100000, 999999);
                    string Kod = kod.ToString();
                    string Id = read["Id"].ToString();
                    string kullaniciTuru = read["KullaniciTuru"].ToString();



                    Global.login = Kod;
                    Global.yetki = kullaniciTuru;
                    Global.userId = Id;
                    param.Add("@p1", int.Parse(Id));
                    param.Add("@p2", kod.ToString());
                    param.Add("@p3", Tarih);
                    sql = "insert into GirisHareketleri values (@p1,@p2,@p3)";
                    CUD(param);
                    KodGiris kG = new KodGiris();


                    kG.Show();

                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Kaydınız silindiği için giriş yapamazsınız");
                }


            }
            else
            {
                MessageBox.Show("Hatalı giriş. Lütfen bilgilerinizi kontrol ediniz.");
            }

            connection.Close();



        }
        public string kullaniiciTurunuGetir()
        {


            string TC = maskedTextBoxTC.Text.ToString();
            connection.Open();
            SqlCommand Komut = new SqlCommand("Select * From kullanici", connection);
            SqlDataReader read = Komut.ExecuteReader();
            while (read.Read())
            {
                if (TC == read["TC"].ToString())
                {
                    SqlCommand komutKullaniciTuru = new SqlCommand("Select kullaniciTuru from kullanici where TC", connection);
                    SqlDataReader kullaniciRead = komutKullaniciTuru.ExecuteReader();
                    kullaniciTuruTxt = kullaniciRead["kullaniciTuru"].ToString();

                }
                else
                {
                    kullaniciTuruTxt = "0";
                }

            }
            return kullaniciTuruTxt;

        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void LblKullaniciTuru_Click(object sender, EventArgs e)
        {
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }
    }
}

