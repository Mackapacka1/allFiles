#pragma once
#include <vector>
#include "raylib.h"

const int Cols = 40;
const int Rows = 40;


class Map
{
public:
	static void Draw();
	void initializeMap();
	static void Move();
	static void setDirection(int x, int y);
	static void setPosition(int x, int y);
	static void addToTail();
	static void spawnFruit();
	static Vector2 direction;
	static Vector2 position;
	static Vector2 fruit;
	static std::vector<Vector2> tail;
private:
	static Color getMapColour(int mapValue);
	
	
	
};

