
#include <vector>
#include <iostream>
using namespace std;
int main()
{
	std::vector<int> larry;
	for (size_t i = 0; i < 10; i++)
	{
		larry.push_back(i);
	}for (size_t i = 0; i < 5; i++)
	{
		larry.pop_back();
	}larry.push_back(5);
	std::cout << larry.front() << "\n";
	std::cout << larry.back() << "\n";
}

