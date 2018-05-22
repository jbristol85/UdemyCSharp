using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            //            var name = "John Smith";
            //
            //            for (var i = 0; i < name.Length; i++)
            //            {
            //                Console.WriteLine(name[i]);
            //            }
            //
            //            foreach (var character in name)
            //            {
            //                Console.WriteLine(character);
            //            }
            //
            //            var numbers = new int[] {1, 2, 3, 4};
            //
            //            foreach (var index in numbers)
            //            {
            //                Console.WriteLine(index);
            //            }


            while (true)
            {
                Console.Write("Type your name: ");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("@Echo: " + input);
                    continue;
                }

                break;


            }
        }
    }
}
