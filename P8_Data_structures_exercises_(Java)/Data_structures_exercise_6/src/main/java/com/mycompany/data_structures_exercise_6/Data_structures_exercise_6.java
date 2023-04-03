/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Project/Maven2/JavaApp/src/main/java/${packagePath}/${mainClassName}.java to edit this template
 */

package com.mycompany.data_structures_exercise_6;

/**
 *
 * @author manu1
 */
public class Data_structures_exercise_6 {

    public static void main(String[] args) {
        Employee tyontekija = new Employee(123, "Matti", "insinööri");
        System.out.println("hashCode: " + tyontekija.hashCode());
        System.out.println("equals: " + tyontekija.equals(tyontekija));
    }
}
