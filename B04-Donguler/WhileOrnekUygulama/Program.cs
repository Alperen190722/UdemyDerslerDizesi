namespace WhileOrnekUygulama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal toplam = 0;
            int sayac = 0;
            decimal enDusuk = decimal.MaxValue;
            decimal enYuksek = decimal.MinValue;

            Console.WriteLine("Harcama işlemlerinizi sonlandırmak için bitti değerini girmeniz yeterlidir.");

            while (true) 
            {
                sayac++;
                Console.Write(sayac + ". Harcama Tutarını Giriniz : ");
                string kullaniciHarcama = Console.ReadLine();

                // Kullanıcı bitti ifadesi girişi yapıyorsa döngü kırılır...
                if (kullaniciHarcama == "bitti") 
                {
                    sayac--;
                    break;
                } 

                bool dogruMu = decimal.TryParse(kullaniciHarcama, out decimal harcama);


                if(dogruMu == false) 
                {
                    Console.WriteLine("Geçersiz bir harcama yaptınız !");
                    sayac--;
                    continue;
                }

                if(harcama <= 0) 
                {
                    Console.WriteLine("Harcama tutarınız 0 veya negatif değer olamaz");
                    sayac--;
                    continue;
                }

                toplam += harcama;

                if(harcama > enYuksek) enYuksek = harcama;
                if(harcama < enDusuk) enDusuk = harcama;
            }

            decimal ortalamaHarcama = toplam / sayac;

            Console.WriteLine("Toplam Harcama : " + toplam);
            Console.WriteLine("Ortalama Harcama : " + ortalamaHarcama);
            Console.WriteLine("En Yüksek Harcama : " + enYuksek);
            Console.WriteLine("En Düşük Harcama : " + enDusuk);
        }
    }
}
