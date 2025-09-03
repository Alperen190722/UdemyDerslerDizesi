namespace MantiksalOperatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 20;

            bool esitmi = sayi1 == sayi2;

            bool a = true;
            bool b = false;

            // && ve - and operatorü
            bool veKontrolI = a == true && b == false;
            // True + True = True
            // True + False = False
            // False + True = False

            // || veya - or operatörü

            bool veyaKontrol = a == true || b == true;
            // True + True = True
            // False + True = True
            // True + False = True
            // False + False = False
        }
    }
}
