using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section6Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();

            while (true)
            {
                Console.WriteLine("Please enters numbers or \"Quit\" to exit: ");
                var input = Console.ReadLine();

                if (input == "Quit")
                {
                    break;
                }
                var num = Convert.ToInt32(input);

                if(numbers.IndexOf(num) == -1)
                    numbers.Add(num);
            }

            foreach (var num in numbers)
                Console.WriteLine(num);
        }
    }
}
