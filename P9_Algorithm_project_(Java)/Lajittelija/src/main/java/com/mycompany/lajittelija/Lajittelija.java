/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Project/Maven2/JavaApp/src/main/java/${packagePath}/${mainClassName}.java to edit this template
 */
package com.mycompany.lajittelija;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collections;

/**
 *
 * @author manu1
 */
// Ohjelma toimii määrittelemällä mukautetun lajittelujärjestyksen 
// annettujen kriteerien perusteella. Luokka toteuttaa Comparable-rajapinnan 
// ja ohittaa compareTo()-menetelmän lajittelujärjestyksen määrittämiseksi, 
// ja sitten Collections.sort()-menetelmää käytetään lajittelemaan 
// objektiluettelo tuon järjestyksen perusteella.
public class Lajittelija {

    public static void main(String[] args) {
        ArrayList<Creature> creatures = new ArrayList<>();
        // Creature-oliot tallennetaan ArrayListiin.
        // Voit testata ohjelmaa syöttämällä erilaisia kokonaislukuarvoja 
        // Creature-olioiden propertyihin:
        creatures.add(new Creature(2, 3, 1, 9));
        creatures.add(new Creature(2, 4, 3, 1));
        creatures.add(new Creature(3, 2, 3, 2));
        Collections.sort(creatures);
        // Tämä for-looppi tulostaa lajiteltujen Creature-olioiden luettelon ensin
        // lajiteltuna niiden ominaisuuksien summan ja sitten kaikkien 
        // ominaisuuksien kokonaissumman mukaan.
        for (Creature creature : creatures) {
            System.out.println(Arrays.toString(creature.getProperties()));
        }
    }
}
