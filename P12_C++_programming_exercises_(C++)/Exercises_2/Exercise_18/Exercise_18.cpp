#include <iostream>
using namespace std;

class PlayingCard {
public:
    enum Suit { Hearts, Diamonds, Clubs, Spades };
    enum Rank { Ace, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King };

    PlayingCard(Suit s, Rank r) : suit(s), rank(r) {}

    bool operator==(const PlayingCard& other) const {
        return suit == other.suit && rank == other.rank;
    }

    bool operator>(const PlayingCard& other) const {
        if (rank == other.rank) {
            return suit > other.suit;
        }
        return rank > other.rank;
    }

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
    PlayingCard card2(PlayingCard::Diamonds, PlayingCard::King);
    PlayingCard card3(PlayingCard::Hearts, PlayingCard::King);
    if (card1 == card2) {
        cout << "The two cards are equal" << endl;
    }
    else {
        cout << "The two cards are not equal" << endl;
    }
    if (card2 > card1) {
        cout << "Card 2 is greater than card 1" << endl;
    }
    else {
        cout << "Card 2 is not greater than card 1" << endl;
    }
    if (card3 > card2) {
        cout << "Card 3 is greater than card 2" << endl;
    }
    else {
        cout << "Card 3 is not greater than card 2" << endl;
    }
    return 0;
}