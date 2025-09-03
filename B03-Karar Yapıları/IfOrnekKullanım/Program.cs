namespace IfOrnekKullanım
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcı adı : admin
            // Şifre : abc123

            Console.Write("Kullanıcı adınızı giriniz : ");
            string kullaniciAdi = Console.ReadLine();

            Console.Write("Şifrenizi giriniz : ");
            string sifre = Console.ReadLine();

            if(kullaniciAdi == "admin" && sifre == "abc123")
            {
                Console.WriteLine("Kullanıcı giriş işlemi başarılı.");
            }
            else
            {
                Console.WriteLine("Kullanıcı bilgileriniz hatalı.");
            }
        }
    }
}
