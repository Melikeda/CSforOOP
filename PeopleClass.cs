using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldCS
{
    internal class PeopleClass
    {
        public string ad;
        public string soyad;
        public int id;
        public string sehir;


        public string Ad { get => ad; set => ad = value.ToLower(); }  //BU bir property 
        public string Soyad  // soyas Soyad olamlı yani yukarıdaki gibi aynı yazma 
        { 
            get => soyad; 
            set => soyad = value.ToUpper(); 
        }
    }
}
