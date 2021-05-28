using System;
using System.IO;

namespace Files_TextReader
{
    class Program
    {
        static void Main(string[] args)
        {
            TextReader tr = File.OpenText("text.txt");
            StreamReader sr = new StreamReader("text.txt");
            try
            {
                Console.WriteLine(tr.ReadToEnd());
                Console.WriteLine();
                Console.WriteLine(sr.ReadLine());                   //Reads one line
                Console.WriteLine();
                Console.WriteLine(sr.Read());                       //ASCII value
                Console.WriteLine();
                char[] buf = new char[50];
                int n = sr.ReadBlock(buf, 0, buf.Length);
                Console.WriteLine($"{n} characters read");
                Console.WriteLine();
                Console.WriteLine(sr.ReadLine());                   //empty if no more characters to be read.
                Console.WriteLine();
                Console.WriteLine(sr.Read());                       //(-1) if there are currently no more characters to be read.
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            tr.Close();
        }
    }
}
