#include <iostream>
#include <string>
using namespace std;

void joinArrays(int arr1[], int size1, int arr2[], int size2, int result[]) {
    int i = 0, j = 0, k = 0;

    while (i < size1 && j < size2) {
        if (arr1[i] < arr2[j]) {
            result[k++] = arr1[i++];
        }
        else {
            result[k++] = arr2[j++];
        }
    }
    while (i < size1) {
        result[k++] = arr1[i++];
    }
    while (j < size2) {
        result[k++] = arr2[j++];
    }
}

int main() {
    int array1[] = { 1, 2, 3 };
    int array2[] = { 4, 5, 6 };
    int result[6];

    joinArrays(array1, 3, array2, 3, result);

    for (int i = 0; i < 6; i++) {
        cout << result[i];
    }
    return 0;
}