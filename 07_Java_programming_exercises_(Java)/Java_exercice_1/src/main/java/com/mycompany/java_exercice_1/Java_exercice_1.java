/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Project/Maven2/JavaApp/src/main/java/${packagePath}/${mainClassName}.java to edit this template
 */

package com.mycompany.java_exercice_1;

/**
 *
 * @author manu1
 */
public class Java_exercice_1 {

    public static void main(String[] args) {
        int x1,x2,y1,y2;
	double distance;	   
        x1 = 1;    	   
        y1 = 8;	   
        x2 = 5;	   
        y2 = 3; 	    
        distance = Math.sqrt((x2-x1) * (x2-x1) + (y2-y1) * (y2-y1)); 	 	    	 	    
  	System.out.println("Distance between" + "(" + x1 + "," + y1 + ")," + "(" + x2 + "," + y2 + ") is: " + distance);
    }
}
