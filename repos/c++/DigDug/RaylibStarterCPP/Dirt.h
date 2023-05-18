#pragma once
#include "raylib.h"

class Dirt
{

public:
	Dirt();
	Dirt(Vector2 _position);
	Vector2 GetPosition() { return position; }
	void Dig();
	void Update(float dt);
	void Draw();
	bool digged = false;

protected:
	Vector2 position;
	
};

