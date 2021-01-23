using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //operasyonlar tanımlayacağız
    interface IKrediManager  
        //interfaceler I harfi ile başlar  //burası çnce klastı sonra interface yaptık
        //interface derki birisi bu interface i kullanırsa o void Hesapla metotınu kullanmak zorunda
        //
        //interface arayüz demekbir sınıf bir interface i böyle kullanıyorsa her kredi mutlaka bu interfacedeki metotları içermek zounda
    {
        void Hesapla();
        void BiseyYap();


    }
}
