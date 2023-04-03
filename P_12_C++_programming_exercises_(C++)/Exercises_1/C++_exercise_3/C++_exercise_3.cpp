#include <iostream>
#include <string>
using namespace std;

void strcpyC(char* dest, const char* src) {
    int i = 0;
    while (src[i] != '\0') {
        dest[i] = src[i];
        i++;
    }
    dest[i] = '\0';
}

void strcpy(string& dest, const string& src) {
    dest = src;
}

int main() {
    char src[] = "Hello, World!";
    char dest[20];
    strcpyC(dest, src);
    cout << dest << endl;
    string dest2;
    strcpy(dest2, src);
    cout << dest2 << endl;
    return 0;
}