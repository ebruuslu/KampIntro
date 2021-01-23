using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{ //
    class KonutKrediManager : IKrediManager  //bunun da içinde hesapla olsun . kredimaanagerda hesapla var zaten
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("Konut kredisi ödeme planı heseplandı.");
        }
    }
}
