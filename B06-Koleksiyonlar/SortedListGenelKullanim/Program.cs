using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedListGenelKullanim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList SortedL = new SortedList();


            SortedL.Add(100, "Yüz");
            SortedL.Add(90, "Doksan");
            SortedL.Add(1, "Bir");
            SortedL.Add(9000 , "Dokuz Bin");
            // SortedL.Add("A", "B");
        }
    }
}
