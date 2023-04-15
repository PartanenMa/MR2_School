/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Project/Maven2/JavaApp/src/main/java/${packagePath}/${mainClassName}.java to edit this template
 */

package com.mycompany.java_exercise_4;

/**
 *
 * @author manu1
 */
public class Java_exercise_4 {    

    public static void main(String[] args) {
        int other;
        int hundred = 0;
        int fifty = 0;
        int twenty = 0;
        int ten = 0;
        int five = 0;
        int money = 1288;
        other = money % 5;
        while(true) {
            if(money == 0) {
                break;
            }
            if(money >= 100) {               
                money = money - 100;
                hundred++;
            }else if(money >= 50) {
                money = money - 50;
                fifty++;
            }else if(money >= 20) {
                money = money - 20;
                twenty++;
            }else if(money >= 10) {
                money = money - 10;
                ten++;
            }else if(money >= 5) {
                money = money - 5;
                five++;
            }else{
                break;
            }
        }
        int total_notes = (hundred + fifty + twenty + ten + five);
        System.out.println("Total notes: " + total_notes);
        System.out.println("100 notes: " + hundred);
        System.out.println("50 notes: " + fifty);
        System.out.println("20 notes: " + twenty);
        System.out.println("10 notes: " + ten);
        System.out.println("5 notes: " + five);
        System.out.println("+ some small change: " + other + " coins");
    }
}
