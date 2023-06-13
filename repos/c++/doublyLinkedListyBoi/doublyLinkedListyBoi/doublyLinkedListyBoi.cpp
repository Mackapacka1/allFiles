// doublyLinkedListyBoi.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include "Raylib/include/raylib.h"
#include "DoubleLinkedList.h"
using namespace std;
int main()
{
	while (!WindowShouldClose)
	{
		
		DoubleLinkedList list = DoubleLinkedList{};
		Node *n = new Node;
		cout << "pick a command";
		cout << "1. add a random number to start\n";
		cout << "2. add a random number to end\n";
		cout << "3. add a random number to given location\n";
		cout << "4. erase last number\n";
		cout << "5. erase first number\n";
		if (cin == 1) {

		}

		while (list.head_node != NULL) {
			cout << list.head_node->data << " ";
			list.head_node = list.head_node->next;
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
