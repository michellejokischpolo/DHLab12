using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHLab12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors!");
            Console.WriteLine("What is your name:");
            string nameofuser = Console.ReadLine();

            bool run = true;
            while (run == true)
            {
               

                    
                Console.WriteLine("Would you like to play against Rocky or Star? [enter rocky or star to select player]");
                string playerselected = Console.ReadLine();

                Console.WriteLine("You will be playing against " + playerselected);
                Console.WriteLine("Pick rock, paper or scissors [r, p, s]");
                RPSGenerator rps1 = new RPSGenerator();
                string input1;
                Console.WriteLine(nameofuser + ":" + rps1.GetByString(Console.ReadLine()));

                if (playerselected == "rocky")
                {
                    RPSGenerator rps = new RPSGenerator();
                    Rocky r = new Rocky(rps);
                    Console.WriteLine("Rocky:" + r.GenerateRPS());
                }

                else if (playerselected == "star")
                {
                    RPSGenerator rps2 = new RPSGenerator();
                    Star s = new Star(rps2);
                    Console.WriteLine("Star:" + s.GenerateRPS());


                }
                if (Continue() == true) ;
                else run = false;

            }
        }

            public static bool Continue()
        { Console.WriteLine("Do you want to play again? y/n");
            string input = Console.ReadLine();
            input = input.ToLower();

            bool goOn;

            if (input == "y")
            { goOn = true; }

            else if (input == "n")
            { goOn = false; }

            else
            { Console.WriteLine("I don't understand that, let's try again");

                goOn = Continue();
            }

            return goOn;


        }
    }
}
