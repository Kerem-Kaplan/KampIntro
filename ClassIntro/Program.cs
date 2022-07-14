using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Product urun1 = new Product();
            //urun1.productName = "Haylou T15";
            //urun1.productType = "Kulaklık";
            //urun1.productPrice = 200;

            //Product urun2 = new Product();
            //urun2.productName = "Samsung SyncMaster 920NW";
            //urun2.productType = "Monitör";
            //urun2.productPrice = 1000;

            //Product urun3 = new Product();
            //urun3.productName = "Logitech k380";
            //urun3.productType = "Kablosuz Klavye";
            //urun3.productPrice = 500;

            //Product[] urunler = new Product[] { urun1, urun2, urun3 };

            //foreach (Product urun in urunler)
            //{
            //    Console.WriteLine("Urun Adı:" + urun.productName + "    " + "Urun Tipi:" + urun.productType + "    " + "Urun Fiyati:" + urun.productPrice);
            //}
                        
            //Kurs kurs1 = new Kurs();
            //kurs1.KursAdi = "C#";
            //kurs1.Egitmen = "Engin Demirog";
            //kurs1.IzlenmeOrani = 68;

            //Kurs kurs2 = new Kurs();
            //kurs2.KursAdi = "Java";
            //kurs2.Egitmen = "Kerem Varış";
            //kurs2.IzlenmeOrani = 64;

            //Kurs kurs3 = new Kurs();
            //kurs3.KursAdi = "Python";
            //kurs3.Egitmen = "Berkay Bilgin";
            //kurs3.IzlenmeOrani = 80;

            //Kurs kurs4 = new Kurs();
            //kurs4.KursAdi = "C++";
            //kurs4.Egitmen = "Murat Kurtboğan";
            //kurs4.IzlenmeOrani = 100;

            //Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3, kurs4 };

            //foreach (Kurs kurs in kurslar)
            //{
            //    Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen + " : " + kurs.IzlenmeOrani);
            //}

        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }

    class Product
    {
        public string productName { get; set; }
        public string productType { get; set; }
        public double productPrice { get; set; }
    }


}
