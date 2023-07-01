using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using prja.ulinq;
/*
 Example for linq using 'select'clause for getting unique value
 */

namespace prja.ulinq
{
    class CLSSinglesel
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
                     select new { row.rno, row.sname, row.Result, };

            foreach (var row in ds)
            {
                Console.Write("\t{0,4}\t{1,4}\t{2,4}\n", row.rno, row.sname, row.Result);

            }
        }
    }
}

/*
 output:
1001      x5    pass
1002      x3    fail
1003      x1    pass
*/
