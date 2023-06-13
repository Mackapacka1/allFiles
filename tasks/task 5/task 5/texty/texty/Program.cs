using AdventureGame;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace AdventureGame
{
    internal class Program
    {
        static void Main()
        {
            Room[,] map = new Room[3, 3];
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    map[row, col] = new Room();
                }
            }
            Player p = new Player();
            Enemy e = new Enemy(10, 27, 6);
            PowerUp pu = new PowerUp();
            map[1, 1].AddGameObject(p);
            map[2, 0].AddGameObject(e);
            map[0, 1].AddGameObject(pu);
            while (true)
            {
                Console.Clear();
                for (int row = 0; row < 3; row++)
                {
                    for (int col = 0; col < 3; col++)
                    {
                        map[row, col].Draw();
                    }
                    Console.WriteLine();
                }
                string userInput1 = Console.ReadLine();
                Console.Clear();

                while (true) {
                    switch (userInput1)
                    {
                        case "w":
                            p.Move(1, 0, map);
                            break;
                        case "a":
                            p.Move(0, -1, map);
                            break;
                        case "s":
                            p.Move(-1, 0, map);
                            break;
                        case "d":
                            p.Move(0, -1, map);
                            break;

                    }
                    for (int row = 0; row < 3; row++)
                    {
                        for (int col = 0; col < 3; col++)
                        {
                            map[row, col].Draw();
                        }
                        Console.WriteLine();
                    }
                    Console.ReadLine();
                }
               
                
            }
        }
    }
}
