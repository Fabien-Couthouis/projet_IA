using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double d = 3;
            char c = '3';
            Console.WriteLine(d.ToString()[0] == c.ToString());
            Console.ReadKey();
        }
    }
}
