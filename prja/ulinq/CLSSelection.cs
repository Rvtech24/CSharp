using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using prja.ulinq;
/*
 Example for linq using 'select'clause
 */ 

namespace prja.ulinq
{
    class CLSSelection
    {
        public static void Main()
        {
            List<CLSERaa> erLst = new List<CLSERaa>()
            {
                new CLSERaa {rno=1001,SName="x5",m1=56.5,m2=63 },
                new CLSERaa {rno=1002,SName="x3",m1=98,m2=20 },
                new CLSERaa {rno=1003,SName="x1",m1=45.5,m2=52 }
            };
            var ds = from row in erLst
                     select row;

            foreach(var row in ds)
            {
                Console.Write("\t{0,4}\t{1,4}", row.rno, row.sname);
                Console.Write("\t{0,5}\t{1,5}", row.m1, row.m2);
                Console.Write("\t{0,4}\t{1,4}\t{2,4}\n", row.Total,row.Avg, row.Result);
            }
        }
    }
}
/*
 output:
1001      x5     56.5      63   119.5   59.75   pass
1002      x3       98      20    118      59    fail
1003      x1     45.5      52   97.5    48.75   pass
 */
