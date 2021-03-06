﻿using Oop2;
using System;

namespace OoP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Engin DEmiroğ
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.TcNo = "12345678910";


            //Kodlama.io

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567890";


            // Gerçek Müşteri  - Tüzel Müşteri (iki tane müşteri var. gerçek olan insan diğeri şirket)
            //SOLID'in L harfi
            //birbine benziyor diye inheritance yapmamalısın

            Musteri musterş3 = new GercekMusteri(); //new görürsen bellekteki referans nosu // musteri klası hem gerçek hem de tüzrel müşterinin referansını tutabiliyor
            Musteri musteri = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);


        }
    }
}
