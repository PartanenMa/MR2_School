/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Project/Maven2/JavaApp/src/main/java/${packagePath}/${mainClassName}.java to edit this template
 */

package com.mycompany.data_structures_exercise_5;

import java.util.ArrayList;
import java.util.Date;
import java.util.LinkedList;
import java.util.Random;

/**
 *
 * @author manu1
 */
public class Data_structures_exercise_5 {

    public static void main(String[] args) {
        ArrayList<Integer> nums1 = new ArrayList<>();
        LinkedList<Integer> nums2 = new LinkedList<>();
        Random rand = new Random();
        
        //ArrayList:
        for(int i = 0; i < 1000000; i++) {
            int int1 = rand.nextInt(1000);
            nums1.add(int1);
        }
        Date startDate1 = new Date();
        for(int num1: nums1) {
            System.out.println(num1);
        }
        Date endDate1 = new Date();
        int seconds1 = (int)((endDate1.getTime() - startDate1.getTime()) / 1000);
        
        //LinkedList:
        for(int i = 0; i < 1000000; i++) {
            int int2 = rand.nextInt(1000);
            nums2.add(int2);
        }
        Date startDate2 = new Date();
        for(int num2: nums2) {
            System.out.println(num2);
        }
        Date endDate2 = new Date();
        int seconds2 = (int)((endDate2.getTime() - startDate2.getTime()) / 1000);
        System.out.println("ArrayList time: " + seconds1 + " seconds.");
        System.out.println("LinkedList time: " + seconds2 + " seconds.");
        //Lopputulos: ArrayList on hitaampi kuin LinkedList.
    }
}
