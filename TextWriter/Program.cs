using System;
using System.IO;

namespace Files_TextWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter writer = File.CreateText("text.txt");
            try
            {
                writer.Write("Hi");
                writer.WriteLine("Good Evening \n How is your Day");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Data written successfully...");
            writer.Flush();
            writer.Close();
        }
    }
}
