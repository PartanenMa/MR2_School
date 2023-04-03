/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Project/Maven2/JavaApp/src/main/java/${packagePath}/${mainClassName}.java to edit this template
 */

package com.mycompany.data_structures_exercise_11;

import java.util.HashSet;

/**
 *
 * @author manu1
 */
public class Data_structures_exercise_11 {
    
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
        int length = 5;
        int loop = 0;
        int count = 0;
        boolean diff = true;
        while(true) {
            String random = Data_structures_exercise_11.randomString(length);
            int hashCode = random.hashCode();
            if(loop == 1000) {
                break;
            }else if(hashCodes.isEmpty()) {
                hashCodes.add(hashCode);
            }else{
                for(int code: hashCodes) {
                    if(code == hashCode) {
                        loop++;
                        diff = false;
                    }
                }
                if(diff == true) {
                    hashCodes.add(hashCode);
                    loop = 0;
                }
            }
        }
        for(int code: hashCodes) {
            System.out.println(code);
            count++;
        }
        System.out.println("Total of " + count + " different hash codes created.");
    }
}
