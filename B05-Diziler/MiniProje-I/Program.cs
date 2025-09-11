namespace MiniProje_I
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Toplamak istediğiniz kaç adet sayı vardır ? ");
            int adet = int.Parse(Console.ReadLine());

            int[] sayilar = new int[adet];

            for (int i = 0; i < sayilar.Length; i++) 
            {
                Console.Write(i+1 + ". değeri giriniz : ");
                sayilar[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Tüm değerlerinizi girdiniz. Şimdi toplama işlemini başlatınız. ");

            int toplamDeger = 0;
            foreach (var item in sayilar) 
            {
                toplamDeger += item;
            }

            Console.WriteLine("Toplam :" + toplamDeger);
        }
    }
}
