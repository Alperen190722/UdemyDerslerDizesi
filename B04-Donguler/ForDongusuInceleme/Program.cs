namespace ForDongusuInceleme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             for(başlangıç; koşul; artış)
            {
               tekrarlanmasını istediğimz işlerimizi bu alana yazarız.
            }
             */
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            int toplam = 0;
            for (int i = 0; i <= 20; i++)
            {
                toplam = toplam + i;
            }
            Console.WriteLine(toplam);
        }
    }
}
