using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace section9Path
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\projects\CSharpFundamentals\HelloWorld\helloworld.sln";
            var dotIndex = path.IndexOf('.');
            var extension = path.Substring(dotIndex);

            Console.WriteLine("Extensions: " + Path.GetExtension(path));
            Console.WriteLine("File Name: " + Path.GetFileName(path));
            Console.WriteLine("File Name without ext: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Directory name: " + Path.GetDirectoryName(path));
        }
    }
}
