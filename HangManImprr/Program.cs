using System;
using System.IO;

namespace HangManImpr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program Start");

            string[] file = System.IO.File.ReadAllLines(@".\countries_and_capitals.txt"); //otwieram plik tekstowy z miastami i  stolicami


            Console.WriteLine(file[0]);
            RandomLineGenerator(file);



            Console.Write("\nProgram End");
            Console.ReadLine();
        }

        static string RandomLineGenerator(string[] filePath)
        {
            Random rnd = new Random();
            int zakres = rnd.Next(filePath.Length);

            //string[] newText = filePath;
            Console.WriteLine(filePath[zakres]);
            //Console.ReadLine


            return filePath[zakres];
        }











    }
}

