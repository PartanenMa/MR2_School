#include <iostream>
#include <vector>
#include <random>
using namespace std;

int main() {
    // Random number generator:
    random_device rd;
    mt19937 gen(rd());
    uniform_int_distribution<> dist(0, 99);

    //Vectors:
    std::vector<int> oddNumbers;
    std::vector<int> evenNumbers;

    //Add numbers to vectors:
    for (int i = 0; i < 10; i++) {
        int num = dist(gen);
        if (num % 2 == 0) {
            evenNumbers.push_back(num);
        }
        else {
            oddNumbers.push_back(num);
        }
    }

    //Print the contents:
    cout << "Even numbers: ";
    for (int num : evenNumbers) {
        cout << num << " ";
    }
    cout << endl;
    cout << "Odd numbers: ";
    for (int num : oddNumbers) {
        cout << num << " ";
    }
    cout << endl;
    return 0;
}