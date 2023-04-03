/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Project/Maven2/JavaApp/src/main/java/${packagePath}/${mainClassName}.java to edit this template
 */

package com.mycompany.data_structures_exercise_4;

import java.util.Stack;

/**
 *
 * @author manu1
 */
public class Data_structures_exercise_4 {
    
    //Reverse-metodi kääntää stringin:
    public static String reverse(String string) {
        char[] reverseString = new char[string.length()];
        Stack<Character> stack = new Stack<>();
        for(int i = 0; i < string.length(); i++) {
            stack.push(string.charAt(i));
        }
        int i = 0;
        while(!stack.isEmpty()) {
            reverseString[i++] = stack.pop();
        }
        return new String(reverseString);
    }

    //Pääohjelma kutsuu reverse-metodia:
    public static void main(String[] args) {
        String string = "sika";
        System.out.println(string + " = " + reverse(string));     
    }
}
