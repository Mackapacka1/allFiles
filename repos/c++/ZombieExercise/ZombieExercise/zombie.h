#pragma once

#include <iostream>
class zombie
{
public:
	zombie(float attack, float health, std::string occupation);
	float getAttack();
	float getHealth();
	std::string getOccupation();
	void damage(float amount);
	zombie() {}


private:
	float _health;
	float _attack;
	std::string _occupation;
};

