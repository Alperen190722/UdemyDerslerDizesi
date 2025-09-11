namespace DizilerBaslangic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[5];
            sayilar[0] = 10;
            sayilar[1] = 20;
            sayilar[2] = 30;
            sayilar[3] = 40;
            sayilar[4] = 50;

            // Dizi elemanlarına erişim işlemleri

            Console.WriteLine(sayilar);
            Console.WriteLine(sayilar[2]);
            Console.WriteLine(sayilar[4]);

            Console.WriteLine("Dizi oluşturma ve değer atama işlemleri tamamlandı-1");

            int[] notlar = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine(notlar[2]);
            Console.WriteLine(notlar[7]);

            int toplam = notlar[1] + notlar[2];
            Console.WriteLine(toplam);

            Console.WriteLine("Dizi oluşturma ve değer atama işlemleri tamamlandı-2");

            int[] yaslar = { 23, 34, 54, 32, 12, 3, 43 };

            Console.WriteLine("Dizi oluşturma ve değer atama işlemleri tamamlandı-3");

            // For döngüsü ile dizi içerisinde dolaşmak

            for (int i = 0; i < yaslar.Length; i++) 
            {
                Console.WriteLine(yaslar[i]);
            }

            // Foreach döngüsü ile değerlerimizi yazdıralım.

            foreach (var item in yaslar)
            {
                Console.WriteLine(item);
            }
        }
    }
}
