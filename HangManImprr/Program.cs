using System;
using System.IO;

namespace HangManImpr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program Start");

            int play;
            string[] file = System.IO.File.ReadAllLines(@".\countries_and_capitals.txt"); //otwieram plik tekstowy z miastami i  stolicami


            Console.WriteLine(file[0]);
            RandomLineGenerator(file);

            Console.WriteLine("Do you want to play the game? If yes press '1', if not, press anything else");
            play = Convert.ToInt32(Console.Read());

            Console.WriteLine(play);
            Console.ReadKey();


            while(play==1)
            {



                Console.WriteLine("You are in the loop");
                Console.ReadKey();


            }
            




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

