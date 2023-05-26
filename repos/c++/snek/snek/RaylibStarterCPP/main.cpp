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


#define RAYGUI_IMPLEMENTATION
#define RAYGUI_SUPPORT_ICONS
#include "raygui.h"
#include "map.h"
#include "snake.h"



int main(int argc, char* argv[])
{
    // Initialization
    //--------------------------------------------------------------------------------------
    int screenWidth = Rows*20;
    int screenHeight = Cols*20;

    InitWindow(screenWidth, screenHeight, "snake");
    Map map = Map{};
    Map::position.x = 0;
    Map::position.y = Cols;
    Map::direction.x = -1;
    Map::direction.y = 0;
    //Map::tail.resize(398);
    Map::tail.resize(2);
    //map.setPosition(Map::position.x, Map::position.y);
    //map.setDirection(Map::direction.x, Map::direction.y);
    map.initializeMap();
    map.spawnFruit();
    map.nextFrame = true;


    SetTargetFPS(10);
    //--------------------------------------------------------------------------------------

    // Main game loop
    while (!WindowShouldClose())    // Detect window close button or ESC key
    {
        float deltaTime = GetFrameTime();

        // Update
        //----------------------------------------------------------------------------------
        int speed = 15;
        //input original position and starting direction.


        //----------------------------------------------------------------------------------
        
       
        // Draw
        //----------------------------------------------------------------------------------
        BeginDrawing();
        
        Snake::Update(deltaTime);
        ClearBackground(BLACK);
        EndDrawing();
        //----------------------------------------------------------------------------------
    }

    // De-Initialization
    //--------------------------------------------------------------------------------------   
    CloseWindow();        // Close window and OpenGL context
    //--------------------------------------------------------------------------------------

    return 0;
}