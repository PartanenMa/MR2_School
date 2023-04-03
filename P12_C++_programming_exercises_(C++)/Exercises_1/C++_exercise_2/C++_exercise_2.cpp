#include <iostream>
#include <string>
using namespace std;

double sum(double array[], int size) {
    double total = 0;
    for (int i = 0; i < size; i++) {
        total += array[i];
    }
    return total;
}

int main() {
    double array[] = { 1.1, 2.2, 3.3, 4.4, 5.5 };
    int size = 5;
    cout << sum(array, size);
    return 0;
}