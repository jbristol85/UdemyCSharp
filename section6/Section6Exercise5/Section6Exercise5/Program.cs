using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section6Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Enter a list of numbers seperated by a \',\'.");
                var input = Console.ReadLine();

                var numArr = input.Split(',');

                if (numArr.Length < 5 || numArr.Length == 0)
                {
                    Console.WriteLine("Invalid List, please retry");
                    
                }
                else
                {
                    Array.Sort(numArr);

                    for (var i = 0; i < 3; i++)
                        Console.WriteLine(numArr[i]);
                    break;
                }
            }
        }
    }
}
