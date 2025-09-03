namespace ByteIntDegiskenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Byte ve Int : 

            Byte yas = 22; // 0 ile 255 arasında olan değerleri bu değişken üzerinde taşıyabilirim.
            int seviye = 10000; // -2 milyar ile +2 milyar arasında değer saklar.

            Console.WriteLine(yas);
            Console.WriteLine(seviye);

            Console.WriteLine(byte.MinValue);
            Console.WriteLine(byte.MaxValue);

            //yas = 900;
        }
    }
}
