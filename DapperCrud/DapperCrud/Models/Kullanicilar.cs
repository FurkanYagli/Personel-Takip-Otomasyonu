using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperCrud
{
    class Kullanicilar : Entity
    {
        public string Soyad { get; set; }
        public string TC { get; set; }
        public string Tel { get; set; }

        public int KullaniciTuru { get; set; }
        public bool Aktif { get; set; }

    }
}
