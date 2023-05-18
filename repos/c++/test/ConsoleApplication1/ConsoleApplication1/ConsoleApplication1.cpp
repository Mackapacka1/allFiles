

#include <iostream>
using namespace std;
int main()
{
	string myString = "aaaaaaaaahhhhhhh";
	cout << myString;
	cout << "\n\n";
	myString = "aaaaaahhhh?hhhh";
	cout << myString;
	int length = 0;
	cout << "\n\n";
	cout << "\n\n";
	cout << "\n\n";
	for (size_t i = 0; i < myString.length(); i++)
	{
		cout << i;
		if (myString[i] == '?') {
			i = myString.length();

		}
		else {
			cout << myString[i];

		}
	}
	cout << "\n\n";
	cout << length;
	cout << "\n\n";

	for (size_t i = 0; i < length; i++)
	{

		//cout << myString[i];
		

	}
}

