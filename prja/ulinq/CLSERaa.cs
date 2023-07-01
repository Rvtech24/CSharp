using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prja.ulinq
{
    class CLSERaa
    {
        public int rno;
        public string sname;
        public double m1 = 0, m2 = 0;
        public int Rno
        {
            get
            {
                return rno;
            }
            set
            {
                rno = value;
            }
        }
        public string SName
        {
            get
            {
                return sname;
            }
            set
            {
                sname = value;
            }
        }
        public double M1
        {
            get
            {
                return m1;
            }
            set
            {
                m1 = value;
            }
        }
        public double M2
        {
            get
            {
                return m2;

            }
            set
            {
                m2 = value;
            }
        }
        public double Total
        {
            get
            {
                return m1 + m2;
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
                return m1 > 34.4 && m2 > 34.4 ? "pass" : "fail";
            }
        }

    }
   
}
