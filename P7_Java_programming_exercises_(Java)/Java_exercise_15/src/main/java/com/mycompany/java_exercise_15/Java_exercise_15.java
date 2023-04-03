/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Project/Maven2/JavaApp/src/main/java/${packagePath}/${mainClassName}.java to edit this template
 */

package com.mycompany.java_exercise_15;
import java.util.Scanner;

/**
 *
 * @author manu1
 */
public class Java_exercise_15 {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        numbers numbers = new numbers();
        while(true) {
            System.out.println("Commands: insert = i, delete = d, average = a, print all = p, stop = s");
            System.out.println("Enter a command: ");
            String command = scanner.nextLine();
            if(command.equals("s")) {
                break;
            }else if(command.equals("i")) {
                System.out.println("Enter a number to be inserted: ");
                int inserted = scanner.nextInt();
                numbers.insert(inserted);
            }else if(command.equals("d")) {
                System.out.println("Enter a number to be deleted: ");
                int deleted = scanner.nextInt();
                numbers.delete(deleted);
            }else if(command.equals("a")) {
                System.out.println("Average: " + numbers.getAverage());
            }else if(command.equals("p")) {
                numbers.print();
            }   
        }
    }
}
