namespace ForOrnekUygulama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kaç farklı harcama girişi yapmak istiyorsun : ");
            string strHarcamaAdedi = Console.ReadLine();

            decimal toplam = 0;
            decimal enYuksek = decimal.MinValue;
            decimal enDusuk = decimal.MaxValue;
            int adet = int.Parse(strHarcamaAdedi);

            for ( int i = 1; i <= adet; i++)
            {
                Console.Write(i + ". harcama tutarını giriniz ₺ : ");

                //string strHarcamaTutari = Console.ReadLine();
                //decimal harcama = decimal.Parse(strHarcamaTutari);

                bool harcamaTutariDogruMu = decimal.TryParse(Console.ReadLine(), out decimal harcama);

                if (harcamaTutariDogruMu == false) 
                {
                    Console.WriteLine("Geçersiz bir giriş yaptınız !");
                    i--;
                    continue;
                }

                if (harcama <= 0) 
                {
                    Console.WriteLine("Harcama değeriniz 0 veya altında olmamalıdır. ");
                    i--;
                    continue;
                }

                //toplam = toplam + harcama; // 1.Yol
                toplam += harcama; // 2.Yol

                if (harcama > enYuksek) enYuksek = harcama; // *

                if (harcama < enDusuk) enDusuk = harcama;

            }

            decimal ortalamaHarcama = toplam / adet;

            Console.WriteLine("Toplam Harcama : " + toplam);
            Console.WriteLine("Ortalama Harcama : " + ortalamaHarcama);
            Console.WriteLine("En Yüksek Harcama : " + enYuksek);
            Console.WriteLine("En Düşük Harcama : " + enDusuk);
        }
    }
}
