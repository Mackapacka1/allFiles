#include "map.h"
#include <iostream>


int map[Rows][Cols];
float count = 0;
Vector2 Map::direction;
Vector2 Map::position;

void Map::initializeMap() {
	for (size_t j = 0; j < Cols; j++)
	{
		for (size_t i = 0; i < Rows; i++)
		{
			map[j][i] = 2;
			//getMapColour(map[j][i]);
		}
	}
}
//on run, draw all values on the map
void Map::Draw(int deltaTime) {
	int x = 0;
	int y = 0;
	for (size_t j = 0; j < Cols; j++)
	{
		for (size_t i = 0; i < Rows; i++)
		{
			x = i * 20;
			y = j * 20;
			DrawRectangle(x+1, y, 18, 18, getMapColour(map[j][i]));
		}
	}
	count += 0.5;
		
		std::cout << count;
}
//on update move the snake in the direction set by setDirection()
void Map::Move()
{
	position.x += direction.x;
	position.y += direction.y;
	//position of snake head
	map[(int)position.x][(int)position.y] = 1;

	//increase tail size
	//tail.push_back(Vector2{2,2});
}
//on arrow pressed, change the direction set for movement, 
void Map::setDirection(int x, int y)
{
	direction.x = x;
	direction.y = y;
}

Color Map::getMapColour(int mapValue) {
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
