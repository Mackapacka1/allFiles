#include "Application.h"
#include "raylib.h"

#define RAYGUI_IMPLEMENTATION
#define RAYGUI_SUPPORT_ICONS
#include <stdlib.h>
#include "raygui.h"
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
	InitWindow(m_windowWidth, m_windowHeight, "Game Of Life");

	SetTargetFPS(60);
	Load();

	while (!WindowShouldClose())    // Detect window close button or ESC key
	{
		float dt = GetFrameTime();
		Update(dt);
		Draw();
	}

	Unload();
	CloseWindow();
}

void Application::Load()
{
	// allocate memory for the grid
	m_grid = new int[m_rows * m_cols];
	m_gridBuffer = new int[m_rows * m_cols];

	// initialise cells to a random value (0 or 1)
	for (int i = 0; i < m_rows * m_cols; i++)
	{
		m_grid[i] = rand() % 100 < 10;
		m_gridBuffer[i] = m_grid[i];
	}
}

void Application::Unload()
{
	delete[] m_grid;
	m_grid = nullptr;

	delete[] m_gridBuffer;
	m_gridBuffer = nullptr;
}

void Application::Update(float dt)
{
	// copy "grid" to "gridBuffer"
	memcpy(m_gridBuffer, m_grid, sizeof(int) * m_rows * m_cols);

	// update the grid state for this frame
	for (int i = 0; i < m_rows * m_cols; i++) {
		m_grid[i] = CalculateTileState(i, m_gridBuffer);
	
	}

}

void Application::Draw()
{
	BeginDrawing();
	ClearBackground(RAYWHITE);

	int tileWidth = m_windowWidth / m_cols;
	int tileHeight = m_windowHeight / m_rows;

	// draw horizontal gridlines
	for (int y = 1; y < m_rows; y++)
	{
		DrawLine(0, y * tileHeight, m_windowWidth, y * tileHeight, LIGHTGRAY);
	}

	// draw vertical gridlines
	for (int x = 1; x < m_cols; x++)
	{
		DrawLine(x*tileWidth, 0, x * tileWidth, m_windowHeight, LIGHTGRAY);
	}

	// Draw the "Alive" Tiles
	for (int i = 0; i < m_rows * m_cols; i++)
	{
		if (m_grid[i] == 0)
			continue;

		int x = i % m_cols;
		int y = i / m_cols;

		DrawRectangle(x * tileWidth, y * tileHeight, tileWidth, tileHeight, DARKGRAY);
	}


	EndDrawing();
}

int Application::CalculateTileState(int index, int* grid)
{
	// Calculate the row/col index
	int col = index % m_cols;
	int row = index / m_cols;
	int aliveNeighbours = 0;

	

	bool isAlive = grid[index] != 0;

	if (grid[col - 1] == 1) {
		aliveNeighbours++;
	}
	if (grid[col + 1] == 1) {
		aliveNeighbours++;
	}
	if (grid[row - 1] == 1) {
		aliveNeighbours++;
	}
	if (grid[row + 1] == 1) {
		aliveNeighbours++;
	}
	cout << aliveNeighbours << "\n";


	// Task:
	// implement the rules for Conway’s game of life, the method should
	// update the isAlive value based on the rules defined here:
	// https://en.wikipedia.org/wiki/Conway%27s_Game_of_Life 

	/*
	Any live cell with fewer than 
	two live neighbours dies, 
	as if by underpopulation*/
	if (isAlive == true && aliveNeighbours > 2) {
		return isAlive = false;
		cout << "rule 1\n";
	}
	
	/*Any live cell with two
	or three live neighbours
	lives on to the next generation.*/
	else if (isAlive == true && (aliveNeighbours == 2 || aliveNeighbours == 3)) {
		
			return isAlive = true;
			cout << "rule 2\n";
	}

	
	/*Any live cell with more
	than three live neighbours dies,
	as if by overpopulation*/
	else if (isAlive == true && aliveNeighbours > 3) {
		return isAlive = true;
		cout << "rule 3\n";
	}


	/*Any dead cell with exactly
	three live neighbours becomes
	a live cell, as if by reproduction.*/
	else if (isAlive==false && aliveNeighbours == 3) {
		return isAlive = true;
		cout << "rule 4\n";
	}







}
