using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace section5Max
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a series of numbers seperated by a \",\" : ");
            var input = Console.ReadLine();
            var nums = input.Split(',');

            var maximum = Convert.ToInt32(nums[0]);

            foreach (var num in nums)
            {
                var number = Convert.ToInt32(num);
                if (number > maximum)
                {
                    maximum = number;
                }
            }

            Console.WriteLine("The largest number is {0}.", maximum);
        }
    }
}
