#include "HashTable.h"
#include <iostream>
int *tableArray;

void HashTable::createTable() {

	tableArray = new int[10];
}

void HashTable::addToTable(int data)
{

	bool noMatch{};
	//if(value inputted is already in array){don't}
	//else {add it to array}
	for (size_t i = 0; i < count; i++)
	{
		!noMatch;
		if (tableArray[i] = data) {
			noMatch;
		}
	}
	if (!noMatch)
	{



		count++;
		// if the table is full, make a bigger one

		if (count == 10) {
			int arraySize = count + 10;
			int* newArray = new int[count];
			newArray = tableArray;
			delete tableArray;
			int* tablearray = new int[arraySize];
			tableArray = newArray;
			delete newArray;
		}
		tableArray[count] = data;
	}
}

void HashTable::printTable()
{
	for (size_t i = 0; i < count; i++)
	{
		std::cout << tableArray[i] << "\n";
	}
}
 