using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace section5count
{
    class Program
    {

        static void Main(string[] args)
        {
            var countNum = 0;

            for (var i = 0; i <= 100; i++)
            {
                if (i % 3 == 0)
                   countNum++;
            }

            
            Console.WriteLine(countNum);
        }
    
    }


}
