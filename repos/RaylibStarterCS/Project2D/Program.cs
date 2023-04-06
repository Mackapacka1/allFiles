using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Raylib;
using static Raylib.Raylib;

namespace Project2D
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();

            InitWindow(640, 480, "Hello World");

            game.Init();

            while (!WindowShouldClose())
            {
                

                if (game.isAlive)
                {
                    game.Update();
                    game.Draw();
                    Console.WriteLine("is alive");
                }
                else
                {
                    game.DrawDeath();
                    Console.WriteLine("is ded");
                }


            }

            game.Shutdown();

            CloseWindow();
        }
    }
}
