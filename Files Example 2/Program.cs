using System;
using System.IO;

namespace File_Example_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Rohit Dasari\source\repos\Files Example 1\bin\Debug\netcoreapp3.1\MyDirectory";

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

            string source = @"C:\Users\Rohit Dasari\source\repos\Files Example 1\bin\Debug\netcoreapp3.1\MyDirectory\myTextFile.txt";
            string dest = @"C:\Users\Rohit Dasari\source\repos\Files Example 1\bin\Debug\netcoreapp3.1\MyDirectory\text.txt";

            File.Copy(source, dest, true);                                    //to copy it into the new file, true is to override the file
            Console.WriteLine("Copied");

            string dest1 = @"C:\Users\Rohit Dasari\source\repos\Files Example 1\bin\Debug\netcoreapp3.1\MyDirectory\SubDirectory";
            string path1 = @"C:\Users\Rohit Dasari\source\repos\Files Example 1\bin\Debug\netcoreapp3.1\MyDirectory\text.txt";


            File.Delete(path1);                                             //to delete a file in directory
            Console.WriteLine("Deleted");

        }
    }
}
