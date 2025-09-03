namespace DateTimeDegiskenInceleme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime hazirlikZamani = DateTime.Now.AddDays(-10);
            DateTime siparisZamani = DateTime.Now.AddDays(3);
            DateTime OlusturulmaZamani = DateTime.Now;
            DateTime gonderimZamani = DateTime.Now.AddDays(10);

            Console.WriteLine(hazirlikZamani);
            
        }
    }
}
