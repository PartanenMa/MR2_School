/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Project/Maven2/JavaApp/src/main/java/${packagePath}/${mainClassName}.java to edit this template
 */

package com.mycompany.java_exercise_13;

/**
 *
 * @author manu1
 */
public class Java_exercise_13 {

    public static void main(String[] args) {
        String string = "Pig is an animal", reversed = ""; 
        char character; 
        System.out.print("Original string: "); 
        System.out.println(string); 
        for (int i = 0; i < string.length(); i++) {  
            character = string.charAt(i);
            reversed = character + reversed;
        } 
        System.out.println("Reversed string: "+ reversed); 
    }
}
