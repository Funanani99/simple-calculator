using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter First number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num1 + "+" + num2 + " = " + (num1 + num2));
            Console.WriteLine(num1 + "-" + num2 + " = " + (num1 - num2));
            Console.WriteLine(num1 + "*" + num2 + " = " + (num1 * num2));
            Console.WriteLine(num1 + "/" + num2 + " = " + (num1 / num2));

            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();

        }
    }
}
