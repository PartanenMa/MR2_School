/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Project/Maven2/JavaApp/src/main/java/${packagePath}/${mainClassName}.java to edit this template
 */

package com.mycompany.tehtava_7_14;

/**
 *
 * @author manu1
 */
public class Tehtava_7_14 {
    
    static void printPermutation(String sana, String vastaus) {
        if (sana.length() == 0) {
            System.out.println(vastaus + " ");
            return;
        }
        for (int i = 0; i < sana.length(); i++) {
            char ch = sana.charAt(i);
            String ros = sana.substring(0, i) + sana.substring(i + 1);
            printPermutation(ros, vastaus + ch);
        }
    }

    public static void main(String[] args) {
        String sana = "apina";
        printPermutation(sana, "");
    }
}
