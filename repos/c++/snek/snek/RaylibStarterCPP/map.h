#pragma once
#include <vector>
#include "raylib.h"


const int Cols = 20;
const int Rows = 20;

class Map
{
public:
	static bool nextFrame;
	static void Draw();
	//static void win();
	void initializeMap();
	static void Move();
	static void setDirection(int x, int y);
	static void setPosition(int x, int y);
	static void spawnFruit();
	static Vector2 direction;
	static Vector2 position;
	static Vector2 fruit;
	static std::vector<Vector2> tail;
private:
	static Color getMapColour(int mapValue);
	
	
	
};

