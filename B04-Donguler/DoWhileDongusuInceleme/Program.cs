namespace DoWhileDongusuInceleme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //do
            //{
            // döngü bir kez çalışır sonra şart değerine bakılır  
            //} while (true);
            string kullaniciDegeri = "";
            int sayac = 1;
            do
            {
                Console.WriteLine(sayac);
                Console.WriteLine("Döngüden çıkmak için 1 tuşuna basınız");
                kullaniciDegeri = Console.ReadLine();
                sayac++;
            } while (kullaniciDegeri != "1");
        }
    }
}
