#include <iostream>
#include "FixedSizeDeque.h"
using namespace std;

int main() {
    const size_t capacity = 5;
    FixedSizeDeque deque(capacity);

    // Testing everything:
    deque.push_front('a');
    deque.push_back('b');
    deque.push_front('c');
    deque.push_back('d');
    deque.push_front('e');
    if (!deque.push_back('f')) {
        cout << "deque full" << endl;
    }
    deque.pop_front();
    deque.pop_back();
    deque.pop_front();
    cout << "front: " << deque.front() << endl;
    cout << "back: " << deque.back() << endl;
    cout << "size: " << deque.size() << endl;
    cout << "empty: " << deque.empty() << endl;
    return 0;
}
