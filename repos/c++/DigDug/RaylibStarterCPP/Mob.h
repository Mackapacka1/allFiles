#pragma once
#include "raylib.h"

class Mob
{
public: 
	Mob();
	Mob(Vector2 _position, const char* texturePath);
	virtual void Update(float deltaTime) {}
	virtual void Draw() {}

protected:
	Texture2D tex;

	//Represents Mob's position in the Map
	int indexPosition;

	//It's physical world position
	Vector2 position;

	//The grid position where it wants to be
	Vector2 desiredPosition;

	float speed = 10;
	float FloatTo(float orig, float target, float amount);
};

