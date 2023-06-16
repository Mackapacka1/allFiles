#include "Tree.h"
#include "raylibLibrary/Raylib/include/raylib.h"
#include <cstdlib>
#include <stdio.h>
#include <iostream>
using namespace std;
void Tree::Insert()
{
	int x, y, aah;

	Node* n = new Node;
	while (n != nullptr)
	{
		cout << n<<"\n";
		cout << "/   \\";
		cout << n->left << "    " << n->right;
		if (IsKeyPressed(KEY_RIGHT) || IsKeyPressed(KEY_D)) {
			n = n->right;
		}
		if (IsKeyPressed(KEY_LEFT) || IsKeyPressed(KEY_A)) {
			n = n->right;
		}
	}
	int value;
	std::cin >> value;
	n->data = value;
	//if(no branch had been added){set new node as both branch and leaf}
	//else{turn old leaf node into branch node}
	if (branch_node == nullptr) {
		branch_node = n;
		leaf_node = n;
	}
	else
	{
		branch_node = leaf_node;
		leaf_node = n;
	}


}

void Tree::Erase()
{
	Node* n = new Node;
	while (n != nullptr)
	{
		if (IsKeyPressed(KEY_RIGHT) || IsKeyPressed(KEY_D)) {
			n = n->right;
		}
		if (IsKeyPressed(KEY_LEFT) || IsKeyPressed(KEY_A)) {
			n = n->right;
		}
		if (n->right && n->left) {
			delete n;
		}
	}
	

}
void Tree::Draw(Node* node, int space) {
	if (node == nullptr) {
		return;
	}
	aah += space;
	Draw(node->right, aah);

	DrawCircle(x, y, 15, BLACK);
	DrawText(TextFormat(" % i ", (node->data)), x, y, 15, BLACK);
	x += 20;
	Draw(node->left, aah);
}
