using System;
using System.IO;

namespace Files_BinaryWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryWriter bw;
            int i = 25;
            double d = 3.14157;
            bool b = true;
            string s = "Rohit";

            //create the file
            try
            {
                bw = new BinaryWriter(new FileStream("mytext.txt", FileMode.Create));
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n Cannot create file.");
                return;
            }

            //writing into the file
            try
            {
                bw.Write(i);
                bw.Write(d);
                bw.Write(b);
                bw.Write(s);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n Cannot write to file.");
                return;
            }
            bw.Close();
        }
    }
}
