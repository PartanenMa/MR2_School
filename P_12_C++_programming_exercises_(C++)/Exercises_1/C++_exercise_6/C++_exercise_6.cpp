#include <iostream>
#include <string>
using namespace std;

void set_nil(int arr[], int size, int wanted_value) {
    for (int i = 0; i < size; i++) {
        if (arr[i] == wanted_value) {
            arr[i] = 0;
        }
    }
}

int main() {
    int arr[] = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    int size = sizeof(arr) / sizeof(arr[0]);
    int wanted_value = 5;

    set_nil(arr, size, wanted_value);

    for (int i = 0; i < size; i++) {
        cout << arr[i] << " ";
    }

    return 0;
}