namespace ContinueInceleme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0;

            for (int i = 0; i < 10; i++)
            {
                if (i % 2 != 0) 
                {
                    continue;
                }
                toplam = toplam + i;
            }
            Console.WriteLine(toplam);
        }
    }
}
