#pragma once
#include "Mob.h"

class Enemy : public Mob
{
public:
	Enemy(int index, const char* texturePath);
	void Update(float dt) override;
	void Draw() override;

private:
	float moveTimer;
};

