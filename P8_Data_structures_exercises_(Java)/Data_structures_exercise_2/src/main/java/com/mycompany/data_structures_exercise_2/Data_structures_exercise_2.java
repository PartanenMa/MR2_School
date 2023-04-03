/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Project/Maven2/JavaApp/src/main/java/${packagePath}/${mainClassName}.java to edit this template
 */

package com.mycompany.data_structures_exercise_2;

/**
 *
 * @author manu1
 */
public class Data_structures_exercise_2 {

    public static void main(String[] args) {
        Stack<Henkilo> stack = new Stack();
        for(int i = 0; i < 10; i++) {
            Henkilo henkilo = new Henkilo("Jaska", "Jokunen");
            stack.push(henkilo);
        }
        for(int i = 0; i < 10; i++) {
            System.out.println(stack);
        }
    }
}
