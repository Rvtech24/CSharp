using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prja.property_feature
{
    class CLSProper
    {
        private int _rno;
        private string _SName;
        private double _m1 = 0, _m2 = 0;

        public int rno
        {
            get
            {
                return _rno;
            }
            set
            {
                _rno = value;
            }
        }
        public string SName
        {
            get
            {
                return _SName;
            }
            set
            {
                _SName = value;
            }
        }
        public double m1
        {
            get
            {
                return _m1;
            }
            set
            {
                _m1 = value;
            }
        }
        public double m2
        {
            get
            {
                return _m2;

            }
            set
            {
                _m2 = value;
            }
        }
        public double Total
        {
            get
            {
                return _m1 + _m2;
            }
           
        }
        public double Avg
        {
            get
            {
                return Total / 2;
            }
        }
        public string Result
        {
            get
            {
                return _m1 > 34.4 && _m2 > 34.4 ? "pass" : "fail";
            }
        }

    }
    class CLSPropaa
    {
        public static void Main()
        {
            CLSProper er = new CLSProper();
            er.rno = 1001;
            er.SName = "xx";
            er.m1 = 56.5;
            er.m2 = 63;

            Console.WriteLine(er.rno);
            Console.WriteLine(er.SName);
            Console.WriteLine(er.m1);
            Console.WriteLine(er.m2);
            Console.WriteLine(er.Total);
            Console.WriteLine(er.Avg);
            Console.WriteLine(er.Result);

        }
    }
}
/*
 Output:

1001
xx
56.5
63
119.5
59.75
pass
 
*/
