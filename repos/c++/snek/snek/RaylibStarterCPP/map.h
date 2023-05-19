#pragma once
#include <vector>
#include "raylib.h"

const int Cols = 40;
const int Rows = 40;
Vector2 position;
class map
{
public:
	void draw();

	static void move(int x, int y);
	Vector2 direction;
	static void setDirection(int x, int y);
	
	//std::vector<Vector2> tail;
private:
	Color getMapColour(int mapValue);
};

