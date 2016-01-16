/*Section 1-5*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;
using UdemyEricCsharp.Containers;
using UdemyEricCsharp.Items;

namespace UdemyEricCsharp
{
    class Program
    {
        /*Method 1: Program Calls*/
        static void Main()
        {
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
            Console.WriteLine("Method 19: LuckySevens");
            Console.WriteLine("Method 20: Multiplication Table");
            Console.WriteLine("Method 21: Enhance the Guessing Game");
            Console.WriteLine("Method 22: Void Methods");
            Console.WriteLine("Method 23: Stopwatch");
            Console.WriteLine("Method 24: ParametersandReturnValues");
            Console.WriteLine("Method 25: Rock Paper Scissors Game");
            Console.WriteLine("Method 26: Arrays in C Sharp");
            Console.WriteLine("Method 27: Fun With Strings");
            Console.WriteLine("Method 28: Hangman");
            Console.WriteLine("Method 29: Logging Polymorphic Interface");
            Console.WriteLine("Method 30: RPG Bag System");

            string message = ConfigurationManager.AppSettings["Message"];

            Console.WriteLine("\nThe message is: {0}", message);

            Console.Write(new string('\n', 3));
            Console.WriteLine("Enter 0 to exit this console application");

            int switchcase = int.Parse(Console.ReadLine());

            switch (switchcase)
            {
                case 0: break;
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
                case 19:
                    Console.Clear();
                    LuckySevens();
                    ProgramEnd();
                    break;
                case 20:
                    Console.Clear();
                    MultiplicationTable();
                    ProgramEnd();
                    break;
                case 21:
                    Console.Clear();
                    GuessingGameEnhance();
                    ProgramEnd();
                    break;
                case 22:
                    Console.Clear();
                    VoidMethods();
                    ProgramEnd();
                    break;
                case 23:
                    Console.Clear();
                    Stopwatch();
                    ProgramEnd();
                    break;
                case 24:
                    Console.Clear();
                    ParametersandReturnValues();
                    ProgramEnd();
                    break;
                case 25:
                    Console.Clear();
                    RockPapersScissorsGame();
                    ProgramEnd();
                    break;
                case 26:
                    Console.Clear();
                    ArraysinCsharp();
                    ProgramEnd();
                    break;
                case 27:
                    Console.Clear();
                    Funwithstrings();
                    ProgramEnd();
                    break;
                case 28:
                    Console.Clear();
                    Hangman();
                    ProgramEnd();
                    break;
                case 29:
                    Console.Clear();
                    LoggingPolymorphicInterface();
                    ProgramEnd();
                    break;
                case 30:
                    Console.Clear();
                    RPGBagSystem();
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
            Console.WriteLine("Press any key to go to the main menu, 0 to end the program");
            var input = Console.ReadLine();
            while (true)
            {
                if (input == "0")
                {
                    return;
                }
                Main();
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
        //Method 21: Section 5: Lecture 19, Lucky Sevens
        static void LuckySevens()
        {
            int dice1;
            int dice2;
            int i, sum, count = 0;

            Random rng = new Random();

            for (i = 0; i < 100; i++)
            {
                dice1 = rng.Next(1, 7);
                dice2 = rng.Next(1, 7);

                sum = dice1 + dice2;

                if (sum == 7)
                {
                    count += 1;
                }
            }
            Console.WriteLine("The total number of times the sum was 7 is {0}", count);
        }
        //Method 22: Section 5: Lecture 20, Multiplication Table
        static void MultiplicationTable()
        {
            int i, j, mul;
            Console.WriteLine("\t1\t2\t3\t4\t5\t6\t7\t8\t9");
            for (i = 1; i <= 9; i++)
            {
                Console.Write(i);
                for (j = 1; j <= 9; j++)
                {
                    mul = i * j;
                    Console.Write("\t{0}", mul);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        //Method 23: Section 5: Lecture 21, Enhance the Guessing Game
        static void GuessingGameEnhance()
        {
            int playerguess, numguess = 0;
            int theAnswer;
            bool isnumbernotguessed = true;
            string playerinput;

            Random rng = new Random();
            theAnswer = rng.Next(1, 21);

            do
            {
                Console.WriteLine("Enter your guess");
                playerinput = Console.ReadLine();
                playerguess = int.Parse(playerinput);

                if (playerguess < 21 && playerguess > 0)
                {
                    numguess += 1;
                    if (playerguess == theAnswer)
                    {
                        Console.WriteLine("You win! The number of guesses you took is {0}", numguess);
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
                }
                else
                {
                    Console.WriteLine("Your guess is outside the range. Please enter a number between 1 and 20");
                }
            } while (isnumbernotguessed);
        }
        //Method 24: Section 6: Lecture 24: Void Methods
        static void VoidMethods()
        {
            Messenger obj = new Messenger();
            obj.SayHello();
        }
        //Method 25: Section 6: Lecture 24: Void Methods
        static void Stopwatch()
        {
            Stopwatch obj = new Stopwatch();

            Console.WriteLine("Press any key to start");
            Console.ReadLine();
            obj.Start();

            Console.WriteLine("Press any key to stop");
            Console.ReadLine();
            obj.Stop();
        }
        //Method 26: Section 6: Lecture 25: Demo Parameters and Return Values
        static void ParametersandReturnValues()
        {
            int a, b, c;
            SimpleCalculator obj = new SimpleCalculator();
            Console.WriteLine("Do you want to add, square or find maximum of three numbers?");
            string ans = Console.ReadLine();
            if (ans == "add")
            {
                Console.WriteLine("Enter the two numbers you want to add");
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                Console.WriteLine(obj.Add(a, b));
                Console.ReadLine();
            }
            else if (ans == "square")
            {
                Console.WriteLine("Enter the number you wish to take the square of");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine(obj.Square(a));
                Console.ReadLine();
            }
            else if (ans == "maximum")
            {
                Console.WriteLine("Enter the three numbers");
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                c = int.Parse(Console.ReadLine());
                Console.WriteLine(obj.Maxthree(a, b, c));
                Console.ReadLine();
            }
        }
        //Method 27: Section 6: Lecture 28-31: Rock, Papers and Scissors
        static void RockPapersScissorsGame()
        {
            RockPaperScissors obj = new RockPaperScissors();
            obj.Play();
        }
        //Method 28: Section 7: Lecture 33: Demo: Creating and Manipulating Arrays
        static void ArraysinCsharp()
        {
            ArraysinCsharp obj = new ArraysinCsharp();
            obj.SingleDimensionArrayCreation();
            obj.AutoInitializingArrays();
            obj.ArraysAndMethods();
            obj.ArrayClassMethods();
            obj.ForEach();
        }
        //Method 29: Section 7: Lecture 35: Fun with Strings
        static void Funwithstrings()
        {
            Funwithstrings obj = new Funwithstrings();
            obj.StringsAreImmutable();
            obj.ComparingStrings();
            obj.StringsHaveLengthAndIndexes();
            obj.CasingAndWhiteSpace();
            obj.UsefulCharacterMethods();
            obj.EditingStrings();
            obj.SplitAndJoin();
        }
        //Method 30: Section 7: Live Coding: Hangman
        static void Hangman()
        {
            Hangman obj = new Hangman();
            obj.Play();
        }
        //Method 31: Section 8: Polymorphic Interface
        static void LoggingPolymorphicInterface()
        {
            ILogger log = ILoggerFactory.GetLogger();
            log.WriteToLog("Hello World");
            Console.ReadLine();
        }
        //Method 32: RPG Bag
        static void RPGBagSystem()
        {
            //BagTest();
            //SackTest();
            RemoveTest();
            Console.ReadLine();
        }
        //Method 33: RPG Bag 
        private static void RemoveTest()
        {
            Bag myBag = new Bag(3);

            var Item1 = new Sword();
            var Item2 = new Potion();
            var Item3 = new Sword();

            myBag.AddItem(Item1);
            myBag.AddItem(Item2);
            myBag.AddItem(Item3);

            myBag.DisplayContents();

            var removed = myBag.RemoveItem();
            Console.WriteLine("Removed a {0}", removed.Name);

            myBag.DisplayContents();
        }
        private static void BagTest()
        {
            Bag myBag = new Bag(3);

            var Item1 = new Sword();
            var Item2 = new Potion();

            myBag.AddItem(Item1);
            myBag.AddItem(Item2);

            myBag.DisplayContents();
        }
        private static void SackTest()
        {
            Sack sack = new Sack(4);

            var item1 = new Sword();
            var item2 = new Potion();

            sack.AddItem(item1);
            sack.AddItem(item2);

            sack.DisplayContents();
        }
    }
}
