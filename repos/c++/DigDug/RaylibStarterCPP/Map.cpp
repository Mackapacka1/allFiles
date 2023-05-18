#include "Map.h"

Dirt Map::dirts[COLS * ROWS];

Map::Map()
{
	//Setu p dirt
	for (size_t i = 0; i < COLS * ROWS; i++)
	{
		int x = i / ROWS;
		int y = i % ROWS;
		dirts[i] = Dirt(Vector2{ x * 32.0f, y * 32.0f });
	}
}

bool Map::CheckDirtIsWalkable(int index)
{
	return dirts[index].digged;
}

void Map::Draw()
{
	for (size_t i = 0; i < COLS * ROWS; i++)
	{
		dirts[i].Draw();
	}
}

void Map::DigAtSpot(int index)
{
	dirts[index].Dig();
}

//Convert index position into world position
Vector2 Map::Position(int index)
{
	return Vector2{ (index / ROWS) * 32.0f, (index % ROWS) * 32.0f };
}

void Map::MoveLeft(int* index)
{
	*index -= ROWS;
}

void Map::MoveRight(int* index)
{
	*index += ROWS;
}

void Map::MoveUp(int* index)
{
	*index -= 1;
}

void Map::MoveDown(int* index)
{
	*index += 1;
}
