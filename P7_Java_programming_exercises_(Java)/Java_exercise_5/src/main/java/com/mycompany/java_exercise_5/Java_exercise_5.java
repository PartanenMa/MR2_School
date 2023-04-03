/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Project/Maven2/JavaApp/src/main/java/${packagePath}/${mainClassName}.java to edit this template
 */

package com.mycompany.java_exercise_5;

/**
 *
 * @author manu1
 */
import java.util.Scanner;
public class Java_exercise_5 {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int number = 75;
        System.out.println("Try to guess the number (between 1 and 100):");
        int answer = scanner.nextInt();
        if(answer == number) {
            System.out.println("First try! Nice!");
        }else{
            while(true) {
                System.out.println("Oops! Wrong one! Try again:");
                int tryagain = scanner.nextInt();
                if(tryagain == number) {
                    System.out.println("Correct!");
                    break;
                }
            }
        }
    }
}
