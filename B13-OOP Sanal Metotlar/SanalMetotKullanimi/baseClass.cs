using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanalMetotKullanimi
{
    public class baseClass
    {
        public baseClass()
        {
            Console.WriteLine("base class");
        }
        public virtual void ekranaYaz(string data) 
        {
            Console.WriteLine(data);
        }
    }
}
