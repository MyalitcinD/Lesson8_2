using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string folderPath = @"D:\UNIK\les8_task1";
            string[] folders = Directory.GetFiles(folderPath, "*", SearchOption.AllDirectories);
            foreach(string s in folders) {
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }
    }
}
