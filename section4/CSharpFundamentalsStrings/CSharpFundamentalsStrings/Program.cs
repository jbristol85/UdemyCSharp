using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentalsStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Josh";
            var lastName = "Bristol";

            var fullName = firstName + " " + lastName;
            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);

            var names = new string[3] {"John", "Jack", "Mary"};
            var formattedNames = string.Join(",", names);
            Console.WriteLine(formattedNames);

            //            var text = "Hi John\nLook into the following paths\nc:\\folder1\\folder2\nc:\\folder3\\folder4";
            //            Console.WriteLine(text);

            //varbatim version of var text above
            var text = @"Hi John
Look into the following paths
c:\folder1\folder2
c:\folder3\folder4";
            Console.WriteLine(text);

        }
    }
}
