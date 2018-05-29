using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentalsArrays2
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 3, 7, 9, 2, 14, 6 };

            // length
            Console.WriteLine("Length: " + numbers.Length);

            //IndexOf()
            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine("The index of 9 is " + index);

            //clear()
            Array.Clear(numbers, 0, 2);
            Console.WriteLine("Effect of clear()");
            foreach (var num in numbers)
                Console.WriteLine(num);

            // copy()
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);

            Console.WriteLine("Effect of Copy()");
            foreach (var num in another)
                Console.WriteLine(num);
            
            // sort()
            Array.Sort(numbers);
            Console.WriteLine("Effect of sort()");
            foreach (var num in numbers)
                Console.WriteLine(num);

            // reverse()
            Array.Reverse(numbers);
            Console.WriteLine("Effect of Reverse()");
            foreach (var num in numbers)
                Console.WriteLine(num);

        }
    }
}
