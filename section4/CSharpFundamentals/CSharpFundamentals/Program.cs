using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpFundamentals.Math;

namespace CSharpFundamentals
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var josh = new Person();
            josh.FirstName = "Josh";
            josh.LastName = "Bristol";
            josh.Introduce();

            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine(result);
        }
    }
}
