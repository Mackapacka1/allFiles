#pragma once

#include "raylib.h"
#include <string>
#include <vector>

using namespace std;

class DataFile
{
public:
	struct Record {
		Image image;
		string name;
		int age;
	};
private:
	
	int* recordIndexes;



public:
	DataFile();
	~DataFile();

	Record* Load(int i,string filename);

private:
	void Clear();

};

