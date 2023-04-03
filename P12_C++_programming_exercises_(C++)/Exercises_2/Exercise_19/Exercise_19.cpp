#include <iostream>
using namespace std;

class PlayingCard {
public:
    enum Suit { Hearts, Diamonds, Clubs, Spades };
    enum Rank { Ace, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King };

    PlayingCard(Suit s, Rank r) : suit(s), rank(r) {}

    PlayingCard& operator++() {
        if (rank == King) {
            rank = Ace;
        }
        else {
            rank = static_cast<Rank>(rank + 1);
        }
        return *this;
    }

    PlayingCard operator++(int) {
        PlayingCard temp = *this;
        if (suit == Spades) {
            suit = Hearts;
        }
        else {
            suit = static_cast<Suit>(suit + 1);
        }
        return temp;
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
    card1.display();
    ++card1;
    card1.display();
    card1++;
    card1.display();
    return 0;
}