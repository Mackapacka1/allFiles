#include "Dirt.h"

Dirt::Dirt()
{
	position = Vector2{ 0, 0 };
}

Dirt::Dirt(Vector2 _position)
{
	position = _position;
}

void Dirt::Dig()
{
	digged = true;
}

void Dirt::Update(float dt)
{
}

void Dirt::Draw()
{
	DrawRectangle(position.x, position.y, 32, 32, digged ? DARKBROWN : BROWN);
}
