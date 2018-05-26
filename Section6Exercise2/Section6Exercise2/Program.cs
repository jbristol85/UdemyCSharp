using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section6Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a name to reverse: ");
            var input = Console.ReadLine();

            var names = new char[input.Length];

            for (var i = input.Length; i > 0 ; i--)
            {
                names[input.Length - i] = input[i - 1];
                
            }
            var reversed = new string(names);
            Console.WriteLine(reversed);
        }
    }
}
