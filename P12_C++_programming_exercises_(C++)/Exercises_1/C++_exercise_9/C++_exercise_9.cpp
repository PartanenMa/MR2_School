#include <iostream>
#include <string>
using namespace std;
#include "FootballResult.h"

int main() {
	FootballResult game1 = { "Team A", "Team B", 3, 2 };
	FootballResult game2 = { "Team C", "Team D", 1, 1 };
	FootballResult game3 = { "Team E", "Team F", 2, 0 };

	cout << game1.team1 << " " << game1.score1 << " - " << game1.score2 << " " << game1.team2 << std::endl;
	cout << game2.team1 << " " << game2.score1 << " - " << game2.score2 << " " << game2.team2 << std::endl;
	cout << game3.team1 << " " << game3.score1 << " - " << game3.score2 << " " << game3.team2 << std::endl;

	return 0;
}