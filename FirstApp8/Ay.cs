using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ObjectiveC;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp8
{
    public class Ay
    {
        public string Text { get; set; }
        public int Value { get; set; }



        // bir referrans tip ekranda gösterilmeye çalıştırıldığında c# yapısı itibari ile output olan varlıkları çalışma zamanında string'e dönüştürür...


        // bu referans tipi stringe dönüştürme işleminde namespace adı, sınıf adı şeklinde bir text oluştururur....

        // c# dilinde bütün tipler objectten türediği için (gizli bir kalıtımv var) object sınıfın ToString metodu ile bu duruma müdahele edebiliriz...

        // object sınıfındaki virtual metot olan ToString'i çağırıyoruz...

        public override string ToString()
        {
            return Text;
        }
    }
}