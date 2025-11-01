using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalitimOdevUygulamasi
{
    public class urun:baseClass
    {
        public string marka { get; set; } // *belirtmiş olduğumuz markalar içerisinde ürün eklenebilsin
        public string model { get; set; }

        private decimal _alisFiyat; // 0 dan küçük olmamalı
        public decimal alisFiyat 
        {
            get 
            { 
                return this._alisFiyat; 
            }
            set 
            {
                if (value <= 0)
                {
                    Console.WriteLine("Alış fiyatı sıfırdan küçük olamaz");
                }
                else 
                {
                    _alisFiyat = value;
                }
            }
        }
        private decimal _satisFiyat; // alisfiyatından küçük olamaz
        public decimal satisFiyat 
        { 
            get 
            {
                return this._satisFiyat;
            }
            set 
            {
                if (value < _alisFiyat)
                {
                    Console.WriteLine("Satış fiyatı Alış fiyatından küçük olamaz");
                }
                else 
                { 
                    _satisFiyat = value;
                }
            } 
        }
        private decimal _kampanyaFiyat; // kampanya fiyat değeri 0 dan küçük olamaz
        public decimal kampanyaFiyat 
        {
            get 
            {
                return this._kampanyaFiyat;
            }
            set 
            {
                if (value <= 0) 
                {
                    Console.WriteLine("Kampanya fiyatı sıfırdan küçük olamaz");
                }
                else
                {
                    _kampanyaFiyat = value;
                }
            }
        }
    }
}
