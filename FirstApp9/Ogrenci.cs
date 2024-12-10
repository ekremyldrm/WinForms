using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp9
{
    public class Ogrenci
    {
        public string Adi { get; set; }
        public string SoyAdi { get; set; }
        public int Yas { get; set; }
        public string Cinsiyet { get; set; }

        public string Memleket { get; set; }

        public override string ToString()
        {
            return Adi;
        }
    }
}
