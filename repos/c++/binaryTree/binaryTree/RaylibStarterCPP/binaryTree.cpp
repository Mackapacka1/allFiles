#include <iostream>
#include "Tree.h"
#include "raylib.h"
#include "raygui.h"
#define RAYGUI_IMPLEMENTATION
#define RAYGUI_SUPPORT_ICONS
int main(int argc, char* argv[])
{

	InitWindow(400, 400, "Tree");
	SetTargetFPS(60);
	Tree branch{};
	while (!WindowShouldClose()) {
		float deltatime = GetFrameTime();

		int a;
		std::cin >> a;
		switch (a)
		{
		case 1:
			branch.Insert();
			break;
		case 2:
			branch.Erase();
			break;
		case 3:
			CloseWindow();
			break;
		}
		branch.Draw(branch.branch_node, 10);
	}
}