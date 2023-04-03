#include <iostream>
#include <string>
using namespace std;

int* join_arrays(int* arr1, int size1, int* arr2, int size2) {
    int total_size = size1 + size2;
    int* result = new int[total_size];

    for (int i = 0; i < size1; i++) {
        result[i] = arr1[i];
    }

    for (int i = 0; i < size2; i++) {
        result[size1 + i] = arr2[i];
    }

    return result;
}

int main() {
    int arr1[] = { 1, 2, 3 };
    int size1 = sizeof(arr1) / sizeof(arr1[0]);
    int arr2[] = { 4, 5, 6 };
    int size2 = sizeof(arr2) / sizeof(arr2[0]);

    int* result = join_arrays(arr1, size1, arr2, size2);
    int result_size = size1 + size2;

    for (int i = 0; i < result_size; i++) {
        cout << result[i] << " ";
    }

    delete[] result;

    return 0;
}