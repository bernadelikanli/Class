 using System;

namespace Classintro
{
    class Program
    {
        static void Main(string[] args)
        {
            
            kurs kurs1=new kurs();

            kurs1.kursadi = "JAVA";
            kurs1.kursegitmen = "Tahir Delikanlı";
            kurs1.izlemeorani = "68";


            kurs kurs2 = new kurs();
            kurs2.kursadi = "Phyton";
            kurs2.kursegitmen = "Emine Delikanlı";
            kurs2.izlemeorani = "95";


            kurs kurs3 = new kurs();
            kurs3.kursadi = "C#";
            kurs3.kursegitmen = "Berna Delikanlı";
            kurs3.izlemeorani = "55";


            kurs[] kurslar = new kurs[] { kurs1, kurs2, kurs3 };
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.kursadi);
            }

            Console.WriteLine(kurs1.kursadi + "--> " + kurs1.kursegitmen);
            Console.WriteLine(kurs2.kursadi + "--> " + kurs2.kursegitmen);
            Console.WriteLine(kurs3.kursadi + "--> " + kurs3.kursegitmen);
        }

    }

    class kurs
    {
        public string kursadi { get; set; }

        public string kursegitmen  { get; set; }

        public string izlemeorani { get; set; }

    }
}