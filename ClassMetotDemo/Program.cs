using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.TCkimlikno = "12345678911";
            musteri1.DogumTarihi = DateTime.Parse("01.01.1998");
            musteri1.Adi = "Cem";
            musteri1.Soyadi = "Z";

            Musteri musteri2 = new Musteri();
            musteri2.TCkimlikno = "01345678911";
            musteri2.DogumTarihi = DateTime.Parse("02.01.1998");
            musteri2.Adi = "Burak";
            musteri2.Soyadi = "Y";

            Musteri musteri3 = new Musteri();
            musteri3.TCkimlikno = "02345678911";
            musteri3.DogumTarihi = DateTime.Parse("03.01.1998");
            musteri3.Adi = "Ali";
            musteri3.Soyadi = "X";

            Musteri[] musteriler = new Musteri [] {musteri1, musteri2, musteri3 };

            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.TCkimlikno);
                Console.WriteLine(musteri.DogumTarihi);
                Console.WriteLine(musteri.Adi);
                Console.WriteLine(musteri.Soyadi);
                Console.WriteLine("--------------------");
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);

            Console.WriteLine("------------------------------------");

            musteriManager.Sil(musteri1);
            musteriManager.Sil(musteri2);
            musteriManager.Sil(musteri3);

            Console.WriteLine("------------------------------------");

            musteriManager.Listele(musteri1);
            musteriManager.Listele(musteri2);
            musteriManager.Listele(musteri3);
        }

    }
}
