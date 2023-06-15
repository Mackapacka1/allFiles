#include "DoubleLinkedList.h"
#include <iostream>

void DoubleLinkedList::Insert(Node* nodeInsert, int value)
{

	Node* new_node = new Node();
	new_node->data = value;
	new_node->prev = nullptr;
	new_node->next = (nodeInsert);
	
	if ((&nodeInsert) != nullptr) {
		new_node->prev = (nodeInsert)->prev;
		if ((nodeInsert)->prev != nullptr) {
			(nodeInsert)->prev->next = new_node;
		}
		(nodeInsert)->prev = new_node;
	}
	if ((head_node) == (nodeInsert)) {
		head_node = new_node;
	}
	if (&tail_node == nullptr) {
		tail_node = new_node;
	}
	return;
	
}

Node* DoubleLinkedList::Find(int index) {
	Node* foundNode = head_node;

	for (size_t i = 1; i < index; i++)
	{
		if (foundNode != nullptr)
		{
			foundNode = foundNode->next;
		}
		if (foundNode == nullptr)
		{
			return nullptr;
		}
	}

	return foundNode;

}
void DoubleLinkedList::PushBack(int data) 
{
	Node* node = new Node{};
	node->data = data;
	node->next = nullptr;
	node->prev = tail_node;

	//Something is in the list
	if (tail_node != nullptr) 
	{
		(tail_node)->next = node;
	}
	//List is empty
	else
	{
		head_node = node;
	}
	tail_node = node;

}
void DoubleLinkedList::PushFront(int data) 
{
	Node* node = new Node{};
	node->data = data;
	node->prev = nullptr;
	node->next = head_node;

	if (head_node != nullptr)
	{
		head_node->prev = node;
	}
	else
	{
		tail_node = node;
	}
	head_node = node;
}
void DoubleLinkedList::Erase(Node* position) 
{
	if (head_node == position) {
		head_node = head_node->next;
	}
	if (tail_node == position)
	{
		tail_node = tail_node->prev;
	}
	if (position->next != nullptr) {
		position->next->prev = position->prev;
	}
	if (position->prev != nullptr) {
		position->prev->next = position->next;
	}
	delete position;
	
}
void DoubleLinkedList::PopFront()
{
	Node* n = new Node{};
	if (head_node != nullptr) {
		n = head_node;
	}
	if (head_node->next != nullptr) {
		head_node->next->prev = nullptr;
	}
	head_node = head_node->next;
	delete n;
}

void DoubleLinkedList::PopBack()
{
	Node* n = new Node{};
	if (tail_node != nullptr) {
		n = tail_node;
	}
	if (tail_node->prev != nullptr) {
		tail_node->prev->next = nullptr;
	}
	tail_node = tail_node->prev;
	delete n;
}

void DoubleLinkedList::Print()
{
	Node* current = head_node;

	while (current != nullptr)
	{
		std::cout << current->data << " ";
		current = current->next;
	}
}