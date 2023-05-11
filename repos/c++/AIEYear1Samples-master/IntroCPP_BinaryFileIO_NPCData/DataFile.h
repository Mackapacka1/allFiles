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
	int recordCount;
	std::vector<Record*> records;	// delete this vector. Load only the required record 



public:
	DataFile();
	~DataFile();

	void AddRecord(string imageFilename, string name, int age);
	Record* GetRecord(int index);

	//returns recordCount
	int GetRecordCount()
	{ return recordCount; };

	// save data onto file of name (string filename)
	void Save(string filename);

	// read data file of name (string filename)
	void Load(string filename);

private:
	void Clear();

};

