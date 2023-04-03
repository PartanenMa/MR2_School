#ifndef STACK_H
#define STACK_H

#include <string>
using namespace std;

const int MAX_SIZE = 10;

class Stack {
public:
    Stack();
    bool empty() const;
    int size() const;
    void push(const string& str);
    void pop();
    string top() const;
private:
    string data[MAX_SIZE];
    int topIndex;
};

#endif