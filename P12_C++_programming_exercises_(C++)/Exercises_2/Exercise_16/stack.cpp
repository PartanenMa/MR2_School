#include "stack.h"

Stack::Stack() : topIndex(-1) {}

bool Stack::empty() const {
    return topIndex == -1;
}

int Stack::size() const {
    return topIndex + 1;
}

void Stack::push(const std::string& str) {
    if (topIndex < MAX_SIZE - 1) {
        data[++topIndex] = str;
    }
}

void Stack::pop() {
    if (!empty()) {
        --topIndex;
    }
}

std::string Stack::top() const {
    if (!empty()) {
        return data[topIndex];
    }
    return "";
}