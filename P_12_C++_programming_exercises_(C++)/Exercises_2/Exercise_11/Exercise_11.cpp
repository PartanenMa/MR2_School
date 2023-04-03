#include <iostream>
using namespace std;

template<typename T>

bool searchArray(T arr[], int size, T value) {
    for (int i = 0; i < size; i++) {
        if (arr[i] == value) {
            return true;
        }
    }
    return false;
}

int main() {
    int arr[] = { 1, 2, 3, 4, 5 };
    int size = sizeof(arr) / sizeof(arr[0]);
    int searchVal = 3;

    if (searchArray(arr, size, searchVal)) {
        cout << "Value " << searchVal << " found in array." << endl;
    }
    else {
        cout << "Value " << searchVal << " not found in array." << endl;
    }
    return 0;
}