﻿using System;
using System.Collections.Generic;
using System.Text;

namespace workinterface
{
    class Tegmen : IAsker
    {
        public void AtesEt(int kacEl)
        {
            Console.WriteLine(kacEl + " kez ateş edildi");
        }

        public void SelamVer()
        {
            Console.WriteLine("Tegmen selam verdi");
           
        }
    }
}
