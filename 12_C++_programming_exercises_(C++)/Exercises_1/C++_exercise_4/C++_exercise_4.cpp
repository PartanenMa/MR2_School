#include <iostream>
#include <string>
using namespace std;

/*T‰ss‰ funktio, joka k‰‰nt‰‰ char-arrayn:*/
void reverseArray(char arr[], int length) {
    for (int i = 0; i < length / 2; i++) {
        char temp = arr[i];
        arr[i] = arr[length - i - 1];
        arr[length - i - 1] = temp;
    }
}

/*T‰ss‰ funktio, joka k‰‰nt‰‰ stringin:*/
void reverseString(std::string& str) {
    int length = str.length();
    for (int i = 0; i < length / 2; i++) {
        char temp = str[i];
        str[i] = str[length - i - 1];
        str[length - i - 1] = temp;
    }
}

/*Molemmat funktiot toimivat vaihtamalla merkkijonon
vastakkaisissa p‰iss‰ olevat merkit ja liikkumalla
sis‰‰np‰in, kunnes merkkijonon keskikohta saavutetaan.
T‰m‰ johtaa siihen, ett‰ merkit k‰‰nnet‰‰n.*/

/*P‰‰ohjelma:*/
int main() {
    char array[] = { 'a', 'b', 'c', 'd' };
    string str = "Hello world!";
    reverseArray(array, 4);
    cout << array;
    reverseString(str);
    cout << str;
    return 0;
}