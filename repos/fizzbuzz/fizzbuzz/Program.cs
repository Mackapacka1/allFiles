using System;
using System.ComponentModel;

namespace Fizzbuzz
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("amount of numbers wanted (all numbers will be randomly generated)");
            int userInput = Int32.Parse(Console.ReadLine());
            int[] numbers = new int[userInput];
            Console.Clear();
            int i = 0;
            Random random = new Random();
            while (i < userInput)
            {
                //numbers[i] = random.Next(0,100);
                numbers[i] = i + 1;
                i++;
            }

            int j = 0;
            while (j < userInput)
            {
                
                if (numbers[j] % 5 == 0 && numbers[j] % 3 == 0)
                {
                    Console.Write("fizzbuzz\n");
                }
                else if (numbers[j] % 5 == 0)
                {
                    Console.Write("fizz\n");
                }
                else if (numbers[j] % 3 == 0)
                {
                    Console.Write("buzz\n");
                }
                else
                {
                    Console.Write(numbers[j] + "\n");
                }
                j++;
            }
            Console.ReadKey();





        }
    }
}
