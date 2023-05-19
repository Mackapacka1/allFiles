#include "map.h"
map Map[Rows][Cols];

void map::draw() {
	for (size_t j = 0; j < Cols; j++)
	{
		for (size_t i = 0; i < Rows; i++)
		{
			Map[j][i].draw();
		}
	}
}

void map::move(int x, int y)
{
	

	//increase tail size
	//tail.push_back(Vector2{2,2});
}

void map::setDirection(int x, int y)
{
	direction.x += x;
	direction.y += y;
}

