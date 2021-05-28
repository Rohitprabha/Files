using System;
using System.IO;

namespace Files_DirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string loc = @"C:\Users\Rohit Dasari\source\repos\Files_DirectoryInfo\bin\Debug\netcoreapp3.1\MyDirectory";
            string path = @"C:\Users\Rohit Dasari\source\repos\Files_DirectoryInfo\bin\Debug\netcoreapp3.1";
            Directory.CreateDirectory("NewDirectory");              // to create directory
            Directory.Delete("NewDirectory");                       //to delete directory
            string[] dirs = Directory.GetDirectories(path);             //to get all the Directories
            foreach (string dir in dirs)
            {
                Console.WriteLine(dir);
            }

            string[] files = Directory.GetFiles(path);                  //to get all the files
            foreach (string f in files)
            {
                Console.WriteLine(f);
            }
            DirectoryInfo info = new DirectoryInfo(loc);
            Console.WriteLine(info.FullName);
            Console.WriteLine(info.Name);
            Console.WriteLine(info.Parent);
            Console.WriteLine(info.Exists);
            Console.WriteLine(info.LastWriteTime);
        }
    }
}
