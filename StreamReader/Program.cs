using System;
using System.IO;

namespace Files_StreamReader
{
    class Program
    {
        public static void ReadfromFile(string filePath)
        {
            StreamReader r = new StreamReader("text.txt");
            while (!r.EndOfStream)
            {
                Console.WriteLine(r.ReadLine());
            }
            r.Close();
        }
        public static void WriteToFile(string filePath)
        {

            string[] names = new string[] { "Rohit", "Kohli", "Krish" };

            using (StreamWriter sw = new StreamWriter(filePath))         // The using statement also closes the StreamWriter.
            {

                foreach (string s in names)
                {
                    sw.WriteLine(s);                                // write each word in names into names.txt
                }
            }
        }

        static void Main(string[] args)
        {
            String filePath = "text.txt";
            WriteToFile(filePath);
            ReadfromFile(filePath);
        }
    }
}
