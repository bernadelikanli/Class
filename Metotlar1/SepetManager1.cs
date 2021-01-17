using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar1
{
    class SepetManager1
    {
        //naming convention
        //syntax
        // parantez varsa metod çalışır
        public void Ekle(Urun urun)         //urun-> Takma ad  Urun->veri tipi
        {
            Console.WriteLine("TEBRİKLER.Sepete Eklandi:"+urun.Adi);

        }


        public void Ekle2(Urun urun)
        {
            Console.WriteLine("TEBRİKLER.Sepete Eklandi: "+urun.Adi); 

        }
    }
}
