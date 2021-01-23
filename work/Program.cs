using System;

namespace workinterface
{
    class Program
    {
        static void Main(string[] args)
        {
            IAsker tegmen = new Tegmen();
            tegmen.SelamVer();
            tegmen.AtesEt(5);
            
            IAsker astSubay = new AstSubay();
            astSubay.SelamVer();
            astSubay.AtesEt(6);
            

            IAsker cavus = new Cavus();
            cavus.SelamVer();
            cavus.AtesEt(1);

            
        }
        
    }
}
