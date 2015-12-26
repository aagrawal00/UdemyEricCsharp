using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyEricCsharp
{
    class RockPaperScissors
    {
        private Random rng;
        private int wins, losses, ties;

        public RockPaperScissors()
        {
            rng = new Random();
        }
        public void Play()
        {
            string userchoice;
            userchoice = PromptUser();
            while (userchoice!="Q")
            {
                string ComputerChoice = GetComputerChoice();
                DetermineWinner(userchoice, ComputerChoice);
                PrintScore();
                Console.Clear();
                userchoice = PromptUser();
            }
        }

        private void PrintScore()
        {
            Console.WriteLine();
            Console.WriteLine("Wins: {0}", wins);
            Console.WriteLine("Losses: {0}", losses);
            Console.WriteLine("Ties: {0}", ties);
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
        }

        private void DetermineWinner(string userchoice, string ComputerChoice)
        {
            if (userchoice == ComputerChoice)
            {
                ties++;
                Console.WriteLine("You both picked {0}, you tied!", ConvertChoicetoWord(userchoice));
            }
            else if ((userchoice == "R" && ComputerChoice =="S") || (userchoice == "S" && ComputerChoice == "P") || (userchoice=="R" && ComputerChoice=="P"))
            {
                wins++;
                Console.WriteLine("You picked {0} and computer picked {1}, you win!", ConvertChoicetoWord(userchoice), ConvertChoicetoWord(ComputerChoice));
            }
            else
                losses++;
                Console.WriteLine("You picked {0} and computer picked {1}, you win!", ConvertChoicetoWord(userchoice), ConvertChoicetoWord(ComputerChoice));
        }

        private string ConvertChoicetoWord(string choice)
        {
            if (choice == "R")
                return "Rock";
            else if (choice == "P")
                return "Paper";
            else
                return "Scissors";
        }

        private string GetComputerChoice()
        {
            int choice = rng.Next(1, 4);
            if (choice == 1)
                return "R";
            else if (choice == 2)
                return "P";
            else
                return "S";
        }

        private string PromptUser()
        {
            while (true)
            {
                Console.WriteLine("Enter your choice {R}Rock, {P}Paper,{S}Scissors,Q{Quit}");
                string choice = Console.ReadLine();

                if (choice == "R" || choice == "P" || choice == "S" || choice == "Q")
                {
                    return choice;
                }
                else
                {
                    Console.WriteLine("That was not a valid choice");
                }
            }
        }
    }
}
