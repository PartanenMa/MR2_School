#ifndef FIXED_SIZE_DEQUE_H
#define FIXED_SIZE_DEQUE_H

#include <deque>

class FixedSizeDeque {
public:
    explicit FixedSizeDeque(size_t capacity);
    bool push_front(char c);
    bool push_back(char c);
    bool pop_front();
    bool pop_back();
    size_t size() const;
    bool empty() const;
    bool full() const;
    char& front();
    char& back();

private:
    std::deque<char> deque_;
    size_t capacity_;
};

#endif  // FIXED_SIZE_DEQUE_H