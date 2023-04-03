/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Project/Maven2/JavaApp/src/main/java/${packagePath}/${mainClassName}.java to edit this template
 */

package com.mycompany.java_exercise_8;

/**
 *
 * @author manu1
 */
public class Java_exercise_8 {

    public static void main(String[] args) {
        int height = 10;        
        for(int i1 = 1; i1 <= height; i1++) {
            for(int i2 = i1; i2 <= height - 1; i2++) {
                System.out.print(" ");
            }
            for(int i3 = 1; i3 <= 2 * i1 -1; i3++){
                System.out.print("*");
            }
            System.out.println("");
        }
    }
}
