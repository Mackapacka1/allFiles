#include "snake.h"
#include "raylib.h"
#include "map.h"


void snake::Update(float dt) 
{
    /*movement
    this code sets the direction that the player will move but
    will not move the character itself. 

    */
    if (IsKeyPressed(KEY_LEFT)) {
        map::setDirection(-1, 0);

    }
    if (IsKeyPressed(KEY_RIGHT)) {
        map::setDirection(1, 0);
    }
    if (IsKeyPressed(KEY_UP)) {
        map::setDirection(0, 1);
    }
    if (IsKeyPressed(KEY_DOWN)) {
        map::setDirection(0, -1);
    }
    //on frame update, move the character in the direction previously stated
    map::move(map::direction.x, map::direction.y);

}
void snake::Draw() {

}
Color map::getMapColour(int mapValue) {
    switch (mapValue) {
        //snake head
    case 0: return DARKGREEN;
        //snake tail
    case 1: return GREEN;
        //empty tile
    case 2: return GRAY;
        //fruit
    case 3: return RED;
    }
}