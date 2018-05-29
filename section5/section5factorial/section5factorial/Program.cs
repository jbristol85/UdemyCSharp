using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace section5factorial
{
    class Program
    {
        private static int _total = 1;
        public static int Factorial(int number)
        {
            for (var i = 1; i <= number; i++)
            {
                _total *= i;
            }

            return _total;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a number to Factorialize: ");
            var input = Console.ReadLine();

            var number = Convert.ToInt32(input);
            Console.WriteLine(Factorial(number));
            
        }
    }
}
