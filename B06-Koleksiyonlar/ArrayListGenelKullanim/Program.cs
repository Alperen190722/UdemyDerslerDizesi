using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayListGenelKullanim
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            #region 10 elemanlı ( string ) Arraylis içindeki değerleri Z-A olacak şekilde sıralayın
            ArrayList A3 = new ArrayList();
            A3.Add("B");
            A3.Add("A");
            A3.Add("E");
            A3.Add("C");
            A3.Add("F");
            A3.Add("D");
            A3.Add("H");
            A3.Add("G");
            A3.Add("J");
            A3.Add("I");
            A3.Sort();
            A3.Reverse();


            #endregion

            int Capacity = 0;
            int Count = 0;

            string[] isimler = new string[10];

            ArrayList A1 = new ArrayList();

            #region Tek Değer ekleme
            A1.Add("Alperen Pişkin");

            Capacity = A1.Capacity;
            Count = A1.Count;

            A1.Add(100);
            #endregion

            #region Birden fazla değer ekleme işlemi.
            ArrayList A2 = new ArrayList();
            A2.Add("Yakup");
            A2.Add("Merve");
            A2.Add("Utkan");
            A1.AddRange(A2);

            #endregion

            #region Capacity & Count İnceleme 
            Capacity = A1.Capacity;
            Count = A1.Count;
            #endregion

            #region Koleksiyon içindeki değere ulaşmak
            object O1 = A1[3];
            string S1 = A1[3].ToString();
            int I1 = (int)A1[1];

            A1[3] = "Semih Tecer";
            #endregion

            #region ArrayList Sıralama

            // Dizinin mevcut elemnalarını ters olarak sıralama
            A1.Remove(100);
            A1.Reverse();
            // A-Z Sıralama
            A1.Sort();

            #endregion

            #region Koleksiyonlar yardımcı komutları

            if (A1.Contains("Yakup"))
            {
               int IndexDegeri = A1.IndexOf("Yakup");
               A1.RemoveAt(IndexDegeri);
            }
           

            bool Kontrol1 = A1.Contains("Utkan");
            bool Kontrol2 = A1.Contains(900);

            object[] D1 = A1.ToArray();

            A1.Clear();
            A1.TrimToSize();

            #endregion

            #region ArrayList koleksiyonu içerisindeki değeri silme

            A1.RemoveAt(3);
            A1.RemoveRange(2, 2);
            A1.Remove("Semih Tecer");

            #endregion

           
        }
    }
}
