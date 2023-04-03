#include "FixedSizeDeque.h"

FixedSizeDeque::FixedSizeDeque(size_t capacity) : capacity_(capacity) {}

bool FixedSizeDeque::push_front(char c) {
    if (full()) {
        return false;
    }
    deque_.push_front(c);
    return true;
}

bool FixedSizeDeque::push_back(char c) {
    if (full()) {
        return false;
    }
    deque_.push_back(c);
    return true;
}

bool FixedSizeDeque::pop_front() {
    if (empty()) {
        return false;
    }
    deque_.pop_front();
    return true;
}

bool FixedSizeDeque::pop_back() {
    if (empty()) {
        return false;
    }
    deque_.pop_back();
    return true;
}

size_t FixedSizeDeque::size() const {
    return deque_.size();
}

bool FixedSizeDeque::empty() const {
    return deque_.empty();
}

bool FixedSizeDeque::full() const {
    return deque_.size() == capacity_;
}

char& FixedSizeDeque::front() {
    return deque_.front();
}

char& FixedSizeDeque::back() {
    return deque_.back();
}