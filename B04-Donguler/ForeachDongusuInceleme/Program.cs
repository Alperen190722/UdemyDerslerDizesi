namespace ForeachDongusuInceleme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //foreach (var item in collection)
            //{

            //}

            string[] personeller = { "Hasan", "Mehmet", "Özkan", "Cengiz" };
            foreach (var item in personeller)
            {
                Console.WriteLine(item);
            }
        }
    }
}
