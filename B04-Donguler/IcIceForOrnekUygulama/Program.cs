namespace IcIceForOrnekUygulama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1
             * 1.1 - 1.2 - 1.3 .. 1.5
             * 
             * 2
             * 
             * 3
             * 
             * 
             * 10
             */

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);// 1 ... 10

                for (int x = 0; x <= 5; x++)
                {
                    //Console.WriteLine(i + "." + x); Eski tarz kullanım
                    Console.Write($"{i}.{x}");

                    if(x<5) Console.Write(" - ");
                }
                Console.WriteLine();
            }
        }
    }
}
