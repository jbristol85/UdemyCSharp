using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace section9Directories
{
    class Program
    {
        static void Main(string[] args)
        {
//            Directory.CreateDirectory(@"c:\temp\folder");
            var files = Directory.GetFiles(@"C:\Users\joshb\Desktop\software", "*.sln", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }

            var directories =
                Directory.GetDirectories(@"c:\projects\CSharpFundamentals", "*.*", SearchOption.AllDirectories);
            foreach (var directory in directories)
            {
                Console.WriteLine(directory);

                Directory.Exists("...");

                var directoryInfo = new DirectoryInfo("...");
                directoryInfo.GetFiles();
                directoryInfo.GetDirectories();
            }
        }
    }
}
