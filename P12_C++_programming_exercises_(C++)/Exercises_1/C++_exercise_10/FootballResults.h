#ifndef FOOTBALL_RESULTS_H
#define FOOTBALL_RESULTS_H

#include "FootballResult.h"

const int MAX_GAMES = 10;

struct FootballResults {
	int numGames;
	FootballResult games[MAX_GAMES];
};

void countGoals(const FootballResults& results, int& homeGoals, int& awayGoals);

#endif // FOOTBALL_RESULTS_H