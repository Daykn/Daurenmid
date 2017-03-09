using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mymid3
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo di = new DirectoryInfo(Console.ReadLine());
            List<FileSystemInfo> li = new List<FileSystemInfo>();
            li.AddRange(di.GetDirectories());
            li.AddRange(di.GetFiles());
            foreach (FileSystemInfo p in li) {
                string str = p.Name;
                char[] arr = str.ToCharArray();
                for (int i = 0; i < p.Name.Length-3; i++) {
                    if (arr[i] == 't' && arr[i+1] == 'e' && arr[i+2] == 's' && arr[i+3] == 't')
                    {
                        Console.WriteLine(p.Name);
                    }
                } 
            }
            Console.ReadKey();
        }
    }
}
