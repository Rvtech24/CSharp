using System;
/*
 Example for develop Exam Result with Dynamic inputs or run-time input
 */ 
namespace prja
{
    class ERdynm
    {
        public static void Main()
        {
            Console.WriteLine("Enter the following inputs for Exam Result");
            string ip = null;

            Console.Write("\nRoll number:\t");
            ip = Console.ReadLine();

            int rno = 0;
            int.TryParse(ip, out rno);

            Console.Write("\nStudent name:\t");
            string sname = Console.ReadLine();

            Console.Write("\nMark-1:\t");
            ip = Console.ReadLine();

            double m1 = 0;
            double.TryParse(ip, out m1);

            Console.Write("\nMark-2:\t");
            ip = Console.ReadLine();

            double m2 = 0;
            double.TryParse(ip, out m2);

            double total = (m1 + m2), avg = (m1 + m2) / 2;
            bool result = (m1 > 34.4 && m2 > 34.4);

            Console.WriteLine("Exam Result Info:\n");
            Console.WriteLine("Roll no:\t" + rno);
            Console.WriteLine("Student name:\t" + sname);
            Console.WriteLine("Mark-1:\t" + m1);
            Console.WriteLine("Mark-2:\t" + m2);
            Console.WriteLine("Total:\t" + total);
            Console.WriteLine("Average:\t" + avg);
            Console.WriteLine("Result:\t" + (result ? "pass" : "fail"));


        }
    }
}
/*
Output:

    Enter the following inputs for Exam Result

Roll number:    1002

Student name:   x4

Mark-1: 65

Mark-2: 50
Exam Result Info:

Roll no:        1002
Student name:   x4
Mark-1: 65
Mark-2: 50
Total:  115
Average:        57.5
Result: pass
Press any key to continue . . .
*/
