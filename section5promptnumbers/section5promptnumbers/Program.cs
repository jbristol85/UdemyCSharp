using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace section5promptnumbers
{
    class Program
    {
       
        static void Main(string[] args)
        {
            var tally = 0;
            while (true)
            {
                Console.WriteLine("Enter number to tally or \"ok\" to exit: ");
                var input = Console.ReadLine();

                if (input != "ok")
                {
                    int number = Convert.ToInt32(input);
                    tally += number;
                    Console.WriteLine("The total is {0}", tally);
                    continue;
                }
                Console.WriteLine("@Echo: " + "Exiting");
                break;

            }
        }
    }
}
