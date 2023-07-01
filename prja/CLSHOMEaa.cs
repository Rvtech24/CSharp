using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prja
{
    class CLSHOMEaa
    {
        public static void Main()
        {
            Console.WriteLine("Choose Execute App: \n");
            Console.WriteLine("1.Exam Result");
            Console.WriteLine("2.Employee Allowance");
            Console.WriteLine("3.Employee Salary Tax");
            Console.WriteLine("4.Electricity Bill");

            Console.Write("Ënter App no between 1 to 4: \t");
            int i = 0;
            int.TryParse(Console.ReadLine(), out i);
            if (!(i >= 1 && i <= 4))
            {
                Console.WriteLine("Ïnvalid App No.");
                return;
            }
            if (i == 1)
            {
                ERinfo.Main();
                return;
            }
            if (i == 2)
            {
                ESA.Main();
                return;
            }
            if (i == 3)
            {
                ESTax.Main();
                return;
            }
            EBaa.Main();   
        }
    }
}
/*
 Output:

 Choose Execute App:

1.Exam Result
2.Employee Allowance
3.Employee Salary Tax
4.Electricity Bill
Enter App no between 1 to 4:    3
Enter Employee Info
ID:     1234
Name:   vino
Salary: 600000
ID:     1234
Name:   vino
Salary: 600000
Tax10%: 25000
Tax20%: 20000
Tax30%: 0
Total Tax:      45000
Net Pay:        555000

 */
