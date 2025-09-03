namespace TurDonusumleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Konu : Bilinçli tür dönüşümleri
            // Örnek 1 :
            double doubleDegerI = 56.90;
            int intDegerI = (int) doubleDegerI;
            
            // Örnek 2 :
            long longDegerI = 12345678909;
            int intDegerII = (int) longDegerI;

            // Örnek 3 :
            object objectDegerI = "Alperen Pişkin";
            string metinI = (string) objectDegerI;

            // Konu : Bilinçsiz tür dönüşümleri

            // Örnek 1 :

            int intDegerIII = 9000;
            double doubleDegerII = intDegerIII;

            byte byteDegerIII = 255;
            long longDegerIII = byteDegerIII;

            // Konu : Parse işlemleri...

            string parseVeriI = "45";
            int parseIntI = int.Parse(parseVeriI);

            parseVeriI = null;
            //parseIntI = int.Parse(parseVeriI);
            //bool isok = int.TryParse(parseVeriI, out parseIntI);

            // Convert Işlemleri...

            //string convertmetinI = "90";
            //string convertmetinI = "90A";
            string convertmetinI = null;
            int convertIntI = Convert.ToInt32(convertmetinI);
            Console.WriteLine(convertIntI);

        }
    }
}
