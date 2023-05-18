#pragma once

#include "Dirt.h"
#include "raylib.h"

const int COLS = 25;
const int ROWS = 16;

class Map
{
public:
	Map();

	static bool CheckDirtIsWalkable(int index);
	static void DigAtSpot(int index);
	static Vector2 Position(int index);
	void Draw();

	static void MoveLeft(int *index);
	static void MoveRight(int *index);
	static void MoveUp(int *index);
	static void MoveDown(int *index);

	static Dirt dirts[COLS * ROWS];
};

