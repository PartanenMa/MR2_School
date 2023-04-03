#include <iostream>
using namespace std;

class PlayingCard {
public:
    enum Suit { Hearts, Diamonds, Clubs, Spades };
    enum Rank { Ace, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King };

    PlayingCard(Suit s, Rank r) : suit(s), rank(r) {}

    void display() {
        string rankStrings[] = { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
        string suitStrings[] = { "Hearts", "Diamonds", "Clubs", "Spades" };
        cout << rankStrings[rank] << " of " << suitStrings[suit] << endl;
    }

private:
    Suit suit;
    Rank rank;
};

int main() {
    PlayingCard card1(PlayingCard::Hearts, PlayingCard::Ace);
    card1.display();
    return 0;
}