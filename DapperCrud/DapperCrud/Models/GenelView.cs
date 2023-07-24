using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperCrud
{
    class GenelView:Entity
    {
        public string Soyad { get; set; }
        public string Expr2 { get; set; }
        public string Expr1 { get; set; }
        public int Maas { get; set; }
        public DateTime IslemTarihi { get; set; }
        public bool Aktif { get; set; }
    }
}
