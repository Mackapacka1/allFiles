using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Raylib;
using static Raylib.Raylib;

namespace tonk
{
    class Program
    {

        static void Main()
        {

            Game game = new Game();

            SetTargetFPS(60);
            InitWindow(640, 480, "Tanks for Everything!");
            game.Init();
            while (!WindowShouldClose())
            {
                if (game.isAlive)
                {

                    game.Update();
                    game.Draw();
                }



            }
            game.Shutdown();
            CloseWindow();



        }
    }
}
