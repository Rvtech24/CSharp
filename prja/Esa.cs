using System;
/*
 Example for Employee Salary Allowence
 */
namespace prja
{
    class ESA
    {
        public static void Main()
        {
            Console.WriteLine("Enter the Employee Info");
            string ip = null;
            Console.Write("\nID:\t");
            ip = Console.ReadLine();
            int eid = 0;
            int.TryParse(ip, out eid);

            Console.Write("Name:\t");
            string ename = Console.ReadLine();

            Console.Write("Salary:\t");
            ip = Console.ReadLine();
            double esal = 0;
            double.TryParse(ip, out esal);

            double hra= (esal * 20.0 / 100);
            double da= (esal * 15.0 / 100);
            double pf = (esal * 35.0 / 100);
            double gpay = esal + hra + da;
            double npay = gpay - pf;

            Console.WriteLine("\nEmployee Salary Allowence");

            Console.WriteLine("\nID:\t" + eid);
            Console.WriteLine("Name:\t" + ename);
            Console.WriteLine("Salary:\t" + esal);
            Console.WriteLine("House Rent Allowence:\t" + hra);
            Console.WriteLine("Dearness Allowence:\t" + da);
            Console.WriteLine("Provident Fund:\t" + pf);
            Console.WriteLine("Gross Pay:\t" + gpay);
            Console.WriteLine("Net Pay:\t" + npay);
         }
    }
}
/*
 Output:

Enter the Employee Info

ID:     1001
Name:   x3
Salary: 50000

Employee Salary Allowence

ID:     1001
Name:   x3
Salary: 50000
House Rent Allowence:   10000
Dearness Allowence:     7500
Provident Fund: 17500
Gross Pay:      67500
Net Pay:        50000
*/