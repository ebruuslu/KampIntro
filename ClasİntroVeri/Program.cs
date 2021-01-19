using System;

namespace ClasİntroVeri
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "engin";
            int yas = 36;


            Kurs kurs1 =  new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demirog";
            kurs1.IzlenmeOranı = 32+45;


            Kurs kurs2=  new Kurs();
            kurs2.KursAdi = "java";
            kurs2.Egitmen = "Kerem Varış";
            kurs2.IzlenmeOranı = 20-5;

            Kurs kurs3=  new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Berkay Bligin";
            kurs3.IzlenmeOranı = 30*2;


            // Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);

            // a = ["asd","qwe"] py daki karşılığı)
            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                // bu kursun adı: kursadi, Hocası: hocadi, oranı: oranı
                Console.WriteLine("bu kursun adı: "+ kurs.KursAdi   + " eğitmeni: "+ kurs.Egitmen  + " izlenme oranı: " + kurs.IzlenmeOranı + "%");
               // Console.WriteLine(kurs.KursAdi); (dersteki bu)
               //Console.WriteLine(kurs.Egitmen);
            }

            //Console.WriteLine("Hello World!");
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOranı { get; set; }

    }
}
