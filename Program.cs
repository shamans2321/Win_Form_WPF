using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach (DriveInfo drive in drives)
            {
                Console.WriteLine($"Название:{drive.Name}");
                Console.WriteLine($"Тип: {drive.DriveType}");
                if (drive.IsReady)
                {
                    Console.WriteLine($"Файловая система:{drive.DriveFormat }");
                    Console.WriteLine($"Объём диска:{drive.TotalSize }");
                    Console.WriteLine($"Свободное пространство:{drive.TotalFreeSpace }");
                    Console.WriteLine($"Метка:{drive.VolumeLabel }");
                    Console.WriteLine($"Коневой каталог:{drive.RootDirectory }");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

