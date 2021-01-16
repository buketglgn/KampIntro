using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "buket";
            int yas = 24;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "c#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Kerem Varış";
            kurs2.IzlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Berkay Bilgin";
            kurs3.IzlenmeOrani = 70;


            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.Egitmen = "Murat Kurtbogan";
            kurs4.IzlenmeOrani = 100;

            // Console.WriteLine(kurs1.KursAdi+ " :"+ kurs1.Egitmen);

            //*****************ÖNEMLİ****************ÖENMLİ***********
            //kurs sınıfından türettigimiz bir liste olusturduk..

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 ,kurs4};
            foreach(var takmaAd in kurslar)
            {
                Console.WriteLine(takmaAd.KursAdi+" egitmeni: "+takmaAd.Egitmen);               

            }
            //kurs adları ve egitmenleri yazılıyor.

            //*******************ÖNEMLİ************ÖNEMLİ***************


            Console.WriteLine("Hello World!");
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
