using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Raylib;
using static Raylib.Raylib;
using System.Numerics;

namespace tanks
{
    internal class Program
    {

        static void Main()
        {

            Game game = new Game();

            InitWindow(640, 480, "Hello World");

            game.Init();

            while (!WindowShouldClose())
            {


                    game.Update();
                    game.Draw();
                    Console.WriteLine("is alive");


            }

            game.Shutdown();

            CloseWindow();



        }
    }
}
