#include "DoubleLinkedList.h"

Node* DoubleLinkedList::head_node;
Node* DoubleLinkedList::tail_node;

void DoubleLinkedList::Insert(Node* nodeInsert, int data)
{

	Node* new_node = new Node();
	new_node->data = data;
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
	if (head_node !=nullptr)
	{
		(head_node)->prev = node;
	}
	else
	{
		tail_node = node;
	}
	head_node = node;
}
void DoubleLinkedList::Erase(Node* position) 
{

}
void DoubleLinkedList::PopFront()
{


	if (&head_node != nullptr) {
		Node* n = new Node{};
		n = head_node;
		if ((head_node)->next != nullptr) {
			(head_node)->next->prev = nullptr;
		}
		Node* aah = new Node{};
		aah = (head_node)->next;
		head_node = aah;
		delete n;
		delete aah;
	}
}
void DoubleLinkedList::PopBack()
{
	if (tail_node != nullptr) {
		Node* n = new Node{};
		n = tail_node;
		if ((tail_node)->prev != nullptr) {
			(tail_node)->prev->next = nullptr;
		}
		Node* aah = new Node{};
		aah = (tail_node)->prev;
		tail_node = aah;
		delete n;
		delete aah;
	}
}