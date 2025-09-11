namespace IndexOutOfRangeHatasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine(sayilar[3]); // 4
            Console.WriteLine(sayilar[11]);
        }
    }
}
