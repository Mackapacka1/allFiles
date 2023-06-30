#pragma once
#include "HashHunction.h"
class HashTable {
	int arraySize;
public:
	int *tableArray;
	int count = 0;
	void createTable();
	void addToTable(int data);
	void printTable();

};
