using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace File_IO
{
    //File is collection of data stored in a disk the specific name and a directory path
    //File is open for reading and writing if become a stream
    //Stream is a sequence of byte passing through a commication path
    //the namespace we are using is system.IO
    //Input stream-Reading Input data 
    //Output stream-Writing the data in file
    internal class FileOperation
    {
        //string file = "C:\\Users\\chitt\\OneDrive\\Desktop\\PFP-001\\File_IO\\File_IO\\File_IO";
        string pathFile = "C:\\Users\\chitt\\OneDrive\\Desktop\\PFP-001\\File_IO\\File_IO\\File_IO\\Manoj.txt";
       // string file= @"C:\\Users\\chitt\\manoj\\naik\\naik.txt""
        public void FileExists()
        {
            if (File.Exists(pathFile))
            {
                Console.WriteLine("File Exists");
            }
            else {
                Console.WriteLine("File not Exists"); 
            }
        }
        public void ReadAllLine()
        {
            string[]strings = File.ReadAllLines(pathFile);
            foreach (string line in strings)
            {
                Console.WriteLine(line);
            }
        }
        public void ReadAllText()
        {
            string line=File.ReadAllText(pathFile);
            Console.WriteLine(line);
        }

        public void CopyFile()
        {
            string files = "C:\\Users\\chitt\\OneDrive\\Desktop\\PFP-001\\File_IO\\File_IO\\File_IO\\Manoj.txt";
            File.Copy( files,pathFile);
            Console.WriteLine("file is copied");
        }
        public void Delete()
        {
           string copyfile ="C:\\Users\\chitt\\OneDrive\\Desktop\\PFP-001\\File_IO\\File_IO\\File_IO\\Manoj.txt";
            File.Delete(copyfile);
            Console.WriteLine("File is deled");
        }

    }
}
