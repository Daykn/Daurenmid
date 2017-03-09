using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mymid1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int n = int.Parse(str);
            for (int i = 1; i <= n; i++) {
                if (n % i == 0) {
                    Console.Write(i);
                    Console.Write(' ');
                }
            }
            Console.ReadKey();
        }
    }
}
