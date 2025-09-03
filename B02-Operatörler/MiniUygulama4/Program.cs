namespace MiniUygulama4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan bir saat bilgisi alalım. bu saat bilgisinin kaç dakika olduğunu hesaplayalım.

            Console.Write("Dakika değerini istediğiniz saat bilgisini giriniz  : ");
            string kullaniciSaatBilgisi = Console.ReadLine();

            double saatBilgisi = Convert.ToDouble(kullaniciSaatBilgisi);
            int toplamDakika = (int)saatBilgisi * 60;

            Console.WriteLine("Dakika değeri : " + toplamDakika);
            Console.WriteLine($"Dakika değeri : {toplamDakika}");
        }
    }
}
