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

            //list bir sınıf . yeşil renkte olanlar sınıf . list olmasaydı biz bir klasa bu görevi nasıl yükleriz?
            //yeni proje ekledik genericsintro
        }
