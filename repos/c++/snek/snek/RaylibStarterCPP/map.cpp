#include "map.h"
#include "snake.h"
#include <iostream>
#include <vector>



int map[Rows][Cols]; 
int frame = 0;
float count = 0;
Vector2 Map::direction;
Vector2 Map::position;
Vector2 Map::fruit;
std::vector<Vector2> Map::tail;
Vector2 tailPosition;

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
void Map::Draw() {
	int x = 0;
	int y = 0;


		for (size_t j = 0; j < Cols; j++)
		{
			for (size_t i = 0; i < Rows; i++)
			{
				x = i * 20;
				y = j * 20;
				DrawRectangle(x + 1, y, 18, 18, getMapColour(map[j][i]));
			}
		}

	
}
void::Map::spawnFruit(){
	
	fruit.x = GetRandomValue(0, 40);
	fruit.y = GetRandomValue(0, 40);
	//if ( tile clear ) {spawn fruit at (fruit.x,fruit.y)}
	//else {try again}
	if (map[(int)fruit.x][(int)fruit.y] == 2) {
		map[(int)fruit.x][(int)fruit.y] = 3;
	}
	else {
		spawnFruit();
	}
	
}
//set initial position
void Map::setPosition(int x, int y) {
	position.x = x;
	position.y = y;
}
//on update move the snake in the direction set by setDirection()
void Map::Move()
{

	position.x += direction.x;
	position.y += direction.y;
	if ((fruit.x == position.x) && (fruit.y == position.y)) {
		tail.push_back(position);
		spawnFruit();
	}

	if (!position.x >= 40|| !position.x <= 0||!position.y >= 40||!position.y <= 0) {
		WindowShouldClose();

	}

	//position of snake head
	map[(int)position.x][(int)position.y] = 0;

	//if head impacts with any tile of snake, die
	if (map[(int)position.x][(int)position.y] == 1) {
		std::cout << "die";
	}
	//move tail pieces
		//get position of tail which will spawn behind the head
		tailPosition.x = position.x - direction.x;
		tailPosition.y = position.y - direction.y;
		tail.push_back(tailPosition);
		//replace tile at last tail position
		map[(int)tail.front().x][ (int)tail.front().y] = 2;
		//delete last tail 
		tail.erase(tail.begin());

	std::cout << "\ntail length " << tail.size();
	



}
//increase tail size after eating fruit
void Map::addToTail() {
	

}
//on arrow pressed, change the direction set for movement. 
void Map::setDirection(int x, int y)
{
	direction.x = x;
	direction.y = y;
	
}
 //set tile colour based on object, represented by number.
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
