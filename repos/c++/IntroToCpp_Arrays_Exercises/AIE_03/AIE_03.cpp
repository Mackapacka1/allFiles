#include <iostream>
#include <string>

const int* BinarySearch(const int* arr, int count,int r, int searchVal);
void TestResult(const int* result, int* const expected);


int main(int argc, char** argv)
{
	const int NUM_ITEMS = 8;
	int arr1[NUM_ITEMS] = { 1, 3, 5, 7, 9, 11, 13, 15 };

	// The numbers in the array are assumed to be sorted
	// search for the values 9, 1, 15, 0

	TestResult( BinarySearch(arr1, NUM_ITEMS, NUM_ITEMS -1, 9),  &arr1[4]   );
	TestResult( BinarySearch(arr1, NUM_ITEMS, NUM_ITEMS - 1, 1),  &arr1[0]   );
	TestResult( BinarySearch(arr1, NUM_ITEMS, NUM_ITEMS - 1, 15), &arr1[7]   );
	TestResult( BinarySearch(arr1, NUM_ITEMS, NUM_ITEMS - 1, 0),  nullptr    );
	TestResult( BinarySearch(arr1, NUM_ITEMS, NUM_ITEMS - 1, 16), nullptr    );


	return 0;
}

void TestResult(const int* result, int* const expected)
{
	if (result == expected)
	{
		std::cout << "PASS: result(" <<
			(result == nullptr ? "nullptr" : std::to_string(*result).c_str()) << ")" << std::endl;
		return;
	}

	std::cout << "FAIL: received(" <<
		(result == nullptr ? "nullptr" : std::to_string(*result).c_str()) << ") expected(" <<
		(expected == nullptr ? "nullptr" : std::to_string(*expected).c_str()) << ")" << std::endl;
}

const int* BinarySearch(int arr[], int l, int r, int x)
{
    if (r >= l) {
        int mid = l + (r - l) / 2;
 
        // If the element is present at the middle
        // itself
        if (arr[mid] == x)
            return &mid;
 
        // If element is smaller than mid, then
        // it can only be present in left subarray
        if (arr[mid] > x)
            BinarySearch(arr, l, mid - 1, x);
 
        // Else the element can only be present
        // in right subarray
        BinarySearch(arr, mid + 1, r, x);
    }
		return nullptr;
	

}
