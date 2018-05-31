using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section8Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();
            var consecutive = true;
            Console.WriteLine("Please enter 5 hiphenated numbers: ");
            var input = Console.ReadLine();
            var splitInput = input.Split('-');


            for (var i = 0; i < splitInput.Length; i++)
            {
                if (splitInput[i] + 1 != splitInput[i + 1] )
                {
                    consecutive = false;
                    ;
                }

                if(consecutive)
                    Console.WriteLine("Consecutive");
                else
                {
                    Console.WriteLine("non-consecutive");
                }
                    
            }
            
            
        }
    }
}
