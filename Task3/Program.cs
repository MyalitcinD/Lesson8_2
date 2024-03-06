using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string txt_path = @"D:\UNIK\task3\text.txt";
            //string[] text;
            int symb = 0, words = 0, rows = 0;
            using(StreamReader sr = new StreamReader(txt_path)) {

                string str = sr.ReadLine();
                while(str != null) {
                    rows++;
                    symb += str.Length;
                    words += str.Split(' ').Length;

                    str = sr.ReadLine();
                }
            }

            Console.WriteLine("symbols = {0}\nrows = {1}\nwords = {2}", symb, rows, words);
            Console.ReadKey();
        }
    }
}
