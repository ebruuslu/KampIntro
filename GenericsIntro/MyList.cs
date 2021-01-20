using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{//t = type= tip . bu tip genericlerde T yazdık . ama t yerine a da yazabilirsin.
    class MyList<T>
    {
        //stringi buraya yazdık klasın içine
        //constructor  (ctor + tab*2)
        T[] items;
        public MyList()
        {
            items = new T[0]; // newledin arrayi oluturdun ve sıfır elemanlı verdin
        }
        
        public void Add(T item)
        {
           T[] tempArray = items;
           items = new T[items.Length+1];
            for (int i = 0; i < tempArray.Length; i++)   //for+tab*2
            {
                items[i] = tempArray[i];   //emanet verdiğklerimi items a geri alıyoruz . items eski değerlerine kavuştu
            }

            items[items.Length - 1] = item;

        }
        

    }
}
