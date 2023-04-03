/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Project/Maven2/JavaApp/src/main/java/${packagePath}/${mainClassName}.java to edit this template
 */

package com.mycompany.java_exercise_3;

/**
 *
 * @author manu1
 */
public class Java_exercise_3 {

    public static void main(String[] args) {
        int number = 150;
        int divisor_count = 1;
        for(int i = 1; i < number; i++) {
            if(number % i == 0) {
                System.out.println("Divisor no. " + divisor_count + " for number " + number + " is: " +i);
                divisor_count++;
            }
        }
        System.out.println("Total divisors for number " + number + ": " + (divisor_count - 1));
    }
}
