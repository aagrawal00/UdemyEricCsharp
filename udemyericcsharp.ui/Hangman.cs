using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyEricCsharp
{
    class Hangman
    {
        private bool _keepPlaying;
        private int _guessessleft;
        private string _answer;
        private int _lettersFound;

        private string[] _guessedLetters;
        private int _guessedLettersIndex;

        private string[] _wordDisplay;

        public void Play()
        {
            Setup();
            while(_keepPlaying)
            {
                DisplayPuzzle();
                PromptUser();
            }
           DisplayResult();
        }

        private void PromptUser()
        {
            bool validInput = false;
            while (!validInput)
            {
                Console.WriteLine("Guess the letter or the whole word");
                validInput = ParseInput(Console.ReadLine().ToUpper());
            }
            Console.WriteLine("\nPress enter to continue");
            Console.ReadLine();
        }

        private bool ParseInput(string input)
        {
            if (input.Length>1)
            {
                if (input==_answer)
                {
                    _keepPlaying = false;
                    return true;
                }
                Console.WriteLine("Wrong Answer");
                _guessessleft--;
            }
            else
            {
                if(_guessedLetters.Contains(input))
                {
                    Console.WriteLine("You already guessed {0}", input);
                    return false;
                }

                bool foundLettersAtleastOnce = false;
                for (int i=0;i<_answer.Length;i++)
                {
                    if(input==_answer[i].ToString())
                    {
                        foundLettersAtleastOnce = true;
                        _lettersFound++;
                        _wordDisplay[i] = input;
                    }
                }
                if (foundLettersAtleastOnce)
                {
                    Console.WriteLine("That was a good guess");
                    if (_lettersFound==_answer.Length)
                    {
                        Console.WriteLine("That is correct!");
                        _keepPlaying = false;
                    }
                }
                else
                {
                    Console.WriteLine("No, that letter was not found");
                }
            }
            
            _guessedLetters[_guessedLettersIndex] = input;
            _guessedLettersIndex++;

            if(_guessessleft==0)
            {
                _keepPlaying = false;
            }
            return true;
        }

        private void DisplayResult()
        {
            if(_guessessleft>0)
            {
                Console.WriteLine("You guessed the word, the original word was {0}", _answer);
            }
            else
            {
                Console.WriteLine("You lose! The word was {0}", _answer);
            }
        }
        
        private void DisplayPuzzle()
        {
            Console.Write("\nPuzzle: ");
            for(int i=0;i<_wordDisplay.Length;i++)
            {
                Console.Write("{0}", _wordDisplay[i]);
            }

            Console.WriteLine("\nYou have {0} guesses left\n", _guessessleft);
        }

        private void Setup()
        {
            _guessessleft = 5;
            _keepPlaying = true;
            _guessedLetters = new string[26];
            _guessedLettersIndex = 0;
            GetWordFromPlayer();
            CreateWordDisplay();
        }

        private void CreateWordDisplay()
        {
            _wordDisplay = new string[_answer.Length];
            for(int i =0;i<_wordDisplay.Length;i++)
            {
                _wordDisplay[i] = "_";
            }
        }
        private void GetWordFromPlayer()
        {
            Console.WriteLine("Enter the word to guess");
            _answer = Console.ReadLine().ToUpper();
            Console.Clear();
        }
    }
}
