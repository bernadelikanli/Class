using System;
using System.Collections.Generic;
using System.Text;

namespace Metodlar
{
    class SepetManager
    {
        //naming convention
        public  void Ekle()
        {

            Console.WriteLine("sepete eklendi");

        }
        public void Ekle2(string urunAdi,string aciklama,double fiyat)
        {


            Console.WriteLine("sepete eklendi" + urunAdi);
        }
    }
}
