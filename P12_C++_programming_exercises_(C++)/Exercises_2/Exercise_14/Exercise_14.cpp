#include <iostream>
#include <list>
#include <algorithm>
using namespace std;

int main() {
    // Creating the first two lists:
    list<string> list1 = { "abc", "def", "ghi" };
    list<string> list2 = { "123", "def", "789" };

    // Creating a third list and merging the first two lists:
    list<string> list3;
    auto it1 = list1.begin();
    auto it2 = list2.begin();
    while (it1 != list1.end() && it2 != list2.end()) {
        list3.push_back(*it1);
        list3.push_back(*it2);
        ++it1;
        ++it2;
    }

    // Appending any remaining elements from the longer list:
    while (it1 != list1.end()) {
        list3.push_back(*it1);
        ++it1;
    }
    while (it2 != list2.end()) {
        list3.push_back(*it2);
        ++it2;
    }

    // Sorting and removing duplicates from list3:
    list3.sort();
    list3.unique();

    // Printing the final result:
    for (const auto& str : list3) {
        cout << str << " ";
    }
    cout << endl;
    return 0;
}
