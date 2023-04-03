#include <iostream>
#include <string>
using namespace std;

int search(int array[], int value) {
    for (int i = 0; i < 10; i++) {
        if (array[i] == value) {
            return value;
        }
    }
    return -1;
}

int main() {
    int array[] = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    int value = 7;
    cout << "Searched value: " << search(array, value);
    return 0;
}