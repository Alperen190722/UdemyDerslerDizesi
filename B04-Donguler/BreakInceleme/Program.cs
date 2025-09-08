namespace BreakInceleme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0;
            int hedef = 50;
            for (int i = 1; i <= 100; i++)
            {
             toplam = toplam + i;
              if(toplam >= hedef)
                {
                    break;
                }
            }
        }
    }
}
