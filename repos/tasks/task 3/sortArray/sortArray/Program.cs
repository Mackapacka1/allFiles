﻿using System;
using System.Globalization;

namespace sortArray
{
    internal class Program
    {

        static int size = Int32.Parse(Console.ReadLine());
         
        static void Main()
        {
            Console.WriteLine("enter size of array");
            arraySort(size);
            Console.ReadKey();
        }
        static void arraySort(int size)
        {
            int[] numArray = new int[size];
            int i = 0;
            while (i<size)
            {
                Random rnd = new Random();
                numArray[i] = rnd.Next(10,30);
                i++;

            }
            foreach(int num in numArray)
            {
                Console.WriteLine(num + "\n");
            }
           
            for (int k = 0; k < size; k++)
            {
                for (int j = 0; j < size-1; j++)
                {
                    if (numArray[j] < numArray[j + 1])
                    {
                        int sort = numArray[j];
                        numArray[j] = numArray[j+1];
                        numArray[j + 1] = sort;
                    }
                }
            }
            foreach (int num in numArray)
            {
                Console.WriteLine(num);
                
            }

        }
    }
}
