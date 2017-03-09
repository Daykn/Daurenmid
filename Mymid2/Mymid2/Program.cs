using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mymid2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"a.txt");
            string str = sr.ReadToEnd();
            sr.Close();
            string[] arr = str.Split();
            int a = int.Parse(arr[0]);
            int b = int.Parse(arr[1]);
            int c;
            int d;
            if (a < b)
            {
                c = a;
                d = b;
            }
            else
            {
                d = a;
                c = b;
            }
            StreamWriter sw = new StreamWriter(@"b.txt"); 
            for (int i = 1; i <= c; i++) {
                if (c % i == 0 && d % i==0) {
                    sw.Write(i);
                    sw.Write(' ');
                }
            }sw.Close();
            
        }
    }
}
