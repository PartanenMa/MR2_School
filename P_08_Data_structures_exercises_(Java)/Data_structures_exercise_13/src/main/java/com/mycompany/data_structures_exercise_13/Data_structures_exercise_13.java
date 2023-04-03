/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Project/Maven2/JavaApp/src/main/java/${packagePath}/${mainClassName}.java to edit this template
 */

package com.mycompany.data_structures_exercise_13;

import java.util.HashSet;
import java.util.Map;
import java.util.Set;
import java.util.TreeMap;

/**
 *
 * @author manu1
 */
public class Data_structures_exercise_13 {
    
    static String randomString(int length) {
        String characters = "abc";
        StringBuilder sb = new StringBuilder(length);
        for (int i = 0; i < length; i++) {
         int index = (int)(characters.length() * Math.random());
         sb.append(characters.charAt(index));
        }
        return sb.toString();
    }

    public static void main(String[] args) {
        HashSet<Integer> hashCodes = new HashSet<>();
        TreeMap<Integer, Integer> hashCodesT = new TreeMap<>();
        int length = 5;
        int loop = 0;
        int count = 0;
        boolean diff = true;
        while(true) {
            System.out.println("String length: " + length);
            String random = Data_structures_exercise_13.randomString(length);
            int hashCode = random.hashCode();
            if(loop == 1000 || length == 14) {
                break;
            }else if(hashCodes.isEmpty()) {
                hashCodes.add(hashCode);
                hashCodesT.put(hashCode, 0);
            }else{
                for(int code: hashCodes) {
                    if(code == hashCode) {
                        loop++;
                        diff = false;
                    }
                    if(hashCodesT.containsKey(code)) {
                        int same = hashCodesT.get(code) + 1;
                        hashCodesT.replace(code, same);
                    }
                }
                if(diff == true) {
                    hashCodes.add(hashCode);
                    hashCodesT.put(hashCode, 0);
                    loop = 0;
                }
            }
            length++;
        }
        for(int code: hashCodes) {
            count++;
        }
        System.out.println("Total of " + count + " different hash codes created.");
        Set<Map.Entry<Integer, Integer> > entrySet = hashCodesT.entrySet();
        Map.Entry<Integer, Integer>[] entryArray = entrySet.toArray(new Map.Entry[entrySet.size()]);
        for (int i = 0; i < hashCodesT.size(); i++) {
            System.out.println("Hash code: " + entryArray[i].getKey());
            System.out.println("Duplicates: " + entryArray[i].getValue());
        }
    }
}
