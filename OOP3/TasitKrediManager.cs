using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class TasitKrediManager : IKrediManager //inherit ettiğim için kredimanagerdaki hesaplaya sahip
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("Taşıt kredisi ödeme planı heseplandı.");
        }
    }
}
