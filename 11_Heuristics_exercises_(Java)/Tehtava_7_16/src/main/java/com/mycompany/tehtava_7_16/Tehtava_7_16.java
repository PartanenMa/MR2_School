/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Project/Maven2/JavaApp/src/main/java/${packagePath}/${mainClassName}.java to edit this template
 */

package com.mycompany.tehtava_7_16;

import java.util.Arrays;

/**
 *
 * @author manu1
 */
public class Tehtava_7_16 {
    
    static boolean areAnagrams(char[] str1, char[] str2) {
        int n1 = str1.length;
        int n2 = str2.length;
        if (n1 != n2) {
            return false;
        }
        Arrays.sort(str1);
        Arrays.sort(str2);
        for (int i = 0; i < n1; i++) {
            if (str1[i] != str2[i]) {
                return false;
            }
        }
        return true;
    }

    public static void main(String[] args) {
        char str1[] = { 'g', 'r', 'a', 'm' };
        char str2[] = { 'a', 'r', 'm' };
        if (areAnagrams(str1, str2)) {
            System.out.println("Merkkijonot ovat toistensa anagrammeja!");
        }else{
            System.out.println("Merkkijonot eivät ole toistensa anagrammeja!");
        }
    }
}
