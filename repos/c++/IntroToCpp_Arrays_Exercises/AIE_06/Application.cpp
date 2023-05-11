#include "Application.h"
#include "raylib.h"
#include <stdlib.h>
#include <iostream>
using namespace std;


Application::Application()
{

}

Application::~Application()
{

}

void Application::Run()
{
	InitWindow(m_windowWidth, m_windowHeight, "Simple Tilemap");
	SetTargetFPS(60);

	Load();

	while (!WindowShouldClose())
	{
		Update(GetFrameTime());
		Draw();
	}

	Unload();
}

void Application::Load()
{

	// Task1:
	// Initialise all values in m_tiles array to a random
	// value between 0 and 5 exclusive;
	// -----------------------------------------------------
	
	int length = ROWS * COLS;
	for (size_t i = 0; i < length; i++)
	{
		
		int random = rand() % 5;
		
		m_tiles[i] = random;


	}

	// -----------------------------------------------------
}

void Application::Unload()
{

}

void Application::Update(float deltaTime)
{
	if (IsMouseButtonPressed(MOUSE_LEFT_BUTTON))
	{
		Vector2 mousePos = GetMousePosition();
		int whereMouseX = 0;
		int whereMouseY = 0;
		system("cls");
		

		whereMouseX = round(mousePos.x / m_tileWidth);
		whereMouseY = round(mousePos.y / m_tileHeight);
		
		//whereMouseY *= 40;
		cout << whereMouseX;
		cout << "\n";
		cout << whereMouseY;
		cout << "\n";
		cout << "\n";


		// Task 3:
		// TODO: Calculate row and col index based on the mouse positon
		int rowIndex = 0; 
		int colIndex = 0;

		// TODO: calculate the index of the tile clicked on based on the row/col index
		int tileIndex = 0;
		tileIndex = whereMouseX + whereMouseY;
		/*if (tileIndex == 1600){
			tileIndex = 1599;
		}*/
		cout <<"tileIndex"<< tileIndex << "\n";

		//m_tiles[tileIndex] = 6;//testing what block changes colour.
		m_tiles[tileIndex] += 1;
		if (m_tiles[tileIndex] >= 5) {
			m_tiles[tileIndex] = 0;
		}
	}

}

void Application::Draw()
{
	BeginDrawing();
	ClearBackground(RAYWHITE);

	// Task2:
	// use a nested loop to iterate over rows and columns
	// Use raylib's DrawRect method to draw each tile in the array.
	// 	   use the row and col index multipled by m_tileHeight/m_tileWidth
	// 	   to calculate the x and y position for each rectangle.
	// 
	// change the color of the rect drawn based on the value of the tile.
	// 	   We have created a helper function you can use "GetTileColor"
	// --------------------------------------------------------------------
	// write your code here
	float xPos = 0;
	float yPos = -20;
	int j = 0;
	for (size_t k = 0; k < 40; k++)
	{
		yPos = yPos + 20;
		xPos = 0;
		for (size_t i = 0; i < 40; i++)
		{

			//cout << m_tiles[i];

			Color color = GetTileColor(m_tiles[j]); // pass in the tilevalue
			DrawRectangle(xPos, yPos, m_tileWidth, m_tileHeight, color);
			j++;
			xPos = xPos + 20;


		}
		

	}

	
	// --------------------------------------------------------------------

	EndDrawing();
}

Color Application::GetTileColor(int tileValue)
{
	switch (tileValue)
	{
	case 0: return WHITE;
	case 1: return RED;
	case 2: return GREEN;
	case 3: return BLUE;
	case 4: return YELLOW;
	}
	
	return BLACK;
}