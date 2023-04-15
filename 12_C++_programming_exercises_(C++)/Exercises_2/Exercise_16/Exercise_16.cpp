#include <iostream>
#include "stack.h"
using namespace std;

int main() {
    Stack s;
    cout << "Stack is empty: " << s.empty() << endl;
    cout << "Stack size is: " << s.size() << endl;
    s.push("hello");
    s.push("world");
    s.push("!");
    cout << "Stack is empty: " << s.empty() << endl;
    cout << "Stack size is: " << s.size() << endl;
    cout << "Top of stack is: " << s.top() << endl;
    s.pop();
    cout << "Stack size is: " << s.size() << endl;
    cout << "Top of stack is: " << s.top() << endl;
    return 0;
}