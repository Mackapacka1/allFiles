#pragma once
#include "Mob.h"

class Player : public Mob
{
public:
	Player();
	void Update(float dt) override;
	void Draw() override;
};

