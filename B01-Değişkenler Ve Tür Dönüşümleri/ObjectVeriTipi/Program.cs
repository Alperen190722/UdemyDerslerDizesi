namespace ObjectVeriTipi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object ObjectV1 = 10;
            object ObjectV2 = "Merhaba";
            object ObjectV3 = true;
            object ObjectV4 = 45.45;

            int Sayi1 = 100;
            object ObjectV5 = Sayi1;// Boxing = Kutulama
            int Sayi2 = (int)ObjectV5;// Unoxing = Kutudan çıkartma

            var x = 45.45;
            // x = "Merhaba";

            dynamic d1 = "Merhaba Dünya";

            Console.WriteLine(d1);

            d1 = true;

            Console.WriteLine(d1);

            Console.WriteLine(d1.EkranaYaz());
        }
    }
}
