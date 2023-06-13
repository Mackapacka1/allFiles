#pragma once
#include "Node.h"
class DoubleLinkedList
{
public:
	static void Insert(Node* nodeInsert, int data);
	static void PushBack(int value);
	static void PushFront(int value);
	static void Erase(Node* position);
	static void PopBack();
	static void PopFront();
	static Node* head_node;
	static Node* tail_node;

};

