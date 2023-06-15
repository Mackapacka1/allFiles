// doublyLinkedListyBoi.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include "DoubleLinkedList.h"
#include <random>
using namespace std;
int main()
{
	DoubleLinkedList list{};
	bool close = false;

	while (!close)
	{
	
		cout << "pick a command\n";
		cout << "1. add a random number to start\n";
		cout << "2. add a random number to end\n";
		cout << "3. add a random number to given location\n";
		cout << "4. erase first number\n";
		cout << "5. erase last number\n";
		cout << "6. erase at given location\n";
		cout << "7. close application\n";
		cout << "8. display everything\n";
		srand((unsigned)time(NULL));
		int input;
		cin >> input;
		if (input == 1) {
			list.PushFront(rand()%20);
			system("CLS");
		}
		else if (input ==2)
		{
			list.PushBack(rand() % 20);
			system("CLS");
		}
		else if (input == 3) {
			int input2 = NULL;
			while (input2 == NULL)
			{

				system("CLS");
				cout << "where to insert";
				cin >> input2;
				Node* aah = list.Find(input2);
				if (aah != nullptr) {
					list.Insert(aah, rand() % 20);
					system("CLS");
				}
			}
		}
		else if (input == 4) {
			list.PopFront();
			system("CLS");
		}
		else if (input == 5) {
			list.PopBack();
			system("CLS");
		}
		else if (input == 6) {
			int input2 = NULL;
			if (input2 == NULL)
			{
				system("CLS");
				cout << "what position do you want erased";

				cin >> input2;
				Node* aah = list.Find(input2);
					if (aah != nullptr) {
						list.Erase(aah);
					}
				system("CLS");
			}
		}
		else if (input == 7) {
			close = true;
			system("CLS");
		}
		else if (input == 8)
		{
			system("CLS");
			list.Print();

			int x;
			cin >> x;
			system("CLS");
		}
	}
}