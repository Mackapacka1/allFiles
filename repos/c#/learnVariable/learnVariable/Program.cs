using System;



namespace learnVariable
{
    internal class Program
    {
        static void Main()
        {
            //string greeting = "hello world";
            //int playerscore = 0;
            //string displayscore = "score is" + playerscore + ".";

            //console.writeline(greeting);
            //console.writeline(playerscore);
            //console.writeline(displayscore);
            //console.readkey();





            string greeting = "hello user! the game's start condition is:";
            bool gameStarted = false;
            string displayGameState = greeting + gameStarted;
            Console.WriteLine(displayGameState);    
            gameStarted = true;
            displayGameState = greeting + gameStarted;
            Console.WriteLine(displayGameState);
            Console.ReadKey();  

        }
    }
}
