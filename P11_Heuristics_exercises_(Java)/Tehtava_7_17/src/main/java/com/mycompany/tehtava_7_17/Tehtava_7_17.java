/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Project/Maven2/JavaApp/src/main/java/${packagePath}/${mainClassName}.java to edit this template
 */

package com.mycompany.tehtava_7_17;

import java.util.ArrayList;
import java.util.Collections;
import java.util.List;

/**
 *
 * @author manu1
 */
public class Tehtava_7_17 {
    
    static Character[][] numberToCharMap;
    
    private static List<String> printWords(int[] numerot, int len, int numIndex, String s) {
        if (len == numIndex) {
            return new ArrayList<>(
                Collections.singleton(s));
        }
        List<String> stringList = new ArrayList<>();
        for (int i = 0;
             i < numberToCharMap[numerot[numIndex]].length;
             i++) {
            String sCopy
                = String.copyValueOf(s.toCharArray());
            sCopy = sCopy.concat(
                numberToCharMap[numerot[numIndex]][i]
                    .toString());
            stringList.addAll(printWords(
                numerot, len, numIndex + 1, sCopy));
        }
        return stringList;
    }
 
    private static void printWords(int[] numerot) {
        generateNumberToCharMap();
        List<String> stringList = printWords(numerot, numerot.length, 0, "");
        stringList.stream().forEach(System.out::println);
    }
 
    private static void generateNumberToCharMap() {
        numberToCharMap = new Character[10][5];
        numberToCharMap[0] = new Character[] { '\0' };
        numberToCharMap[1] = new Character[] { '\0' };
        numberToCharMap[2] = new Character[] { 'a', 'b', 'c' };
        numberToCharMap[3] = new Character[] { 'd', 'e', 'f' };
        numberToCharMap[4] = new Character[] { 'g', 'h', 'i' };
        numberToCharMap[5] = new Character[] { 'j', 'k', 'l' };
        numberToCharMap[6] = new Character[] { 'm', 'n', 'o' };
        numberToCharMap[7] = new Character[] { 'p', 'q', 'r', 's' };
        numberToCharMap[8] = new Character[] { 't', 'u', 'v' };
        numberToCharMap[9] = new Character[] { 'w', 'x', 'y', 'z' };
    }

    public static void main(String[] args) {
        int number[] = { 1, 4, 5, 3, 4, 5 };
        printWords(number);
    }
}
