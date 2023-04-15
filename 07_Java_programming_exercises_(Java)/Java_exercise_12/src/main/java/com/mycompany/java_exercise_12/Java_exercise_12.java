/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Project/Maven2/JavaApp/src/main/java/${packagePath}/${mainClassName}.java to edit this template
 */

package com.mycompany.java_exercise_12;

import java.util.Random;

/**
 *
 * @author manu1
 */
public class Java_exercise_12 {

    public static void main(String[] args) {
        Random random = new Random();
        int[] positive_numbers = new int[100];
        int[] negative_numbers = new int[100];
        for(int i = 0; i < 100; i++) {
            int random_number = random.nextInt(-50, 50);
            if(random_number < 0) {
                negative_numbers[i] = random_number;
            }else{
                positive_numbers[i] = random_number;
            }
        }
        int index_P = 0;
        int length_P = 0;
        for(int number: positive_numbers) {
            if(number != 0) {
                length_P++;
            }
            index_P++;
        }
        int index_N = 0;
        int length_N = 0;
        for(int number: negative_numbers) {
            if(number != 0) {
                length_N++;
            }
            index_N++;
        }
        System.out.println("Positive array length should be: " + length_P);
        System.out.println("Negative array length should be: " + length_N);
    }
}
