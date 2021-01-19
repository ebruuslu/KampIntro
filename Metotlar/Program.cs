using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";

            string[] meyveler = new string[] {"Elma", "Karpuz" };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] {urun1, urun2 };

            //type safe-- tip güvenli
            // Urun urun in urunler de yazsan olur "var urun in urunler2 de yazsan olur
            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("------------");

            }

            Console.WriteLine("-----Metotlar------");

            //instance- örnek  (klas örneği oluşturmak için sepetManager yazdık 2. sini
            //encapsulation (diyelim ürün kısına stok adedini ekledin , burada sıkıntı çıkmaz . buna encapsulation denir


            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            


            // böyle de ekleyebilirdin ama niye klas yapıruz-sepetmaneger sekmesinde açıklandı-
            // SepetManager e stokadedi eklemen gerektiğinde buraya gelip hepsine tek tek stok sayılarını değiştirmen lazım bütün sayfların patladı
            sepetManager.Ekle2("Armut", "Yeşil sarı", 12, 10);
            sepetManager.Ekle2("Elma", "Yeşil elma", 12, 9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12, 8);
            sepetManager.Ekle2(urun1.Adi, urun1.Aciklama, urun1.Fiyati, urun1.StokAdedi);
        }
    }
}


// Dont repeat yourself - DRY - Clean Code- Best Practice 
