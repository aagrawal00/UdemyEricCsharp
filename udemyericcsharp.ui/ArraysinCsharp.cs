using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyEricCsharp
{
    class ArraysinCsharp
    {
        public void SingleDimensionArrayCreation()
        {
            int i;
            Console.WriteLine("Create a Single Dimension Array");
            int[] numbers = new int[3];
            numbers[0] = 100;
            numbers[1] = 200;
            numbers[2] = 300;

            for (i=0;i<numbers.Length;i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine("\nPress enter to continue");
            Console.ReadLine();
        }
        public void AutoInitializingArrays()
        {
            Console.WriteLine("=> Array Initialization.");

            //Array initialization syntax using the new keyword
            string[] stringarray = new string[] { "one, two, three" };
            Console.WriteLine("StringArray has {0} elements", stringarray.Length);

            //Array initialization syntax without using the new keyword
            bool[] boolarray = { false, true, true };
            Console.WriteLine("boolarray has {0} elements", boolarray.Length);

            //Array initialization using new keyword and size
            int[] intarray = new int[5] { 1, 2, 3, 4, 5 };
            Console.WriteLine("intarray has {0} elements", intarray.Length);

            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
        }

        public void ArraysAndMethods()
        {
            Console.WriteLine("a) Arrays as parameters and return values.");
            
            //pass array as a parameter
            int[] ages = { 20, 21, 22, 29 };
            PrintArrayElements(ages);

            //pass array as a return value
            int[] numbers = GetNumbersArray();
            PrintArrayElements(numbers);
        }
        static void PrintArrayElements(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
                Console.WriteLine("Item {0} is {1}",i,numbers[i]);
        }
        static int[] GetNumbersArray()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            return numbers;
        }
        public void ArrayClassMethods()
        {
            string[] vowels = { "a", "e", "i", "o", "u" };

            //Print
            for (int i = 0; i<vowels.Length; i++)
            {
                Console.Write(vowels[i]);
            }
            Console.WriteLine();

            Console.Write("Reversed:");
            Array.Reverse(vowels);

            //Print
            for(int i=0;i<vowels.Length;i++)
            {
                Console.Write(vowels[i]);
            }
            Console.WriteLine();

            Console.WriteLine("The alphabet has {0} vowels", vowels.Length);
        }

        public void ForEach()
        {
            Console.WriteLine("Demonstrating the foreach loop\n");
                char[] someLetters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j' };
                int[] someNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

                foreach (var letter in someLetters)
                {
                    Console.WriteLine(letter);
                }

                foreach (var num in someNumbers)
                {
                    if (num % 2 != 0)
                    {
                        Console.WriteLine(num);
                    }
                }
                Console.ReadLine();
            }
        }
    }
