/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.lajittelija;

/**
 *
 * @author manu1
 */
public class Creature implements Comparable<Creature> {
    private int[] properties;

    public Creature(int... properties) {
        this.properties = properties;
    }
    
    public int[] getProperties() {
        return this.properties;
    }

    @Override
    public int compareTo(Creature other) {
        // Ensin lajittelemme ominaisuuksien summan mukaan.
        int sum = 0;
        int otherSum = 0;
        for (int i = 0; i < properties.length; i++) {
            sum += properties[i];
            otherSum += other.properties[i];
        }
        if (sum != otherSum) {
            return otherSum - sum;
        } else {
            // Jos summat ovat samat, lajittelemme kaikkien ominaisuuksien summan mukaan
            int total = 0;
            int otherTotal = 0;
            for (int i = 0; i < properties.length; i++) {
                total += properties[i];
                total += other.properties[i];
            }
            return otherTotal - total;
        }
    }
}
