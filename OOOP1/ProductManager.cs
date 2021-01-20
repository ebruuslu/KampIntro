using System;
using System.Collections.Generic;
using System.Text;

namespace OOOP1
{
    class ProductManager
    {
        //public void Add(string ad) gibi düşün = product manager klasının içinden çağracaksın beni . benim adım add ve parametre olarak ban bir tane mein yolla
        //encapsulation 
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi. " );

        }

        public void Update (Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.  " );
        }

        //
        public int Topla(int sayi1 , int sayi2)
        {
            return sayi1 + sayi2;
        }

        public void Topla2(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1+ sayi2);
        }
    }
}
