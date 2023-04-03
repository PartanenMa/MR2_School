/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Project/Maven2/JavaApp/src/main/java/${packagePath}/${mainClassName}.java to edit this template
 */

package com.mycompany.java_exercise_10;

/**
 *
 * @author manu1
 */
public class Java_exercise_10 {

    public static void main(String[] args) {
        String[][] numbers = new String[10][10];
        for(int row = 0; row < numbers.length; row++) {
            for(int column = 0; column < numbers[row].length; column++) {
                String number = String.valueOf(row) + String.valueOf(column);
                numbers[row][column] = number;
                System.out.println("Row: " + row + ", column: " + column + ", Number: " + number);
            }
        }
    }
}
