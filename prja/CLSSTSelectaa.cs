/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;


namespace prja
{
    class CLSSTSelectaa
    {
        public static void Main()
        {
            DataContext dc = new DataContext(CLSCnStr.forCmrDb);
            var ds=from row in dc.GetTable<CLSSTaa>()
                  select row{
                eid = row.eid,ename=row.ename,
                
                
            };
        }
    }
}
*/