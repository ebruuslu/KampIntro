using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //büyük Urun > tipi.  küçük urun>
        //c# da () varsa metot vardır
        //naming convention - Ekle böyle yazılır
        //syntax
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler!Sepete eklendi : " + urun.Adi);
            //
            //
            //
        }

        
        //böyle de olur ama bunu yapmamlısın programa gir sepetMenager Ekle 2 kısmına bak
       //böyle ayrı ayrı yazmak yerine encapsulation yaparak üstteki gibi klasa al . bunun tamamını içeren klasa al buna encapsulation denir
       //bu urunadı, acıklama fiyat ve stokadadeinin tamamını içeren yukarıdaki => urun kısmı (public void Ekle(Urun urun)(buradaki küçük ürün . buna da klas denir . mesela bu klas olan "urun"  urun.cs ye girince oradaki şeyleri içerir
        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
         Console.WriteLine("Tebrikler!Sepete eklendi : " + urunAdi);    
        }
    }
}
