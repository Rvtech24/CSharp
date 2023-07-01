using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using prja.ulinq;
/*
 Example for foreach with collection
 */ 

namespace prja.ulinq
{
    class CLSFEaa
    {
        public static void Main()
        {
            List<CLSERaa> Lst = new List<CLSERaa>()
            {
                new CLSERaa {rno=1001,SName="x5",m1=56.5,m2=63 },
                new CLSERaa {rno=1002,SName="x3",m1=98,m2=20 },
                new CLSERaa {rno=1003,SName="x1",m1=45.5,m2=52 }
            };

            foreach (CLSERaa er in Lst)
            {
                string sr = "\n{0,4}\t{1,3}\t{2,5}\t{3,5}\t{4,6}\t{5,5}\t{6,4}\n";
                Console.Write(sr, er.rno, er.sname, er.m1, er.m2, er.Total, er.Avg, er.Result);
            }            
        }
    }
}
/*
 output:
1001     x5      56.5      63    119.5  59.75   pass

1002     x3        98      20      118     59   fail

1003     x1      45.5      52     97.5  48.75   pass */
