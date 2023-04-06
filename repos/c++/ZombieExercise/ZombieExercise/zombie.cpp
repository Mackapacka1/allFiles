#include "zombie.h"

std::string zombie::getOccupation() {
	return _occupation;
}

float zombie::getAttack() {
	return _attack;
}

float zombie::getHealth() {
	return _health;
}

void zombie::damage(float amount) {
	_health -= amount;
}

zombie::zombie(float attack, float health, std::string occupation) {
	_attack = attack;
	_health = health;
	_occupation = occupation;

}	

