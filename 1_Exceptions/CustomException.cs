using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Exceptions
{
    public class CustomException : Exception
    {
        //COnstrcutor 
        // constructor parametre alıyor. gelen parametreyi base sınıfının constructor'ina gönderiyoruz..
        public CustomException(string message) : base(message)
        {

        }
    }
}
