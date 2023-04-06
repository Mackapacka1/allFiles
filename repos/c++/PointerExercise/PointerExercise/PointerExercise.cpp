// PointerExercise.cpp : This file contains the 'main' function. Program execution begins and ends there.
//
#include "Monster.h"
#include <iostream>
#include <conio.h>

void AttackMonster(Monster * defender, Monster attacker);
void DisplayMonsterHealth(Monster m);

int main()
{
    //Create monsters
    Monster dragon{ "Dragon", 200, 20 };
    Monster vampire{ "Vampire", 150, 10 };
    Monster zombie{ "Zombie", 50, 8 };
    Monster impossibleSlime{ "Impossible Slime", 5000, 500 };

    //create player
    Monster player{ "Player", 100, 20 };

    //pick a random enemy
    Monster * current;
    srand(time(0)); //this generate a random seed
    int r = rand() % 3; //this generates a random number between 0-3 exclusive
    switch (r)
    {
        case 0: current = &dragon; break;
        case 1: current = &vampire; break;
        case 2: current = &zombie; break;

            //without a default, C++ assumes the possibility that current is never assigned
            // and therefore returning an error later when we try to access it
        default: current = &impossibleSlime; break; 
    }

    //fight until someone is defeated
    while (current->health > 0 && player.health > 0)
    {
        //player attacks current monster
        AttackMonster(current, player);
        DisplayMonsterHealth(*current);

        //wait for input then clear screen
        system("pause");
        system("cls");

        //current monster attacks player
        AttackMonster(&player, *current);
        DisplayMonsterHealth(player);

        //wait for input then clear screen
        system("pause");
        system("cls");
    }
    
}

void AttackMonster(Monster * defender, Monster attacker)
{
    defender->health -= attacker.damage;

    std::cout << attacker.name << " attacks the " << defender->name << " for " 
        << attacker.damage << " damage!" << std::endl;
}

void DisplayMonsterHealth(Monster m)
{
    std::cout << "The " << m.name << " has " << m.health << " health remaining..." << std::endl;
    
    if (m.health < 0)
    {
        std::cout << "The " << m.name << " was defeated!\n";
    }
}
