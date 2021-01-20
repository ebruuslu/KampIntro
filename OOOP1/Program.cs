using System;

namespace OOOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2; //2 nu mobilyaya karşılık gelir
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

;            Product product2 = new Product { Id = 2, CategoryId = 5,
                UnitsInStock = 5, ProductName="Kalem ", UnitPrice= 35};

            //PascalCase    //camelCase(ilk kelime küçük)
            //case sensitive (küçük-büyük tip duyarlıdır)
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName); //kamera

            
   

            //int,double,bool ... değer tip (sayısallar değer tip)(atamalar tamamen değer üzerinde olur.)
            //diziler, class, abstract class ,interface ...  referans tip (atamalar refferansın numarasıtla yapılır)
        }   // ref out
    }
}
