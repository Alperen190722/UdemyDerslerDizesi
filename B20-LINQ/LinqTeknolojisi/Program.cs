using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTeknolojisi
{
    internal class Program
    {



        static bool funcDelegateKullanimi1(Musteri m)
        {
            if (m.isim[0] == 'A')
                return true;
            else
                return false;
        }

        static bool predicateDelegateMetot(Musteri m) 
        {
            if (m.dogumTarih.Year > 1990)
                return true;
            else
                return false;
        }

        static void musteriListele(Musteri m) 
        {
            Console.WriteLine(m.isim + " " + m.soyisim);
        }

        static void Main(string[] args)
        {
            
            dataSource ds = new dataSource();
            List<Musteri> musteriListe = ds.musteriListesi();

            #region Linq Inceleme ve Ara Ödevler

            // Müşteri listesi içerisinde bulunan kayıtlardan ismi a ile başlayan soyisim değerinin içinde e olan ve doğum yılı 1985 den büyük olan
            // kayıtları getirin

            var odevAlistirma1 = from I in musteriListe
                                 where
                                 I.isim.StartsWith("A") &&
                                 I.soyisim.Contains("e") &&
                                 I.dogumTarih.Year > 1985
                                 select I;
            Console.WriteLine(odevAlistirma1.Count());

            var odevAlistirma2 = musteriListe.Where(I => I.isim.StartsWith("A") && I.soyisim.Contains("e") && I.dogumTarih.Year > 1985).Select(I => I);

            Console.WriteLine(odevAlistirma2.Count());

                                 #endregion

                                 #region Action Delegate

            Action < Musteri > actionMusteri = new Action<Musteri>(musteriListele);
            musteriListe.ForEach(actionMusteri);

            musteriListe.ForEach(new Action<Musteri>(musteriListele));

            musteriListe.ForEach(delegate (Musteri m) { Console.WriteLine(m.isim + " " + m.soyisim); });

            musteriListe.ForEach((Musteri m) => { Console.WriteLine(m.isim + " " + m.soyisim); });

            musteriListe.ForEach((m) => 
            { Console.WriteLine(m.isim + " " + m.soyisim); }
            );

            #endregion

            #region Linq sorgularında Delegate kullanımı Predicate Delegate

            Predicate<Musteri> predicate = new Predicate<Musteri>(predicateDelegateMetot);

            var DelegateKullanimiPredicate1 = musteriListe.FindAll(predicate);

            var DelegateKullnaimiPredicate2 = musteriListe.FindAll(new Predicate<Musteri>(predicateDelegateMetot));

            var DelegateKullanimPredicate3 = musteriListe.FindAll(delegate (Musteri m) { return m.dogumTarih.Year > 1990; });

            var DelegateKullanimPredicate4 = musteriListe.FindAll((Musteri m) => {return m.dogumTarih.Year > 1990;});

            var DelegateKullanimPredicate5 = musteriListe.FindAll((m) => { return m.dogumTarih.Year > 1990; });

            var DelegateKullanimPredicate6 = musteriListe.FindAll(m => m.dogumTarih.Year > 1990);

            #endregion


            #region Linq sorgularında Delegate kullanımı =>

            var DelegateKullanimi1 = musteriListe.Where(I => I.isim.StartsWith("A"));

            Func<Musteri, bool> funcDelegate1 = new Func<Musteri, bool>(funcDelegateKullanimi1);

            var DelegateKullanimi2 = musteriListe.Where(funcDelegate1);

            DelegateKullanimi2 = musteriListe.Where(funcDelegateKullanimi1);

            var DelegateKullanimi3 = musteriListe.Where(new Func<Musteri, bool>(funcDelegateKullanimi1));
            var DelegateKullanimi4 = musteriListe.Where( delegate (Musteri m) {
                return m.isim[0] == 'A' ? true :
                false; });
            var DelegateKullanimi5 = musteriListe.Where((Musteri M) => { return M.isim[0] == 'A' ? true : 
                false; });

            var DelegateKullanimi6 = musteriListe.Where((m) => { return m.isim[0] == 'A' ? true : false; });

            var DelegateKullanimi7 = musteriListe.Where(m => m.isim[0] == 'A'); // =>


            #endregion

            #region Alistirmalar

            // 1 : musteriler içerisinde ulke değeri A ile başlayan musterileri Linq to metot kulanarak bulalım

            IEnumerable<Musteri> musteriListeAlistirma1 = musteriListe.Where(I => I.ulke.StartsWith("A"));
            Console.WriteLine(musteriListeAlistirma1.Count());

            // 2 : musteriler listesi içerisindeki kayıtlardan isminin içinde b harfi geçen ve ulke değeri içinde A harfi geçen müşterilerin
            // listesini getirin. &&

            var musteriListesiAlistirma2 = musteriListe.Where(I => I.isim.Contains("a") && I.ulke.Contains("a")).ToList();

            // 3 : musteriler listesi içerisindeki kayıtlardan dogum yılı 1990 dan buyuk ola ve ismi nin içerisinde a harfi geçen
            // müşterileri II.yol olan Linq to Query ile bulalım...

            var musteriListeAlistirma3 = from I in musteriListe
                                         where I.dogumTarih.Year > 1990 && I.isim.Contains("a")
                                         select I;

            Console.WriteLine(musteriListeAlistirma3.Count());

            // 4 : musteriler listesi içerisindeki kayıtlardan dogum yılı 1990 dan buyuk olan veya ismi nin içerisinde a harfi geçen
            // müşterileri II.yol olan Linq to Query ile bulalım...

            var musteriListeAlistirma4 = from I in musteriListe
                                         where I.dogumTarih.Year > 1990 || I.isim.Contains("a")
                                         select I;

            Console.WriteLine(musteriListeAlistirma4.Count());

                                         #endregion

            #region Linq Sorgulama Çeşitleri

            // I.Yol

            int toplamMusteriAdetI = musteriListe.Where(I => I.isim.StartsWith("A")).Count();

            // II.Yol

            var toplamMusteriBulunan = from I in musteriListe
                                       where I.isim.StartsWith("A")
                                       select I;
            int toplamMusteriAdetII = toplamMusteriBulunan.Count();

                                      #endregion

            #region Baslarken

            // A ile başlayan müşterilerin adedini verin...

            int bulunanToplam = 0;
            for (int i = 0; i < musteriListe.Count; i++) 
            {
                if (musteriListe[i].isim[0] == 'A') 
                {
                    bulunanToplam++;
                }
            }

            Console.WriteLine("Liste içerisinde isim değeri A ile başlayan kayıt sayısı {0}", bulunanToplam);
            Console.WriteLine(musteriListe.Count);

            bulunanToplam = 0;

            bulunanToplam = musteriListe.Where(i => i.isim.StartsWith("A")).Count();
            Console.WriteLine("Liste içerisinde isim değeri A ile başlayan kayıt sayısı {0}", bulunanToplam);
            Console.ReadLine();

            #endregion
        }
    }
}
