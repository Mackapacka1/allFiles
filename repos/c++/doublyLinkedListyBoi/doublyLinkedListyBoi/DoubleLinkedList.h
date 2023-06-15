#pragma once
#include "Node.h"

class DoubleLinkedList
{
public:
	void Insert(Node* nodeInsert, int value);
	Node* Find(int index);
	void PushBack(int value);
	void PushFront(int value);
	void Erase(Node* position);
	void PopFront();
	void PopBack();
	void Print();

	Node* head_node;
	Node* tail_node;

};

