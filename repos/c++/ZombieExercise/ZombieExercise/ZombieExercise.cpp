// ZombieExercise.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include "zombie.h"
int main()
{
	int random = rand() % 4 + 0;
	zombie * zombieLad[5];

	zombieLad[0] = zombie(10, 100, "architect");
	zombieLad[1] = zombie(10, 100, "architect");
	zombieLad[2] = zombie(10, 100, "architect");
	zombieLad[3] = zombie(10, 100, "architect");
	zombieLad[4] = zombie(10, 100, "architect");
	for (size_t i = 0; i < 4; i++)
	{
		zombieLad[i].damage;
	}



}


