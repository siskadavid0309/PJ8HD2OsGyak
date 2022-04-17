using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OS_gyak10
{
    class Program
    {
        static void Main(string[] args)
        {
            string utvonal = @"D:\Visual Studio\repos\OS_gyak10\pj8hd2.txt";
            if (!File.Exists(utvonal))
            {
                using (StreamWriter sw = File.CreateText(utvonal))
                {
                    sw.WriteLine("Siska Dávid");
                    sw.WriteLine("Gazdaságinformatikus");
                    sw.WriteLine("pj8hd2");
                }
            }
            using (StreamReader sr = File.OpenText(utvonal))
            {
                string s;
                while ((s = sr.ReadLine() )!= null)
                {
                    Console.WriteLine(s);
                }
               
            }
            long length = new FileInfo(utvonal).Length;
            Console.WriteLine("Beolvasott fájl mérete: "+length+"byte");
        }
    }
}
