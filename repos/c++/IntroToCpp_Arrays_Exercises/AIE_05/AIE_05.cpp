
#include <iostream>




int main(int argc, char** argv)
{
	const int ROWS = 3;
	const int COLS = 5;

	const char* grid2D[ROWS][COLS] =
	{
		{ "a0", "a1", "a2", "a3", "a4" },
		{ "b0", "b1", "b2", "b3", "b4" },
		{ "c0", "c1", "c2", "c3", "c4" },
	};


	// Task 1:
	// Print all values in the grid using nested loops to iterate over rows and columns.
	// Expected output:
	//		a0, a1, a2, a3, a4, 
	//		b0, b1, b2, b3, b4,
	//		c0, c1, c2, c3, c4,
	// ------------------------------------------------------------------------
	for (size_t i = 0; i < ROWS; i++)
	{
		for (size_t j = 0; j < COLS; j++)
		{
			std::cout << grid2D[i][j] << ", ";
		}
		std::cout << "\n";
	}

	std::cout << "\n";
	std::cout << "\n";

	// ------------------------------------------------------------------------






	// Task 2:
	// Print all values in the grid using a single loop
	// Expected output:
	//		a0, a1, a2, a3, a4, b0, b1, b2, b3, b4, c0, c1, c2, c3, c4,
	// ------------------------------------------------------------------------
	int rowIndex = 0;
	int colIndex = 0;

	for (size_t index = 0; index < 16; index++)
	{
		std::cout << grid2D[rowIndex][colIndex] << ", ";
		
		rowIndex = index / 5;
		colIndex = index % 5;
	}
	std::cout << "\n";
	std::cout << "\n";
	std::cout << "\n";


		// TODO: convert "index" to a "rowIndex" and "colIndex" value
		

		// use the resulting row and column index to print the value

		//std::cout << grid2D[rowIndex][colIndex] << ", ";
	

	// ------------------------------------------------------------------------


	const char* grid1D[ROWS*COLS] =
	{
		"a0", "a1", "a2", "a3", "a4",
		"b0", "b1", "b2", "b3", "b4",
		"c0", "c1", "c2", "c3", "c4"
	};

	// Task 3:
	// using a nested loop to iterate over rows/columns
	// convert the row and column index to a single index value to print the values
	// of grid1D
	// Expected output:
	//		a0, a1, a2, a3, a4, 
	//		b0, b1, b2, b3, b4,
	//		c0, c1, c2, c3, c4,
	// ------------------------------------------------------------------------
	int h = 0;
	for (size_t i = 0; i < ROWS; i++)
	{
		for (size_t j = 0; j < COLS; j++)
		{
			h = i * 3 + j;
			std::cout << grid1D[h] << ", ";
		}
		std::cout << "\n";
	}



	for (int rowIndex = 0; rowIndex < ROWS; rowIndex++)
	{
		for (int colIndex = 0; colIndex < COLS; colIndex++)
		{
			// TODO: calculate "index" based on rowIndex/colIndex value
			int index = 0; 

			// use the resulting index to print the value
			//std::cout << grid1D[index] << ", ";
		}
		std::cout << std::endl;
	}

	// ------------------------------------------------------------------------

}

