namespace MiniUygulama1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Merhaba, İsminizi Giriniz ");
            string kullaniciIsim = Console.ReadLine();

            Console.WriteLine(kullaniciIsim + " notlarınızı hesaplamak için lütfen giriş yapınız");

            Console.Write("1. not değerinizi giriniz : ");
            string strNot1 = Console.ReadLine();

            Console.Write("2. Not değerinizi giriniz : ");
            string strNot2 = Console.ReadLine();

            Console.Write("3. Not değerinizi giriniz : ");
            string strNot3 = Console.ReadLine();

            double dbNot1 = double.Parse(strNot1);
            double dbNot2 = Convert.ToDouble(strNot2);
            double dbNot3 = double.Parse(strNot3);

            double ortalamaNot = 0;

            // 1.Yöntem

            double toplamNot = dbNot1 + dbNot2 + dbNot3;
            ortalamaNot = toplamNot / 3;

            // 2. Yöntem

            ortalamaNot = (dbNot1 + dbNot2 + dbNot3) / 3;

            string kullaniciNotMesaj = (ortalamaNot > 45) ? "Ortalama değeriniz 45 den büyük olduğu için" +
                 "geçtiniz" : "Ortalama değeriniz 45 den küçük olduğu için kaldınız";

            Console.WriteLine(kullaniciNotMesaj);
        }
    }
}
