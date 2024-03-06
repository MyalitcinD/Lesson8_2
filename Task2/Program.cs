using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string txt_path = @"D:\UNIK\task2\task2.txt";
            Random random = new Random();
            int sum = 0;
            using(StreamWriter sw = new StreamWriter(txt_path, false)) {
                for(int i = 0; i < 10; i++) {
                    sw.WriteLine(random.Next(-10000, 10000));
                }
            }
            using(StreamReader sr = new StreamReader(txt_path)) {
                for(int i = 0; i < 10; i++) {
                    int num = Convert.ToInt32(sr.ReadLine());
                    sum += num;
                }
            }
            Console.WriteLine("Summ = {0}", sum);
            Console.ReadKey();
        }
    }
}
