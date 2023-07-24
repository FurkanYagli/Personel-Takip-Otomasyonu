using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperCrud
{
    class Personeller : Entity
    {
        public string Soyad { get; set; }
        public string SehirId { get; set; }
        public int Maas { get; set; }
        public string MeslekId { get; set; }
        public bool Aktif { get; set; }
    }
}
