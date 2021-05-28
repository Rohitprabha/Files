using System;
using System.IO;

namespace Files_FileStream
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream f = new FileStream(@"C:\Users\Rohit Dasari\source\repos\Files_FileStream\bin\Debug\netcoreapp3.1\text.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
            for (int i = 65; i <= 90; i++)
            {
                f.WriteByte((byte)i);
            }
            f.Close();
        }
    }
}
