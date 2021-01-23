
using System;
using System.Collections.Generic;
using System.Text;

namespace Oop2
    //coorporate
    //miras inheritance
    //musterinin içinde olan özellikler gerçekte de tüzelde de vardır demek
{   //tüzel müşteri yani inhericts . miras alır müşteriden
    //müşteri burada ebeveyn . tüzelde sadece ona ait olan özellikler

    class TuzelMusteri: Musteri //tüzel müşteri bir müşteridir
    {
       
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }

    
    }
}
