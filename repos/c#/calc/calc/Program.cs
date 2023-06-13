using System;
using System.ComponentModel.DataAnnotations;

namespace calc
{
    internal class Program
    {
        static void Main()
        {
          float UserInput = float.Parse(Console.ReadLine());
           
            
                string Operator = Console.ReadLine();
               
                
                    float UserInput2 = float.Parse(Console.ReadLine());

                 

                        Console.WriteLine(UserInput + Operator + UserInput2);


            //calculating as float
            if (Operator == "*")
            {
                float result = UserInput * UserInput2;
                Console.WriteLine("answer = " + result);
            }

            if (Operator == "+")
            {
                float result = UserInput + UserInput2;
                Console.WriteLine("answer = " + result);
            }

            if (Operator == "/")
            {
                float result = UserInput / UserInput2;
                Console.WriteLine("answer = " + result);
            }

            if (Operator == "-")
            {
                float result = UserInput - UserInput2;
                Console.WriteLine("answer = " + result);
            }

            //calculating as int
            if (Operator == "*")
            {
                 //int round = (result)Math.Round(f);
                float result = (UserInput * UserInput2);
                int round = Convert.ToInt32(result);
               
                Console.WriteLine("answer rounded = " + round);
            }

            if (Operator == "+")
            {
                float result = (UserInput + UserInput2);
                int round = Convert.ToInt32(result);

                Console.WriteLine("answer rounded = " + round);
            }

            if (Operator == "/")
            {
                float result = (UserInput / UserInput2);
                int round = Convert.ToInt32(result);

                Console.WriteLine("answer rounded = " + round);
            }

            if (Operator == "-")
            {
                float result = (UserInput + UserInput2 * -1);
                int round = Convert.ToInt32(result);

                Console.WriteLine("answer rounded = " + round);
            }
        }
    }
}
