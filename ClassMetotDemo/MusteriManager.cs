using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        //public void ile metot oluşturdum. Ekle-sil-listeler == public void Ekle(Musteri-yeşil olan tipi musteri-değişken mavi olan)
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.TCkimlikno + " TC Kimlik nolu müşteri eklendi. ");
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.TCkimlikno + "TC Kimlik nolu müşteri silindi.");


        }
        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Müşteri bilgiler: " + "Müşteri TC Kimlik No : " + musteri.TCkimlikno + " Adı: " +  musteri.Adi + " Soyadı : " + musteri.Soyadi);
        }

    }
}
