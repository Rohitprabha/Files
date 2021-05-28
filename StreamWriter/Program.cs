using System;
using System.IO;

namespace Files_StreamWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("text.txt");
            string temp = string.Empty;
            do
            {
                Console.Write("Enter your text [-1 to exit]:");
                temp = Console.ReadLine();
                if (temp != "-1")
                {
                    sw.WriteLine(temp);
                }
            } while (temp != "-1");
            sw.Close();

            string line;
            using (StreamReader sr = new StreamReader("text.txt"))     // The using statement also closes the StreamReader.
            {
                while ((line = sr.ReadLine()) != null)              // Read and show each line from the file.
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
