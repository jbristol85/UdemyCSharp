using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section6Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var numbers = new int [5];
            var count = 0;

            while (count != 5)
            {
                
                Console.WriteLine("Please enter a total of 5 numbers");
               
                var input = Console.ReadLine();
                var num = Convert.ToInt32(input);

                if (Array.IndexOf(numbers, num) == -1)
                {
                    numbers[count] = (num);
                    count++;
                    continue;
                }
                else
                {
                    Console.WriteLine("Please enter another number: ");
                    continue;
                }
            }
            Array.Sort(numbers);
            foreach (var number in numbers)
                Console.WriteLine(number);
        }
    }
}
