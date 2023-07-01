using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;

namespace prja
{
    [Table (Name ="tblst")]
    class CLSSTaa
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int eid;

        [Column]
        public string ename;

        [Column]
        public decimal esal;

        [Column(IsDbGenerated = true)]
        public decimal tax10;

        [Column(IsDbGenerated = true)]
        public decimal tax20;

        [Column(IsDbGenerated = true)]
        public decimal tax30;

        [Column(IsDbGenerated = true)]
        public decimal tottax;

        [Column(IsDbGenerated = true)]
        public decimal npay;
    }
}
