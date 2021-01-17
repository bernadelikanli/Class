using System;

namespace Deneme
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            string kategorietiketi = "kategori";
            //do not repeat yourself

            int ogrsayisi = 32000;
            double faizorani = 1.45;
            bool sistgirisyaptimi = false;
            double dolardun = 7.45;
            double dolarbugun = 7.45;


            if (dolardun>dolarbugun)
            {
                Console.WriteLine("azalış butonu göster");

            }
            else if (dolardun<dolarbugun)
            {

                Console.WriteLine("artış butonu");

            }
            else
            {
                Console.WriteLine("değişmedi");
            }

            if(sistgirisyaptimi==true)
            {

                Console.WriteLine("kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("giriş yap butonu");
                
            }
 
            Console.WriteLine(kategorietiketi);



                }
    }
}
