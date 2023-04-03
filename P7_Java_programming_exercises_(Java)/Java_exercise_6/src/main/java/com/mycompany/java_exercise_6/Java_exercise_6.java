/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Project/Maven2/JavaApp/src/main/java/${packagePath}/${mainClassName}.java to edit this template
 */

package com.mycompany.java_exercise_6;

/**
 *
 * @author manu1
 */
public class Java_exercise_6 {

    public static void main(String[] args) {
        int seconds;
        int minutes = 0;
        int hours = 0;
        int days = 0;
        int years = 0;
        seconds = 31556927;
        while(true) {
            if(seconds == 0) {
                break;
            }
            if(seconds >= 31556926) {               
                seconds = seconds - 31556926;
                years++;
            }else if(seconds >= 86400) {
                seconds = seconds - 86400;
                days++;
            }else if(seconds >= 3600) {
                seconds = seconds - 3600;
                hours++;
            }else if(seconds >= 60) {
                seconds = seconds - 60;
                minutes++;
            }else{
                break;
            }
        }
        System.out.println(years + " years, " + days + " days, " + hours + " hours, " + minutes + " minutes, " + seconds + " seconds.");
    }
}
