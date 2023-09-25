using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_IO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileOperation f=new FileOperation();
            f.FileExists();
            f.ReadAllLine();
            f.CopyFile();
            Console.ReadLine();
        }
    }
}
