/*Section 1-5*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section1to5
{
    class Program
    {
        /*Method 1: Program Calls*/
        static void Main()
        {
            int switchcase;
            Console.Clear();
            Console.WriteLine("Enter the program number that you want to run");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Method 1: HelloWorld");
            Console.WriteLine("Method 2: Implicit and Explicit Conversion and Parsing");
            Console.WriteLine("Method 3: Hello Name");
            Console.WriteLine("Method 4: Simple Addition");
            Console.WriteLine("Method 5: Substitution String");
            Console.WriteLine("Method 6: Left Align");
            Console.WriteLine("Method 7: Right Align");
            Console.WriteLine("Method 8: FormatNumericalData");
            Console.WriteLine("Method 9: StringDotFormat");
            Console.WriteLine("Method 10: DemonstrateLiterals");
            Console.WriteLine("Method 11: DemonstrateEscapeCharacters");
            Console.WriteLine("Method 12: DemonstrateArithematic");
            Console.WriteLine("Method 13: DemonstrateEqualityComparisons");
            Console.WriteLine("Method 14: DemonstrateConditionalOperators");
            Console.WriteLine("Method 15: DemonstrateAssignmentOperators");
            Console.WriteLine("Method 16: FlippingCoin");
            Console.WriteLine("Method 17: FlippingCoin2");
            Console.WriteLine("Method 18: Guessing Game");

            switchcase = int.Parse(Console.ReadLine());

            switch (switchcase)
            {
                case 1:
                    Console.Clear();
                    HelloWorld();
                    ProgramEnd();
                    break;
                case 2:
                    Console.Clear();
                    Parsing();
                    ProgramEnd();
                    break;
                case 3:
                    Console.Clear();
                    HelloName();
                    ProgramEnd();
                    break;
                case 4:
                    Console.Clear();
                    SimpleAddition();
                    ProgramEnd();
                    break;
                case 5:
                    Console.Clear();
                    SubstitutionStrings();
                    ProgramEnd();
                    break;
                case 6:
                    Console.Clear();
                    LeftAlign();
                    ProgramEnd();
                    break;
                case 7:
                    Console.Clear();
                    RightAlign();
                    ProgramEnd();
                    break;
                case 8:
                    Console.Clear();
                    FormatNumericalData();
                    ProgramEnd();
                    break;
                case 9:
                    Console.Clear();
                    StringDotFormat();
                    ProgramEnd();
                    break;
                case 10:
                    Console.Clear();
                    DemonstrateLiterals();
                    ProgramEnd();
                    break;
                case 11:
                    Console.Clear();
                    DemonstrateEscapeCharacters();
                    ProgramEnd();
                    break;
                case 12:
                    Console.Clear();
                    DemonstrateArithematic();
                    ProgramEnd();
                    break;
                case 13:
                    Console.Clear();
                    DemonstrateEqualityComparisons();
                    ProgramEnd();
                    break;
                case 14:
                    Console.Clear();
                    DemonstrateConditionalOperators();
                    ProgramEnd();
                    break;
                case 15:
                    Console.Clear();
                    DemonstrateAssignmentOperators();
                    ProgramEnd();
                    break;
                case 16:
                    Console.Clear();
                    FlippingCoin();
                    ProgramEnd();
                    break;
                case 17:
                    Console.Clear();
                    FlippingCoin2();
                    ProgramEnd();
                    break;
                case 18:
                    Console.Clear();
                    GuessingGame();
                    ProgramEnd();
                    break;
            }
        }
        /*Method 2, Lecture 3: Basic input and output*/
        static void HelloWorld()
        {
            Console.WriteLine("Hello World");
            Console.ReadLine();
            int mywholenumber = 1;
            Console.WriteLine(mywholenumber);
            Console.ReadLine();
        }
        /*Method 3, Lecture 6: Testing implicit & explicit conversion and Parsing*/
        static void Parsing()
        {
            int i = 500;

            //implicit
            double d = i;
            Console.WriteLine(d);
            Console.ReadLine();

            //explicit
            short s = (short)i;
            Console.WriteLine(i);
            Console.ReadLine();

            //parse
            string mystringnumber = "5";
            i = int.Parse(mystringnumber);
            Console.WriteLine(i);
            Console.ReadLine();
        }
        /*Method 4, Lecture 7: Hello <name> Demo*/
        static void HelloName()
        {
            Console.WriteLine("Enter Name");
            string name;

            name = Console.ReadLine();

            Console.WriteLine("Hello " + name);
            Console.ReadLine();
        }
        /*Method 5, Lecture 8: Demo:Simple Addition*/
        static void SimpleAddition()
        {
            Console.WriteLine("Enter the first number");
            string userinput1 = Console.ReadLine();

            int num1 = int.Parse(userinput1);

            Console.WriteLine("Enter the second number");

            string userinput2 = Console.ReadLine();

            int num2 = int.Parse(userinput2);

            int sum = num1 + num2;

            Console.WriteLine(sum);

            Console.ReadLine();
        }
        /*Method 6, Lecture 9: Comments and Formatting Strings*/
        static void SubstitutionStrings()
        {
            Console.WriteLine("This demo is that of substitution strings");
            Console.WriteLine("-----------------------------------------");

            //Getting Data
            Console.WriteLine("What is your employee ID");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("What is your name");
            string name = Console.ReadLine();
            Console.WriteLine("The name of Employee#{0} is {1}", id, name);
            Console.ReadLine();
        }
        /*Method 7, Lecture 9: LeftAlign*/
        static void LeftAlign()
        {
            Console.WriteLine("This is an example of Left Alignment");
            Console.WriteLine("------------------------------------");

            string lineoutputformat = "{0,-20} {1,-10} {2,-6}";
            Console.WriteLine(lineoutputformat, "Abhishek Agrawal", "Singapore", "792441");
            Console.WriteLine(lineoutputformat, "Gita Agrawal", "Bilaspur", "495001");
            Console.WriteLine(lineoutputformat, "Smriti Agrawal", "Boston", "12065");
            Console.WriteLine(lineoutputformat, "Aloke Agrawal", "Bilaspur", "495001", "Pipeline");
        }
        /*Method 8, Lecture 9: RightAlign*/
        static void RightAlign()
        {
            Console.WriteLine("This is an example of Right Alignment");
            Console.WriteLine("-------------------------------------");

            string lineoutputformat = "{0,15}, {1,10}, {2,6}";
            Console.WriteLine(lineoutputformat, "Abhishek Agrawal", "Singapore", "792441");
            Console.WriteLine(lineoutputformat, "Gita Agrawal", "Bilaspur", "495001");
            Console.WriteLine(lineoutputformat, "Smriti Agrawal", "Boston", "12065");
            Console.WriteLine(lineoutputformat, "Aloke Agrawal", "Bilaspur", "495001", "Pipeline");
        }
        /*Method 9, Lecture 9: FormatNumericalData*/
        static void FormatNumericalData()
        {
            Console.WriteLine("The value 12345 in various formats:\n");
            Console.WriteLine("c format: {0:c}", 12345);
            Console.WriteLine("d9 format: {0:d9}", 12345);
            Console.WriteLine("f3 format: {0:f3}", 12345);
            Console.WriteLine("n format: {0:n}", 12345);

            Console.WriteLine("\n");

            // Notice that upper- or lowercasing for hex
            // determines if letters are upper- or lowercase.
            Console.WriteLine("E format: {0:E}", 12345);
            Console.WriteLine("e format: {0:e}", 12345);

            Console.WriteLine("For hex we will use 99999 to get some letters.");
            Console.WriteLine("X format: {0:X}", 99999);
            Console.WriteLine("x format: {0:x}", 99999);


            Console.WriteLine("\nPress enter to continue...");
            Console.ReadLine();
        }
        /*Method 10: Lecture 9: StringDotFormat*/
        static void StringDotFormat()
        {
            // string.Format() allows for substitution strings as well.  
            //It returns a string we can store for later

            string totalLine = string.Format("Total: {0:c}", 25.39);
            Console.WriteLine(totalLine);

            Console.WriteLine("\nPress enter to continue...");
            Console.ReadLine();
            Console.Clear();
        }
        /*Method 11: For navigating menu*/
        static void ProgramEnd()
        {
            Console.WriteLine();
            Console.WriteLine("Press 1 to go to the main menu, any other key to end the program");
            int input = int.Parse(Console.ReadLine());
            if (input == 1)
            {
                Main();
            }
            else
            {
                System.Environment.Exit(0);
            }
        }
        /*Method 12: Lecture 10: Expressions and Operators*/
        static void DemonstrateLiterals()
        {
            Console.WriteLine("Some examples of literals");
            Console.WriteLine("-------------------------");

            Console.WriteLine("{0}", 10);     // int
            Console.WriteLine("{0}", 3.14);   // double
            Console.WriteLine("{0}", 3.14F);  // float
            Console.WriteLine("{0}", 3.14M);  // decimal, I think 'M' for money
            Console.WriteLine("{0}", true);   // bool
            Console.WriteLine("{0}", 'a');    // char
            Console.WriteLine("{0}", "Hi!");  // string

            Console.WriteLine(); // blank line
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
            Console.Clear(); // clears the screen
        }
        /*Method 13: Lecture 10: Expressions and Operators*/
        static void DemonstrateEscapeCharacters()
        {
            Console.WriteLine("Escape Characters");
            Console.WriteLine("-------------------------");

            Console.WriteLine("She said, \"Hello\"");
            Console.WriteLine("c:\\Windows is normally where the Windows folder is.");
            Console.WriteLine("Let's print 3 blank lines after this.\n\n\n");

            Console.WriteLine(@"
The @ symbol can let me 
write out text
    exactly
        as
            I
                want.
");

            Console.WriteLine(@"The @ symbol also makes backslashes literal.  
c:\mydirectory\subdirectory\filename.txt");

            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
            Console.Clear();
        }
        /*Method 14: Lecture 10: Expressions and Operators*/
        static void DemonstrateArithematic()
        {
            Console.WriteLine("Arithemtic Operators");
            Console.WriteLine("-------------------------\n");

            int x = 21, y = 5;
            decimal a = 21M, b = 5M;

            Console.WriteLine("First some integer math, given x=21 and y=5: ");
            Console.WriteLine("x + y = {0}", x + y);
            Console.WriteLine("x - y = {0}", x - y);
            Console.WriteLine("x * y = {0}", x * y);
            Console.WriteLine("x / y = {0}", x / y);
            Console.WriteLine("x % y = {0}", x % y);

            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Now some fractional math, given a=21.0 and b=5.0: ");
            Console.WriteLine("a + b = {0}", a + b);
            Console.WriteLine("a - b = {0}", a - b);
            Console.WriteLine("a * b = {0}", a * b);
            Console.WriteLine("a / b = {0}", a / b);
            Console.WriteLine("a % b = {0}", a % b);

            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
            Console.Clear();
        }
        /*Method 15: Lecture 10: Expressions and Operators*/
        static void DemonstrateEqualityComparisons()
        {
            Console.WriteLine("Equality Operators");
            Console.WriteLine("-------------------------\n");

            int x = 21, y = 5, z = 5;

            Console.WriteLine("Given x=21, y=5, and z=5: ");
            Console.WriteLine("x < y? {0}", x < y);
            Console.WriteLine("y < z? {0}", y < z);
            Console.WriteLine("z >= y? {0}", z >= y);
            Console.WriteLine("z <= x? {0}", z <= x);
            Console.WriteLine("z == y? {0}", z == y);
            Console.WriteLine("x != z? {0}", x != z);

            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
            Console.Clear();
        }
        /*Method 16: Lecture 10: Expressions and Operators*/
        static void DemonstrateConditionalOperators()
        {
            Console.WriteLine("Conditional Operators");
            Console.WriteLine("-------------------------\n");

            int x = 21, y = 5, z = 5;
            int a = 0; // we can't divide by zero

            Console.WriteLine("Given x=21, y=5, z=5, and a=0: ");
            Console.WriteLine("x > y && x > z? {0}", x > y && x > z);
            Console.WriteLine("x < y || y == z? {0}", x < y || y == z);
            Console.WriteLine("(x != z && x < y) || a == 0? {0}", (x != z && x < y) || a == 0);
            Console.WriteLine("!(x > z)? {0}", !(x > z));

            // because the first part of the && is false, the second part won't be run
            // so we won't get an error
            Console.WriteLine("x < z && x / a > 0? {0}", x < z && x / a > 0);


            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
            Console.Clear();
        }
        /*Method 17: Lecture 10: Expressions and Operators*/
        static void DemonstrateAssignmentOperators()
        {
            Console.WriteLine("Assignment Operators");
            Console.WriteLine("-------------------------\n");

            int x = 1;
            Console.WriteLine("Given x = 1");

            Console.WriteLine("x++ : {0}", x++);
            Console.WriteLine("x is now {0}", x);

            Console.WriteLine("++x : {0}", ++x);
            Console.WriteLine("x is now {0}", x);

            x += 1;
            Console.WriteLine("x += 1 : {0}", x);

            x *= 2;
            Console.WriteLine("x *= 2 : {0}", x);

            x -= 1;
            Console.WriteLine("x -= 1 : {0}", x);

            x /= 3;
            Console.WriteLine("x /= 3 : {0}", x);

            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
            Console.Clear();
        }
        //Method 18: Section 5: Lecture 13, Flipping a Coin
        static void FlippingCoin()
        {
            int coin;
            Console.WriteLine("Enter a Guess, Heads or Tails <h or t>");
            string userGuess = Console.ReadLine();
            Random num = new Random();
            coin = num.Next(0, 2);
            if (coin == 0 && userGuess == "t")
            {
                Console.WriteLine("You win, it's tails");
            }
            else if (coin == 1 && userGuess == "h")
            {
                Console.WriteLine("You win, it's heads");
            }
            else if (coin == 1)
            {
                Console.WriteLine("You lose, it's heads");
            }
            else
            {
                Console.WriteLine("You lose, it's tails");
            }
        }
        //Method 19: Section 5: Lecture 14, Flipping a Coin
        static void FlippingCoin2()
        {
            int coin;
            string coindescription = "tails";
            Random num = new Random();
            Console.WriteLine("Enter a choice, heads or tails <h or t>");
            string userGuess = Console.ReadLine();
            coin = num.Next(0, 2);
            if (coin == 1)
            {
                coindescription = "heads";
            }
            if ((coin == 0 && userGuess == "t") || (coin == 1 && userGuess == "h"))
            {
                Console.WriteLine("You win, it's a {0}", coindescription);
            }
            else
            {
                Console.WriteLine("You lose, it's a {0}", coindescription);
            }

        }
        //Method 20: Section 5: Lecture 16, The Guessing Game
        static void GuessingGame()
        {
            int playerguess;
            int theAnswer;
            bool isnumbernotguessed = true;
            string playerinput;

            Random rng = new Random();
            theAnswer = rng.Next(1, 10);

            do
            {
                Console.WriteLine("Enter your guess");
                playerinput = Console.ReadLine();
                playerguess = int.Parse(playerinput);

                if (playerguess == theAnswer)
                {
                    Console.WriteLine("You win!");
                    isnumbernotguessed = false;
                }
                else
                {
                    if (playerguess < theAnswer)
                    {
                        Console.WriteLine("Too Small!");
                    }
                    else
                    {
                        Console.WriteLine("Too Large");
                    }
                }
            } while (isnumbernotguessed);
        }
        //Method 21: Section 
    }
}
      