using System;

namespace sumArray
{
    internal class Program
    {

        static void Main()
        {
            Console.WriteLine("enter array lengths");

            int size = Int32.Parse(Console.ReadLine());
            Console.Clear();
            int sumResult = Sum(size);
            Console.WriteLine("\n");
            int sumResult2 = Sum1(size);
            Console.WriteLine("\n");
            Console.WriteLine(sumResult);
            Console.WriteLine(sumResult2);
            Console.WriteLine("\n");
            Console.WriteLine("total answer is " + (sumResult + sumResult2));
            Console.ReadKey();
        }
        static int Sum(int a)
        {
            int[] array1 = new int[a];

            for (int i = 0; i < a; i++)
            {
                Random rnd = new Random();
                array1[i] = rnd.Next(1, 20);
            }
            foreach (int i in array1)
            {
                Console.WriteLine(i);
            }
            int result1 = 0;
            for (int j = 0; j < a; j++)
            {

                result1 += array1[j];

            }

            return result1;
        }
        static int Sum1(int a)
        {
            int[] array2 = new int[a];
            for (int i = 0; i < a; i++)
            {
                Random rnd = new Random();
                array2[i] = rnd.Next(1, 20);
            }
            foreach (int i in array2)
            {
                Console.WriteLine(i);
            }
            int result2 = 0;
            for (int j = 0; j < a; j++)
            {

                result2 += array2[j];

            }
            return result2;

        }


    }
}
