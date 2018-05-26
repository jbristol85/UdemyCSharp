using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section6Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>();
            while (true)
            {
                Console.Write("Enter the names or press enter to see result: ");
                var input = Console.ReadLine();

                

                if (!String.IsNullOrWhiteSpace(input))
                {
                    names.Add(input);

                    if (names.Count == 1)
                    {
                        Console.WriteLine("{0} likes your post", names[0]);
//                        continue;
                    }
                    else if (names.Count == 2)
                    {
                        Console.WriteLine("{0} and {1} like your post", names[0], names[1]);
//                        continue;
                    }
                    else if (names.Count > 2)
                    {
                        Console.WriteLine("{0}, {1} and {2} others like your post.", names[0], names[1],
                            names.Count - 2);
//                        continue;
                    }
                }
                else
                {
                    break;
                }
                
            }
        }
    }
}
