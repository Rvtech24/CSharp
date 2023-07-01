using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace prja.arraylist
{
    class EX01

    {
        public static void Main()
        {
            ArrayList ALobj = new ArrayList();
            ALobj.Add("Box");
            ALobj.Add(11);
            ALobj.Add(true);

            foreach (var v1 in ALobj)
                Console.WriteLine(v1);
        }
    }
}
/*
 Output:
 Box
11
True
 */
