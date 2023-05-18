#include "Player.h"
#include "Map.h"

Player::Player()
{
    indexPosition = (COLS * 5) + (ROWS / 2);
    desiredPosition = Map::Position(indexPosition);
	position = desiredPosition;
    Map::DigAtSpot(indexPosition);

	tex = LoadTexture("Images/Dug_Idle_R.png");
	speed = 3;
    
}

void Player::Update(float dt)
{
    //Movement
    if (IsKeyPressed(KEY_LEFT))
    {
        Map::MoveLeft(&indexPosition);
        desiredPosition = Map::Position(indexPosition);
        Map::DigAtSpot(indexPosition);
    }
    else if (IsKeyPressed(KEY_RIGHT))
    {
        Map::MoveRight(&indexPosition);
        desiredPosition = Map::Position(indexPosition);
        Map::DigAtSpot(indexPosition);
    }
    else if (IsKeyPressed(KEY_UP))
    {
        Map::MoveUp(&indexPosition);
        desiredPosition = Map::Position(indexPosition);
        Map::DigAtSpot(indexPosition);
    }
    else if (IsKeyPressed(KEY_DOWN))
    {
        Map::MoveDown(&indexPosition);
        desiredPosition = Map::Position(indexPosition);
        Map::DigAtSpot(indexPosition);
    }

    //Move towards desired position
    position.x = FloatTo(position.x, desiredPosition.x, speed);
    position.y = FloatTo(position.y, desiredPosition.y, speed);
}

void Player::Draw()
{

    DrawTexture(tex, position.x, position.y, WHITE);
    
}
