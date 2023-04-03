/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Project/Maven2/JavaApp/src/main/java/${packagePath}/${mainClassName}.java to edit this template
 */

package com.mycompany.java_exercise_7;

/**
 *
 * @author manu1
 */
public class Java_exercise_7 {

    public static void main(String[] args) {
	int size = 10;		
	for(int i1 = 1; i1 <= size; i1++) {
            for(int i2 = 1; i2 <= size; i2++) {
		if(i1 == 1 || i1 == size || i2 == 1 || i2 == size) {
                    System.out.print("*  ");
		}else{
                    System.out.print("   ");
		}
            }			
            System.out.println();
	}
    }
}
