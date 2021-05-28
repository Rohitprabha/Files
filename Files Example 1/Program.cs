using System;
using System.IO;

namespace Files_Example_1
{
    class Program
    {
        static void Main(string[] args)
        {
            File.Create(@"C:\Users\Rohit Dasari\source\repos\Files Example 1\bin\Debug\netcoreapp3.1\file.txt");


            /*File.Create("myTextFile.txt");*/                                        //to create a file in running application

            Directory.CreateDirectory("MyDirectory");                             //to create a new directory

            /*File.Create("MyDirectory/myTextFile.txt"); */                             //to create file in a same directory


            if (!File.Exists("MyDirectory/myTextFile.txt"))     // check before creating otherwise it will override the file which contains the same name
            {
                File.Create("MyDirectory/myTextFile.txt");
            }

            Console.WriteLine(File.Exists("MyDirectory/myTextFile.txt"));                       //to check whether the specified file exists or not

            string[] fileContent = File.ReadAllLines("MyDirectory/myTextFile.txt");             //to read all lines in a file and store in array

            for (int i = 0; i < fileContent.Length; i++)
            {
                Console.WriteLine(fileContent[i]);                                  //to display the content in array
            }


            //Open, Read
            string fileContentAsText = File.ReadAllText("MyDirectory/myTextFile.txt");              //to read all lines in a file as single text

            Console.WriteLine(fileContentAsText);

            //Replace
            string replaced = fileContentAsText.Replace('H', 'h');                   //it will replace but it will not effect the original file

            Console.WriteLine(replaced);                                             // replaced file
            Console.WriteLine(fileContentAsText);                                    // original file

            //Save file
            File.WriteAllText("MyDirectory/myTextFile.txt", replaced);              // it will create a new file if it is not correct file name

            Console.WriteLine(fileContentAsText);

            string[] newLines = { "\n", "Wow", "this", "is", "Cool" };
            File.WriteAllLines("MyDirectory/myTextFile.txt", newLines);               // to write into file

            //Append file
            File.AppendAllText("MyDirectory/myTextFile.txt", replaced);

            Console.ReadLine();
        }
    }
}
