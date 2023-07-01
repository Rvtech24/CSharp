using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace prja.arraylist
{
    class CLSGetRange
    {
        public static void Main()
        {
            ArrayList ALobja = new ArrayList();
            ALobja.Add("Box");
            ALobja.Add(11);
            ALobja.Add(4.2);
            ALobja.Add(true);

            ArrayList ALobjb = ALobja.GetRange(2, 2);
            foreach (var v1 in ALobjb)
                Console.WriteLine(v1);
        }
    }
}
/*
 Output:
 
4.2
True
     
 */
