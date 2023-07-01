using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prja.Covariance
{
    class CLSCVaa
    {
        public static void Main()
        {
            string[] sarr = { "aa", "zz", "cc" };
            object[] obj = sarr;
            obj[1] = "bb";
            foreach (string s in sarr)
                Console.WriteLine(s);
        }
    }
}
/*
aa
bb
cc
 */
