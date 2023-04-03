/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Project/Maven2/JavaApp/src/main/java/${packagePath}/${mainClassName}.java to edit this template
 */

package com.mycompany.data_structures_exercise_9;

import java.util.ArrayList;
import java.util.HashSet;
import java.util.Random;

/**
 *
 * @author manu1
 */
public class Data_structures_exercise_9 {

    public static void main(String[] args) {
        ArrayList<String> nimet = new ArrayList<>();
        nimet.add("Anton");
        nimet.add("Petteri");
        nimet.add("Jeppe");
        nimet.add("Pauli");
        nimet.add("Jesse");
        nimet.add("Lassi");
        nimet.add("Lauri");
        nimet.add("Leevi");
        nimet.add("Valtteri");
        nimet.add("Eetu");
        ArrayList<String> ammattinimikkeet = new ArrayList<>();
        ammattinimikkeet.add("ohjelmistoinsinööri");
        ammattinimikkeet.add("web-kehittäjä");
        ammattinimikkeet.add("sähköinsinööri");
        ammattinimikkeet.add("ohjelmistokehittäjä");
        ammattinimikkeet.add("ohjelmoija");
        HashSet<Employee> tyontekijat = new HashSet<>();
        Random randomId = new Random();
        Random randomNimi = new Random();
        Random randomAmmattinimike = new Random();
        for(int i = 0; i < 5; i++) {
            int id = randomId.nextInt(1000);
            int nimi = randomNimi.nextInt(10);
            int ammattinimike = randomAmmattinimike.nextInt(5);
            Employee tyontekija = new Employee(id, nimet.get(nimi), ammattinimikkeet.get(ammattinimike));
            tyontekijat.add(tyontekija);
        }
        System.out.println("Alkuperäinen HashSet:");
        for(Employee tyontekija: tyontekijat) {
            System.out.println(tyontekija);
        }
        System.out.println("");
        System.out.println("Kloonattu HashSet:");
        HashSet<Employee> kloonattu = new HashSet<>();
        kloonattu.addAll(tyontekijat);
        for(Employee tyontekija: kloonattu) {
            System.out.println(tyontekija);
        }
    }
}
