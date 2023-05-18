#include "DataFile.h"
#include <fstream>
#include <iostream>
#include <string>
using namespace std;
int recordCount = 0;
DataFile::DataFile()
{
	

	ifstream infile("npc_data.dat", ios::binary);
	infile.read((char*)&recordCount, sizeof(int));
	recordIndexes = new int[recordCount];
	recordIndexes[0] = infile.tellg();
	

	infile.close();
}

DataFile::~DataFile()
{
	Clear();
}

DataFile::Record* DataFile::Load(int i, string filename)
{
	ifstream infile(filename, ios::binary);

	//streampos begin, end;
	//begin = infile.tellg();
	
	//Move to current record (i)
	infile.seekg(recordIndexes[i]);

	//Read record
	int nameSize = 0;
	int ageSize = 0;
	int width = 0, height = 0, format = 0, imageSize = 0;

	infile.read((char*)&width, sizeof(int));
	infile.read((char*)&height, sizeof(int));

	imageSize = sizeof(Color) * width * height;

	infile.read(reinterpret_cast<char*>(&nameSize), sizeof(int));
	infile.read((char*)&ageSize, sizeof(int));

	char* imgdata = new char[imageSize];
	infile.read(imgdata, imageSize);

	Image img = LoadImageEx((Color*)imgdata, width, height);
	char* name = new char[nameSize];
	
	int age = 0;
	infile.read((char*)name, nameSize);
	infile.read((char*)&age, ageSize);
	
	string fixedName;
	for (size_t i = 0; i < nameSize; i++)
	{
		//check if any character in name array is "?", if so, stop reading, else add character to string using concatenation
		if (name[i] == '?') {
			i = nameSize;
		}

		else {
			fixedName += name[i];
		}
	}
	//Convert record to on screen ui
	Record* r = new Record();
	r->image = img;
	r->name = fixedName;
	r->age = age;
	delete [] imgdata;
	delete [] name;

	
	
	//Get position of the next record
	recordIndexes[i + 1] = infile.tellg();

	infile.close();
	return r;
}

void DataFile::Clear()
{
}
