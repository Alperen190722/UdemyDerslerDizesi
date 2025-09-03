namespace IfOrnekKullanım3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             
            Kullanıcıdan 3 adet not değeri isteyelim. bu not değerlerinin ortalamasını bulalım
            ve ortalama değeri

            90 >= AA
            80 >= BA
            70 >= BB
            60 >= CB
            60 < FF
       
             */

            Console.Write("1. notu giriniz : ");
            string kullaniciNot1 = Console.ReadLine();
            Console.Write("2. notu giriniz : ");
            string kullaniciNot2 = Console.ReadLine();
            Console.Write("3. notu giriniz : ");
            string kullaniciNot3 = Console.ReadLine();

            double sonuc = 0;
            double not1 = Convert.ToDouble(kullaniciNot1);
            double not2 = Convert.ToDouble(kullaniciNot2);
            double not3 = Convert.ToDouble(kullaniciNot3);

            sonuc = (not1 + not2 + not3) / 3;

            if (sonuc >= 90)
            {
                Console.WriteLine("Harf Notu : AA");
            }
            else if (sonuc >= 80)
            {
                Console.WriteLine("Harf Notu : BA");
            }
            else if (sonuc >= 70)
            {
                Console.WriteLine("Harf Notu : BB");
            }
            else if (sonuc >= 60)
            {
                Console.WriteLine("Harf Notu : CB");
            }
            else
            {
                Console.WriteLine("Harf Notu : FF");
            }
        }
    }
}
