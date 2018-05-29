using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummarisingText
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence =
                "The punishment assigned to a defendant found guilty by a court, or fixed by law for a particular offense.";
            var summary = StringUtility.SummerizeText(sentence, 25);
            Console.WriteLine(summary);
        }

    }
}
