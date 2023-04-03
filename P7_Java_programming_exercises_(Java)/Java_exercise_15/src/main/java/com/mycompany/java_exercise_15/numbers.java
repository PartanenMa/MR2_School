/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.java_exercise_15;

import java.util.ArrayList;

/**
 *
 * @author manu1
 */
public class numbers {
    private ArrayList numbers;
    public int number;
    public double average;
    
    public numbers() {
        this.numbers = new ArrayList<Integer>();
        this.number = 0;
        this.average = 0.0;
    }
    public void insert(int number) {
        numbers.add(number);
        average();
    }
    
    public void delete(int number) {
        if(numbers.isEmpty()) {
            System.out.println("Nothing to delete!");
        }else{
            ArrayList<Integer> temp = numbers;
            int deleted = 0;
            for(int num: temp) {
                if(num == number) {
                    deleted = num;
                }
            }
            if(numbers.contains(deleted)) {
                numbers.remove(Integer.valueOf(deleted));
                average();
            }
        }        
    }
    
    public void average() {
        ArrayList<Integer> temp = numbers;
        int nums = 0;
        int total = 0;
        for(int num: temp) {
            total = total + num;
            nums++;
        }
        this.average = Double.valueOf(total) / Double.valueOf(nums);
    }
    
    public double getAverage() {
        return this.average;
    }
    
    public void print() {
        if(numbers.isEmpty()) {
            System.out.println("Nothing to print!");
        }else{
            ArrayList<Integer> temp = numbers;
            int count = 1;
            for(int num: temp) {
                System.out.println("Number " + count + ": " + num);
                count++;
            }
        }
    }   
}
