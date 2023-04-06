// test.cpp : This file contains the 'main' function. Program execution begins and ends there.
//


#include "zombie.h"

	const int zombieArraySize = 5;




void Draw(float a) {
	int i = a;
	srand(time(0));
	int random = rand() % 5-i;	
	
	zombie greg( 10, 100, "engineer");
	zombie george(10, 100, "engineer");
	zombie geoff(10, 100, "engineer");
	zombie jeff(10, 100, "engineer");
	zombie jeremy(10, 100, "engineer");
	zombie Zombie[zombieArraySize] = { greg, george, geoff, jeff, jeremy };
	switch (random)
	{
	case 0:  Zombie[0].Health -= Zombie[i].Attack;   break;
	case 1:  Zombie[1].Health -= Zombie[i].Attack;   break;
	case 2:  Zombie[2].Health -= Zombie[i].Attack;   break;
	case 3:  Zombie[3].Health -= Zombie[i].Attack;   break;
	default: Zombie[4].Health -= Zombie[i].Attack;   break;

	}
}


int main()
{
	int dead = 0;

	std::cout << std::endl;


	//Zombie[0] = greg;
	//Zombie[1] = george;
	//Zombie[2] = geoff;
	//Zombie[3] = jeff;
	//Zombie[4] = jeremy;

	//zombie* ptr;
	////ptr = &Zombie[0];
	////ptr = &Zombie[1];
	////ptr = &Zombie[2];
	////ptr = &Zombie[3];
	//ptr = &Zombie[4];
	while (dead >= 4) {
		for (size_t i = 0; i < zombieArraySize; i++)
		{


			if (Zombie[0].Health == 0) {
				dead++;
			}
			if (Zombie[1].Health == 0) {
				dead++;
			}
			if (Zombie[2].Health == 0) {
				dead++;
			}
			if (Zombie[3].Health == 0) {
				dead++;
			}
			if (Zombie[4].Health == 0) {
				dead++;
			} 
			Draw(i);
		system("pause");
		}
		
	}
	
}



// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file
