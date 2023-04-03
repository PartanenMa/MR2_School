#include <iostream>
#include <string>
using namespace std;
#include "FootballResults.h"

void countGoals(const FootballResults& results, int& homeGoals, int& awayGoals) {
    homeGoals = 0;
    awayGoals = 0;
    for (int i = 0; i < results.numGames; i++) {
        homeGoals += results.games[i].score1;
        awayGoals += results.games[i].score2;
    }
}

int main() {
    FootballResults results = { 3, {{"Team A", "Team B", 3, 2}, {"Team C", "Team D", 1, 1}, {"Team E", "Team F", 2, 0}} };

    int homeGoals, awayGoals;
    countGoals(results, homeGoals, awayGoals);

    cout << "Home goals: " << homeGoals << endl;
    cout << "Away goals: " << awayGoals << endl;

    return 0;
}