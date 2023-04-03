/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Project/Maven2/JavaApp/src/main/java/${packagePath}/${mainClassName}.java to edit this template
 */

package com.mycompany.java_exercise_14;

/**
 *
 * @author manu1
 */
public class Java_exercise_14 {
    public static void main(String[] args) {
        String string = "This is a string!";  
        char character = 'i';
        int count = 0;    
        for(int i = 0; i < string.length(); i++) {    
            if(string.charAt(i) != ' ' && string.charAt(i) == character) {    
                count++;  
            }
        }       
        System.out.println("Total number of character " + character + " in a string: " + count);  
    }
}
