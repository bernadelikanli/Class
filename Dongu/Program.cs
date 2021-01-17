using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //string kurs1 = "Yazılım Geliştirme Kampı";
            //string kurs2 = "Porgramlama Başlangıç ";
            //string kurs1 = "Java";
            //array-dizilerde tutulur.
            string[] kurslar = new string[] { "Yazılım Geliştirme Kampı", "Porgramlama Başlangıç","Java" };

            for (int i= 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("for bitti");

            //foreach dizileri dolaşırken kullanılır.

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
