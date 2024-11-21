using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            string pp = @"C:\Users\Никита\Desktop\files.txt";
            File.Create(pp).Close();
            File.WriteAllText(pp, "я люблю лис");
        }
    }
}