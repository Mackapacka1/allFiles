#include "snake.h"
#include "raylib.h"
#include "map.h"
#include <iostream>


Snake::Snake()
{

}

void Snake::Update(float dt) 
{
    /*movement
    this code sets the direction that the player will move but
    will not move the character itself. 

    */
    if (Map::nextFrame) {
        if (IsKeyPressed(KEY_LEFT) || IsKeyPressed(KEY_A)) {
            //if (direction != right) {change direction}
            if (Map::direction.x != 0 && Map::direction.y != 1)
            {
                Map::setDirection(0, -1);
                std::cout << "left";
            }

        }
        if (IsKeyPressed(KEY_RIGHT) || IsKeyPressed(KEY_D)) {
            //if (direction != left) {change direction}
            if (Map::direction.x != 0 && Map::direction.y != -1)
            {
                Map::setDirection(0, 1);
                std::cout << "right";
            }
        }
        if (IsKeyPressed(KEY_UP) || IsKeyPressed(KEY_W)) {
            //if (direction != down) {change direction}
            if (Map::direction.x != 1 && Map::direction.y != 0)
            {
                Map::setDirection(-1, 0);
                std::cout << "up";
            }
        }
        if (IsKeyPressed(KEY_DOWN) || IsKeyPressed(KEY_S)) {
            //if (direction != up) {change direction}
            if (Map::direction.x != -1 && Map::direction.y != 0)
            {
                Map::setDirection(1, 0);
                std::cout << "down";
            }
        }
    }
    //on frame update, move the character in the direction previously stated
    Map::Move();
    Map::Draw();

}
void Snake::Draw() 
{

}

