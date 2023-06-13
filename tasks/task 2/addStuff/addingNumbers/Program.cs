using System;

namespace addingNumbers
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("enter first number");
            float UserInput = float.Parse(Console.ReadLine());

            Console.WriteLine("enter second number");


            float UserInput2 = float.Parse(Console.ReadLine());


            Console.WriteLine("result as float");
            Console.WriteLine(UserInput + UserInput2);
            Console.WriteLine("result as int");
            Console.WriteLine(Math.Floor(UserInput + UserInput2));
            Console.ReadKey();


        }
    }
}
