using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace prja.arraylist
{
    class CLSBitarrayaa
    {
       public static void Main()
        {
            bool[] b = new bool[4];
            b[0] = true;
            b[1] = true;
            BitArray BAobj = new BitArray(b);
            foreach (bool b2 in BAobj)
                Console.WriteLine(b2);
        }
    }
}
/*
 Output:

True
True
False
False 

 */
