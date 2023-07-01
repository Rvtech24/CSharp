using System;
/*
 Example for Employee Salary Tax
 */ 

namespace prja
{
    class ESTax
    {
        public static void Main()
        {
            Console.WriteLine("Enter Employee Info");
            string ip = null;

            Console.Write("ID:\t");
            ip = Console.ReadLine();
            int eid = 0;
            int.TryParse(ip, out eid);

            Console.Write("Name:\t");
            string ename = Console.ReadLine();

            Console.Write("Salary:\t");
            ip = Console.ReadLine();
            double esal = 0;
            double.TryParse(ip, out esal);

            double tax10 = 0, tax20 = 0, tax30 = 0, taxtot = 0, npay = 0;
            if(esal>1000000)
            {
                tax10 = 25000;
                tax20 = 100000;
                tax30 = (esal - 1000000) * 30.0 / 100;
            }
            else if(esal>500000)
            {
                tax10 = 25000;
                tax20 = (esal - 500000) * 20.0 / 100;
            }
            else if(esal>250000)
            {
                tax10 = (esal - 250000) * 10.0 / 100;
            }
            else if(esal<0)
            {
                esal = 0;
            }
            taxtot = tax10 + tax20 + tax30;
            npay = esal - taxtot;

            Console.WriteLine("ID:\t" + eid);
            Console.WriteLine("Name:\t" + ename);
            Console.WriteLine("Salary:\t" + esal);
            Console.WriteLine("Tax10%:\t" + tax10);
            Console.WriteLine("Tax20%:\t" + tax20);
            Console.WriteLine("Tax30%:\t" + tax30);
            Console.WriteLine("Total Tax:\t" + taxtot);
            Console.WriteLine("Net Pay:\t" + npay);
        }
    }
}

/*
 Output-1:
 Enter Employee Info
ID:     1001
Name:   x1
Salary: 1100000
ID:     1001
Name:   x1
Salary: 1100000
Tax10%: 25000
Tax20%: 100000
Tax30%: 30000
Total Tax:      155000
Net Pay:        945000
Press any key to continue . . .

    Output-2:
    Enter Employee Info
ID:     1002
Name:   x3
Salary: 800000
ID:     1002
Name:   x3
Salary: 800000
Tax10%: 25000
Tax20%: 60000
Tax30%: 0
Total Tax:      85000
Net Pay:        715000
Press any key to continue . . .

    Output-3:

    Enter Employee Info
ID:     1003
Name:   x5
Salary: 200000
ID:     1003
Name:   x5
Salary: 200000
Tax10%: 0
Tax20%: 0
Tax30%: 0
Total Tax:      0
Net Pay:        200000

*/


