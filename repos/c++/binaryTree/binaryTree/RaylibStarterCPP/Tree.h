#pragma once
#include "Node.h"

class Tree
{
public:
	void Insert();
	void Erase();
	void Draw(Node* node, int space);
	Node* branch_node;
	Node* leaf_node;
	int x, y, aah;

};
