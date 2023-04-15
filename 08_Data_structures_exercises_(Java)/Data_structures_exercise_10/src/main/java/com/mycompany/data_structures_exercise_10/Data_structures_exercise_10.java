/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Project/Maven2/JavaApp/src/main/java/${packagePath}/${mainClassName}.java to edit this template
 */

package com.mycompany.data_structures_exercise_10;

import java.util.HashSet;
import java.util.Random;

/**
 *
 * @author manu1
 */
public class Data_structures_exercise_10 {

    public static void main(String[] args) {
        HashSet<Integer> randomNumbers = new HashSet<>();
        Random random = new Random();
        int count = 0;
        for(int i = 0; i < 100; i++) {
            int randomInt = random.nextInt(1, 101);
            randomNumbers.add(randomInt);
            count++;
        }
        System.out.println("The HashSet contains " + count + " numbers.");
    }
}
