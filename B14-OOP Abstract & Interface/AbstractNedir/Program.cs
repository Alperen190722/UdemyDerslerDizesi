using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractNedir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            superMusteri SP1 = new superMusteri();
            SP1.testAbstract();

            // temelSinif T1 = new temelSiniif();
            Musteri M1 = new Musteri();
            M1.test();
            M1.testAbstract();
        }
    }
}
