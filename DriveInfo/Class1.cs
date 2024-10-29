using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SystemIo
{
    public class Class1
    {
        static void Main(string[] args)
        {
            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach (DriveInfo drive in drives)
            {
                Console.WriteLine($"Название: {drive.Name}");
                Console.WriteLine($"Тип: {drive.DriveType}");
                if (drive.IsReady);
                {
                    Console.WriteLine($"Файловая система: {drive.DriveFormat}");
                    Console.WriteLine($"Объем диска: {drive.TotalSize}");
                    Console.WriteLine($"Свободное пространство: {drive.TotalFreeSpace}");
                    Console.WriteLine($"Метка: {drive.VolumeLabel}");
                    Console.WriteLine($"Корневой каталог: {drive.RootDirectory}");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
    class Programs
    {
        static void Main(string[] args)
        {
            string pp = @"С:C:\Users\777\Desktop\авпыо\ControlCode\ControlCode\vbbook.txt";
            File.Create(pp).Close();
            File.WriteAllText(pp, "Абра-кадабра!");
        }
    }
}

