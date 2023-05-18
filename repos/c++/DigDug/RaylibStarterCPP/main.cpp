/*******************************************************************************************
*
*   raylib [core] example - Basic window
*
*   Welcome to raylib!
*
*   To test examples, just press F6 and execute raylib_compile_execute script
*   Note that compiled executable is placed in the same folder as .c file
*
*   You can find all basic examples on C:\raylib\raylib\examples folder or
*   raylib official webpage: www.raylib.com
*
*   Enjoy using raylib. :)
*
*   This example has been created using raylib 1.0 (www.raylib.com)
*   raylib is licensed under an unmodified zlib/libpng license (View raylib.h for details)
*
*   Copyright (c) 2014 Ramon Santamaria (@raysan5)
*
********************************************************************************************/

#include "raylib.h"

#define RAYGUI_IMPLEMENTATION
#define RAYGUI_SUPPORT_ICONS
#include "raygui.h"
#include "Dirt.h"
#include "Player.h"
#include "Map.h"
#include "Enemy.h"

int main(int argc, char* argv[])
{
    // Initialization
    //--------------------------------------------------------------------------------------
    int screenWidth = 800;
    int screenHeight = 450;

    InitWindow(screenWidth, screenHeight, "raylib [core] example - basic window");
    
    //This contains information about all the dirt tiles
    Map map = Map{};

    //Array of mobs
    const int MOB_COUNT = 3;
    Mob* mobs[MOB_COUNT];
    mobs[0] = new Player{};

    //Set up random seed
    srand(GetTime());

    //COLS*how far to right... + height (1-14)
    int enemyIndex = (ROWS * 9) + 12;
  
    mobs[1] = new Enemy{enemyIndex, "Images/Enemy.png"};

    //create 1x3 hole for the enemy to run around in
    Map::DigAtSpot(enemyIndex);
    Map::DigAtSpot(enemyIndex - ROWS);
    Map::DigAtSpot(enemyIndex + ROWS);

    enemyIndex = (ROWS * 9) + 2;

    mobs[2] = new Enemy{enemyIndex, "Images/Enemy.png"};

    //create 1x3 hole for the enemy to run around in
    Map::DigAtSpot(enemyIndex);
    Map::DigAtSpot(enemyIndex - ROWS);
    Map::DigAtSpot(enemyIndex + ROWS);

    SetTargetFPS(60);
    //--------------------------------------------------------------------------------------

    // Main game loop
    while (!WindowShouldClose())    // Detect window close button or ESC key
    {
        float deltaTime = GetFrameTime();

        // Update
        //----------------------------------------------------------------------------------
        for (size_t i = 0; i < MOB_COUNT; i++)
        {
            mobs[i]->Update(deltaTime);
        }
        //----------------------------------------------------------------------------------
        
       
        // Draw
        //----------------------------------------------------------------------------------
        BeginDrawing();

        //Draw dirt tiles
        map.Draw();

        //Draw mobs
        for (size_t i = 0; i < MOB_COUNT; i++)
        {
            mobs[i]->Draw();
        }

        EndDrawing();
        //----------------------------------------------------------------------------------
    }

    // De-Initialization
    //--------------------------------------------------------------------------------------   
    CloseWindow();        // Close window and OpenGL context
    //--------------------------------------------------------------------------------------

    return 0;
}