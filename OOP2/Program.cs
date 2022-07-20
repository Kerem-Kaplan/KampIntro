using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.ID = 1;
            musteri1.MusteriNo = "112345";
            musteri1.Ad = "Kerem";
            musteri1.SoyAd = "Kaplan";
            musteri1.TcNo = "123435345";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.ID = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Sirket";
            musteri2.VergiNo = "4544654645";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CostumerManager costumerManager = new CostumerManager();
            costumerManager.Add(musteri1);
            costumerManager.Add(musteri2);




            //SOLID - Liskov Subtitution Principle
        }
    }
}
