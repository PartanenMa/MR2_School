/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Project/Maven2/JavaApp/src/main/java/${packagePath}/${mainClassName}.java to edit this template
 */

package com.mycompany.java_exercise_2;

/**
 *
 * @author manu1
 */
public class Java_exercise_2 {
    static boolean is_divisible_by7(int number) {
        if( number < 0 ) {
            number = Math.abs(number);
        }
        if(number % 7 == 0) {
            return true;
        }else{
            return false;
        }        
    }
    
    static boolean is_divisible_by17(int number) {
        if( number < 0 ) {
            number = Math.abs(number);
        }
        if(number % 17 == 0) {
            return true;
        }else{
            return false;
        }        
    }

    public static void main(String[] args) {
        int number1 = 1;
        int number2 = 100;
        for(int i = number1 + 1; i < number2; i++) {
            if(i % 7 != 0 && i % 17 != 0) {
                System.out.println(i + " is not divisable by 7 and 17");
            }
        }
    }
}
