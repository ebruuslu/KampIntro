using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
        //method ınjection 
    {
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService) //IKredimanager hepsinin referansını tuutğu için bunu verdil
        {
            //Başvuran bilgilerini değerlendirme
            //
           
            krediManager.Hesapla();
            loggerService.Log(); //hangiservis verilmişse logla
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler) //bana bir liste ver listenin türü ıkeridmanager olsun
        {
            foreach (var kredi in krediler)  //kredilerdeki her bir kredinin bir operasyonunu .-örn(hesaplasını) yap //liste yolladım h-ve her birini tek tek hesapladım
            {
                kredi.Hesapla();
            }
        }


    }
}
