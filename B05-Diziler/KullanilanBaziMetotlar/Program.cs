namespace KullanilanBaziMetotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 1, 23, 4, 2, 22, 12, 56, 76, 77, 89, 7 };

            // Dizimizi ekrana yazdıralım

            Console.WriteLine("Orjinal Dizi Elemanları : " + string.Join(", ",sayilar));

            // Küçük => Büyüğe sıralama

            Array.Sort(sayilar);
            Console.WriteLine("Sıralanmış (Küçük => Büyük) " + string.Join(", ",sayilar));

            // Ters çevirme işlemi
            Array.Reverse(sayilar);
            Console.WriteLine("Ters çevirme işlemi : " + string.Join(", ", sayilar));

            //İndex numarası alma
            int index = Array.IndexOf(sayilar, 12);

            // koleksiyon içerisinde aranan değer var mı yok mu kontrolü nasıl yapılır...

            bool kontrol = false;
            for(int i = 0; i < sayilar.Length; i++) 
            {
                if (sayilar[i] == 56) 
                {
                    kontrol = true;
                }
            }

            Console.WriteLine("Aradığın değer koleksiyon içerisinde : " + kontrol);

            bool kontrol2 = Array.Exists(sayilar, x => x == 5006);
        }
    }
}
