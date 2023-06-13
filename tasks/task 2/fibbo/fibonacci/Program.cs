using System;
using System.ComponentModel;

namespace Fibbonacci
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("enter first number");
            int userInput = Int32.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("enter second number");
            int userInput1 = Int32.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("enter length");
            int fibonacci = Int32.Parse(Console.ReadLine());
            Console.Clear();

            int[] numbers = new int[fibonacci];
            numbers[0] = userInput;
            numbers[1] = userInput1;

            int i = 0;
            while (i < fibonacci - 2)
            {
                numbers[i + 2] = numbers[i] + numbers[i + 1];

                i++;
                //else
                //{
                //    numbers[i + 3] = numbers[i + 1] + numbers[i + 2];
                //}
            }
            foreach (var item in numbers)
            {
                Console.WriteLine(item);

            }



            Console.ReadKey();




        }
    }
}
