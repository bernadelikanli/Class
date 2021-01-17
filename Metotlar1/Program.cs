using System;

namespace Metotlar1
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya Elması";


            string[] meyveler = new string[] { };//array

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "karpuz";
            urun2.Fiyati = 70;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] { urun1,urun2 };

            foreach (Urun urun in urunler) //Urunler->Str gibi veri tipi  urun->takma ad  urunler->        <TYPE SAFE>
            {
                Console.WriteLine(urun.Adi+"\n"+urun.Fiyati+"\n"+urun.Aciklama);
                Console.WriteLine("------------------");
            }
            Console.WriteLine("------METODLAR---------------");
            //instance örnek
            SepetManager1 sepetManager1 = new SepetManager1();
            sepetManager1.Ekle(urun1);
            sepetManager1.Ekle(urun2);

            sepetManager1.Ekle2(urun1);
            sepetManager1.Ekle2(urun2);



        }
    }
}
