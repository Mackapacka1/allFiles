#include "snake.h"
#include "raylib.h"
#include "map.h"


Snake::Snake()
{

}

void Snake::Update(float dt) 
{
    /*movement
    this code sets the direction that the player will move but
    will not move the character itself. 

    */
    if (IsKeyPressed(KEY_LEFT)|| IsKeyPressed(KEY_A)) {
        Map::setDirection(-1, 0);

    }
    if (IsKeyPressed(KEY_RIGHT)|| IsKeyPressed(KEY_D)) {
        Map::setDirection(1, 0);
    }
    if (IsKeyPressed(KEY_UP)|| IsKeyPressed(KEY_W)) {
        Map::setDirection(0, 1);
    }
    if (IsKeyPressed(KEY_DOWN)|| IsKeyPressed(KEY_S)) {
        Map::setDirection(0, -1);
    }
    //on frame update, move the character in the direction previously stated
    Map::Move();

}
void Snake::Draw() 
{

}

