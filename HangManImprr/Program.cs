using System;
using System.IO;
using System.Text.RegularExpressions;

namespace HangManImpr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program Start");

            int Play;
            string[] File = System.IO.File.ReadAllLines(@".\countries_and_capitals.txt"); //otwieram plik tekstowy z miastami i  stolicami
            string ccLine;
            string[] Trimmed;
            string Country;
            string Capital;

            //Console.WriteLine(file[0]);
           string RandomLine = RandomLineGenerator(File);
           // Console.WriteLine(randomLine);
           // Console.WriteLine(separateTrim(randomLine));
            Console.ReadKey();



            Console.WriteLine("Do you want to play the game? If yes press '1', if not, press anything else");
            Play = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine(Play);
            Console.ReadKey();

            int lifePoints = 5;
            ccLine = RandomLineGenerator(File);
            Trimmed = SeparateTrim(ccLine);
            //Console.WriteLine(trimmed[0]);
           // Console.WriteLine(trimmed[1]);

           //Console.ReadKey();


            while (Play==1) //pętla gry
            {
                ccLine = RandomLineGenerator(File);
                Trimmed = SeparateTrim(ccLine);
                Country = Trimmed[0];
                Capital = Trimmed[1];
                char[] BlankCapital = Capital.ToCharArray(); //blank capital to be used - so we can compare blank version with this version of word char by char
                //char[] guessWord =  Regex.Replace(capital, "[^0-9 ]","_");
                string GuessWord = Regex.Replace(Capital, "[^0-9 ]", "_");
                char[] GuessWordCharArr = GuessWord.ToCharArray(); //GuessWordCharArr to be used as blank capital word in game with '_' instead of letters





            }

            Console.Write("\nProgram End");
            Console.ReadLine();
        }

        static string RandomLineGenerator(string[] filePath)
        {
            Random rnd = new Random();
            int zakres = rnd.Next(filePath.Length);
            //Console.WriteLine(filePath[zakres]);
            //Console.ReadLine();

            return filePath[zakres]; //zwraca randomową linię z pliku
        }

        static string[] SeparateTrim(string toSplit)
        {
            //Console.WriteLine("Trimmig Start");

            string[] separted = toSplit.Split('|');
            separted[1] = separted[1].Trim();

            //Console.WriteLine(separted[0]);
            //Console.WriteLine(separted[1]);
            //Console.WriteLine(separted.Length);


            //Console.WriteLine("Trimming End");

            return separted; // zwraca odzielne słowa stolica i państwo 
        }


        static int Game(char[] GuessWordCharArr, char[] BlankCapital, string country)
        {
            int points = 0;
            int lifePoints = 0;
            int chooseMode;



            while (lifePoints!=0)
            {
                Console.WriteLine("Guess the capital!");
                if (lifePoints <= 2)
                {
                    Console.WriteLine("Hint! This is the capital of: " + country);
                }
                Console.WriteLine("Word to guess: "+GuessWordCharArr);

                Console.WriteLine("If you want to chose whole word - press 1\nIf you want to chose single letter - press anything else");
                chooseMode = Convert.ToInt32(Console.ReadLine());

                if (chooseMode == 1)
                {



                }
                else
                {



                }









            }

            return points;
        }



      /*  static char[] Blank(char[] blankCapital)
        {
            char[] guessWord = blankCapital;

            //guessWord = Regex.Replace()
            //guessWord = Regex.Replace(blankCapital, "[^0-9 ]","_");



            return guessWord[0] = {'a'};*/
        }





    }
}

