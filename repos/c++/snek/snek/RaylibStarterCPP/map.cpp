#include "map.h"
#include "snake.h"
#include <iostream>
#include <vector>



int map[Rows][Cols]; 
int frame = 0;
float count = 0;
int fruitCount = 0;
Vector2 Map::direction;
Vector2 Map::position;
Vector2 Map::fruit;
std::vector<Vector2> Map::tail;
Vector2 tailPosition;
bool Map::nextFrame;

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
				DrawText(TextFormat(" % i ", (j * 20 + i)), x-7, y, 15, BLACK);
			}
		}

	
}
void::Map::spawnFruit(){
	
	fruit.x = GetRandomValue(0, Rows-1);
	fruit.y = GetRandomValue(0, Cols-1);

		//if ( tile clear ) {spawn fruit at (fruit.x,fruit.y)}
		//else {try again}
		if (map[(int)fruit.x][(int)fruit.y] == 2 || map[(int)fruit.x][(int)fruit.y] == 3) {
			map[(int)fruit.x][(int)fruit.y] = 3;
			fruitCount++;
		}
		else {
			spawnFruit();
		}
	//if(no fruit spawned) {spawnFruit()}
	if (fruitCount == 0) {
		std::cout << "spawn a fruit \n";
		spawnFruit();
	}

	
}
//set initial position
void Map::setPosition(int x, int y) {
	position.x = x;
	position.y = y;
}
void Map::Move()
{
	
	//on update move the snake in the direction set by setDirection()
	position.x += direction.x;
	position.y += direction.y;

	//spawn fruit on impact with head and add to tail.
	if ((fruit.x == position.x) && (fruit.y == position.y)) {
		int currentLength = tail.size();
		tail.push_back(tailPosition);
		int compareLength = tail.size();
		//bug fixing please ignore
		if (!(currentLength < compareLength)) {
			tail.push_back(tailPosition);
		}
		fruitCount--;
		spawnFruit();
	}
	//if(head is offscreen) {die}
	//if (!position.x >= Rows|| !position.x <= 0||!position.y >= Cols||!position.y <= 0) {
	//	WindowShouldClose();

	//}
	
	//if(offscreen){move to other side of screen}
	//this is how it is setup for classic sake

	if (position.x > Rows-1) {
		position.x = 0;
	}
	if (position.x < 0) {
		position.x = Rows - 1;
	}
	if (position.y > Cols-1)
	{
		position.y = 0;
	}
	if (position.y < 0) {
		position.y = Cols - 1;
	}

	//position of snake head
	map[(int)position.x][(int)position.y] = 0;
	nextFrame = true;
	for (size_t i = 0; i < tail.size(); i++)
	{
		if ((tail[i].x == position.x) && (tail[i].y == position.y)) {
			
			CloseWindow();
			map[(int)position.x][(int)position.y] = 4;
			//SetTargetFPS(0);
		}
	}
	
	//if (head impacts with any tile of tail) {die}

	//move tail pieces
		//get position of tail which will spawn behind the head
		tailPosition.x = position.x - direction.x;
		tailPosition.y = position.y - direction.y;

		if (tailPosition.x > Rows - 1) {
			tailPosition.x = 0;
		}	
		if (tailPosition.x < 0) {
			tailPosition.x = Rows - 1;
		}	
		if (tailPosition.y > Cols - 1)
		{	
			tailPosition.y = 0;
		}	
		if (tailPosition.y < 0) {
			tailPosition.y = Cols - 1;
		}
		map[(int)tailPosition.x][(int)tailPosition.y] = 1;
		tail.push_back(tailPosition);
		//replace tile at last tail position
		map[(int)tail.front().x][ (int)tail.front().y] = 2;
		//delete last tail 
		tail.erase(tail.begin());
		
		if (tail.size() == 399) {
			DrawText("you", 0, 0, 200, WHITE);
			DrawText("win", 0, 160, 200, WHITE);

			EndDrawing();
			SetTargetFPS(0);
		}

	std::cout << "\ntail length " << tail.size();
	



}

//on arrow pressed, change the direction set for movement. 
void Map::setDirection(int x, int y)
{
	nextFrame = false;
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
		//test
	case 4: return BLACK;
	}
}
