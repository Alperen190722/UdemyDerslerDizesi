namespace ForeachOrnekUygulama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] alisverislistesi =  { "Ekmek", "Su", "Peynir", "Zeytin" };

            foreach (var item in alisverislistesi) 
            {
                Console.WriteLine(item);
            }
        }
    }
}
