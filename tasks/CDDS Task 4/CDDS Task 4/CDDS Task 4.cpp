// CDDS Task 4.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include "HashHunction.h"
#include "HashTable.h"

int main()
{
    HashTable table = HashTable{};
    const char aaah[] = {'h','e','l','l','o',',',' ','w','o','r','l','d'};
    std::cout << aaah<<"\n";
    int numba = HashFunction::ELFHash((unsigned char*)aaah, sizeof(aaah));
    int value = HashFunction::badHash(aaah, sizeof(aaah));
    int funnyName = HashFunction::BKDRHash(aaah, sizeof(aaah));
    std::cout <<"ELFHash "<< numba << " badHash " << value << " BKDRHash " << funnyName << "\n";
    table.createTable();
    table.addToTable(numba);
    table.addToTable(value);
    table.addToTable(funnyName);
    table.printTable();
    delete table.tableArray;
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
