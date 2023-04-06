#pragma once
#include <iostream>

struct zombie
{
public:
	float Health;
	float Attack;

	std::string Occupation;
	zombie(float Health, float Attack, std::string Occupation) {
		health = Health;
		attack = Attack;
		occupation = Occupation;
	}
private: 
	float health;
	float attack;
	std::string occupation;

};

