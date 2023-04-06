using Microsoft.VisualBasic;
using System;

namespace properties_exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TimePeriod time = new TimePeriod();


            while (true)
            {
                
                Console.ReadLine();
                time.Seconds += 10000;
                Console.WriteLine(time.Seconds + " Seconds = " + time.Minutes + " Minutes = "
                    + time.Hours + " Hours = " + time.Days + " Days.");

                Console.WriteLine(time.Months + " Months, " + time.Weeks % 4.3524 + " weeks, " + time.Days % 7 + " Days, " + time.Hours % 24 + " Hours, " +
                    time.Minutes % 60 + " Minutes, " + time.Seconds % 60 + " Seconds.");



            }
        }
    }
}
