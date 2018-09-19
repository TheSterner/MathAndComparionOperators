using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //1st Question

            Console.WriteLine("Please enter a number");
            string numInput = Console.ReadLine();
            int num1 = Convert.ToInt32(numInput);
            int total = num1 * 50;
            Console.WriteLine("Your number times 50 is " + total);
            Console.ReadLine();

            //2nd Question

            Console.WriteLine("Please enter a number");
            string numInput = Console.ReadLine();
            int num1 = Convert.ToInt32(numInput);
            int total = num1 + 25;
            Console.WriteLine("Your number plus 25 is " + total);
            Console.ReadLine();

            //3rd Question

            Console.WriteLine("Please enter a number");
            string numInput = Console.ReadLine();
            int num1 = Convert.ToInt32(numInput);
            double total = num1 / 12.5;
            Console.WriteLine("Your number divided by 12.5 is " + total);
            Console.ReadLine();

            //4th Question

            Console.WriteLine("Please enter a number");
            string numInput = Console.ReadLine();
            int num1 = Convert.ToInt32(numInput);
            bool trueOrFalse = num1 > 50;
            Console.WriteLine(trueOrFalse + "" + "If True, your number was higher than 50. If False, your number was lower than 50.");
            Console.ReadLine();

            //5th Question

            Console.WriteLine("Please enter a number");
            string numInput = Console.ReadLine();
            int num1 = Convert.ToInt32(numInput);
            int total = num1 % 7;
            Console.WriteLine("Remainder of your number divided by 7 " + total);
            Console.ReadLine();

        }
    }
}
