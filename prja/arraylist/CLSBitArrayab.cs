using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace prja.arraylist
{
    class CLSBitArrayab
    {
        static void Main()
        {
            BitArray BAobj = new BitArray(5);
            BAobj[0] = true;
            BAobj[2] = true;
            BAobj.Set(5, true);
            Console.WriteLine(BAobj.Count);
            int i = 0;
            foreach(bool b in BAobj)
            
                if (b)
                    i++;

            
            Console.WriteLine(i);

        }
    }
}
