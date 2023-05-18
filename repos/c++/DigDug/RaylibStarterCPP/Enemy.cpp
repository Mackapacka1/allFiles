#include "Enemy.h"
#include <stdlib.h>  
#include "Map.h"
#include <iostream>

void Enemy::Update(float dt)
{
	//Reduce timer
	moveTimer -= dt;

	if (moveTimer < 0)
	{
		//Move once per 0.6 seconds
		moveTimer = 0.6f;
		
		//Move randomly
		int r = rand() % 4;
		int moveIndex = indexPosition;
		switch (r)
		{
		case 0: Map::MoveLeft(&moveIndex); break;
		case 1: Map::MoveRight(&moveIndex); break;
		case 2: Map::MoveUp(&moveIndex); break;
		case 3: Map::MoveDown(&moveIndex); break;
		}

		//Only move in 'open' dirt
		if (Map::CheckDirtIsWalkable(moveIndex))
		{
			indexPosition = moveIndex;
			desiredPosition = Map::Position(moveIndex);
		}
	}

	//Move towards desired position
	position.x = FloatTo(position.x, desiredPosition.x, speed);
	position.y = FloatTo(position.y, desiredPosition.y, speed);
}

void Enemy::Draw()
{
	DrawTexture(tex, position.x, position.y, WHITE);
}

Enemy::Enemy(int index, const char* texturePath)
{
	tex = LoadTexture(texturePath);
	indexPosition = index;
	desiredPosition = Map::Position(index);
	position = desiredPosition;
	moveTimer = 2;
	speed = 2;
}