using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace prja.arraylist
{
    class CLSAddRange
    {
        public static void Main()
        {
            ArrayList ALobja = new ArrayList();
            ALobja.Add("Box");
            ALobja.Add(11);

            ArrayList ALobjb = new ArrayList();
            ALobjb.Add(4.2);
            ALobjb.Add(true);

            ALobja.AddRange(ALobjb);
            foreach (var v1 in ALobja)
                Console.WriteLine(v1);


        }


        }
}
/*
 Output:
Box
11
4.2
True

*/
