
#include <iostream>

int main(int argc, char** argv)
{
	const int NUM_NUMBERS = 5;
	int numbers[NUM_NUMBERS] = { 10, 20, 30, 40, 50 };

	/* 
	TODO: Print each value of the array in order
	Expected:
		10, 20, 30, 40, 50,
	*/
	// Task1: Write your Code here
	for (size_t i = 0; i < NUM_NUMBERS; i++)
	{
		std::cout << numbers[i] << std::endl;
	}
	std::cout << std::endl;

	/*
	TODO: Print each value of the array in reverse order
	Expected:
		50, 40, 30, 20, 10,
	*/

	// Task 2: Write your Code here
	for (size_t i = 0; i < NUM_NUMBERS; i++)
	{
		std::cout << numbers[NUM_NUMBERS-1-i] << std::endl;
	}


}
