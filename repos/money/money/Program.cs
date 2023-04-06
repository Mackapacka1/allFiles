using System;

namespace money
{
    internal class Program
    {
        static void Main(string[] args)
        {
            currencies Money = new currencies();
            while (true)
            {
                
                int Aud = Int32.Parse(Console.ReadLine());


                Console.WriteLine(Money.Aud + " AUD");
                Console.WriteLine(Money.Usd + " USD");

            }
        }
    }
}
