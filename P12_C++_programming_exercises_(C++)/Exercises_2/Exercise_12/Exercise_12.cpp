#include <iostream>
using namespace std;

template<typename T, typename IndexType>

IndexType searchArray(T arr[], IndexType size, T value) {
    for (IndexType i = 0; i < size; i++) {
        if (arr[i] == value) {
            return i;
        }
    }
    return -1;
}

int main() {
    int arr[] = { 1, 2, 3, 4, 5 };
    int size = sizeof(arr) / sizeof(arr[0]);
    int searchVal = 3;
    int index = searchArray<int, size_t>(arr, size, searchVal);
    if (index == -1) {
        cout << "Value " << searchVal << " not found in array." << endl;
    }
    else {
        cout << "Value " << searchVal << " found at index " << index << "." << endl;
    }
    return 0;
}
