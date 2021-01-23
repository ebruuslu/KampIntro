using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Engin", "Murat", "Kerem", "Halil" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler = new string[5]; // new demek yeni referans adresi demek(boş elemanlı yeni bir şey oluşturmuşsun) . ilkeri eklemek için bunu yaptık . ilkeri görüyoruz ama 0. elemanı çağırdığımızda ekrana boş gelir bunun sebebi dizilerden dolayıdır.
            //isimler[4] = "İlker";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);

            //koleksiyonlar
            List<string> isimler2 = new List<string> { "Engin", "murat", "kerem", "halil" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);

            Console.WriteLine("24.01.2021-work");

            List<int> sayilar1 = new List<int>();

            sayilar1.Add(5);//0
            sayilar1.Add(5);//1
            sayilar1.Add(0);//2
            sayilar1.Add(10);//3
            sayilar1.Add(18);//4
            sayilar1.Add(13);//5
            sayilar1.Add(11);//6
            sayilar1.Add(8);//7



            //sayilar1.Remove(5);  // remove değeri bulur ve siler
            //sayilar1.RemoveAt(2);   // removeat belirli bir indeksi siler
            //sayilar1.RemoveAll(sayi => sayi == 5); 
            //sayilar1.RemoveAll(sayilar => sayilar % 2 == 1);  // %2 demek mod2 demek
            sayilar1.Sort();
            sayilar1.Reverse();  //önce sort yaz (küçükten büyüğe sıraladık) sonra reverse(tersini aldık) büyükten küçüğe sıraladı


            sayilar1.ForEach(x => Console.WriteLine(x));  //listelerde böyle döngü kullanabilirsin (foreach)


            List<int> sayilar2 = new List<int> { 10, 20, 30 };
            //Console.WriteLine(sayilar2[2]);
            //Console.WriteLine(sayilar2.Count + " TANE ELEMAN VAR");


            //list bir sınıf . yeşil renkte olanlar sınıf . list olmasaydı biz bir klasa bu görevi nasıl yükleriz?
            //yeni proje ekledik genericsintro
        }
    }
}
