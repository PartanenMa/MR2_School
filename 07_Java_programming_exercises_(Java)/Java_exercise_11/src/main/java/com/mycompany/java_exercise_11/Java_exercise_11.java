/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Project/Maven2/JavaApp/src/main/java/${packagePath}/${mainClassName}.java to edit this template
 */

package com.mycompany.java_exercise_11;

/**
 *
 * @author manu1
 */
import java.util.Random;
public class Java_exercise_11 {

    public static void main(String[] args) {
        Random random = new Random();
        int[] numbers = new int[100];
        for(int i = 0; i < 100; i++) {
            int random_number = random.nextInt(1, 100);
            numbers[i] = random_number;
        }
        int index = 0;
        int total = 0;
        for(int number: numbers) {
            if(number <= 5) {
                System.out.println("At index: " + index + " the number is 5, or under.");
                System.out.println("The number is: " + number);
                System.out.println();
                total++;
            }
            index++;
        }
        System.out.println("Total numbers that are 5 or under: " + total);
    }
}
