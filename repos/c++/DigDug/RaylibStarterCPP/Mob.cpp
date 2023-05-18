#include "Mob.h"
#include <algorithm>    

Mob::Mob()
{
	desiredPosition = Vector2{ 320, 320 };
	position = desiredPosition;
	tex = LoadTexture("Images/Dug_Idle_R.png");
	speed = 4;
}

Mob::Mob(Vector2 _position, const char* texturePath)
{
	desiredPosition = _position;
	position = desiredPosition;
	tex = LoadTexture(texturePath);
	speed = 4;
}

//Move float 'orig' to float 'target' at a speed of 'amount'
float Mob::FloatTo(float orig, float target, float amount)
{
	float result;

	if (orig < target)
		result = std::min(orig + amount, target);
	else if (orig > target)
		result = std::max(orig - amount, target);
	else
		result = target;

	return result;
}
