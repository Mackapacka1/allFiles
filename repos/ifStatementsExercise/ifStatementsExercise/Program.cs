using System;

namespace ifStatementsExercise
{
    internal class Program
    {
        static void Main()
        {
            bool playerAlive = true;
           int invulnerabilityTimer = 10;
            if (invulnerabilityTimer == 0)
            {
                Console.Write("vulnerable");
                if(playerAlive == true)
                {
                    invulnerabilityTimer -= 1;
                }
            }
            else if (invulnerabilityTimer < 0)
            {
                Console.Write("invulnerability");
            }
            else if (invulnerabilityTimer > 0)
            {
                invulnerabilityTimer=0;
            }
            
           
            if (playerAlive == true)
            { 
                


                Console.Write("player is alive");
            }
            else
            {
                Console.Write("is ded");
            }
        }
    }
}
