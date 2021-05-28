using System;
using System.IO;
namespace Files_FileInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string loc = @"C:\Users\Rohit Dasari\source\repos\Files_FileInfo\bin\Debug\netcoreapp3.1\MyDirectory\myTextFile.txt";
            FileInfo file = new FileInfo(loc);                  // Creating FileInfo instance  
            StreamWriter sw = file.CreateText();                // Creating an file instance to write  
            sw.WriteLine("This text is written to the file by using StreamWriter class.");                      // Writing to the file 
            sw.Close();
            string path= @"C:\Users\Rohit Dasari\source\repos\Files_FileInfo\bin\Debug\netcoreapp3.1\MyDirectory";
            string[] files = Directory.GetFiles(path);                  //to get all the files
            foreach (string f in files)
            {
                Console.WriteLine(f);
            }
            Console.WriteLine(file.FullName);
            Console.WriteLine(file.DirectoryName);
            Console.WriteLine(file.Extension);
            Console.WriteLine(file.IsReadOnly);
            Console.WriteLine(file.LastWriteTime);
            Console.WriteLine(file.Name);
        }
    }
}
