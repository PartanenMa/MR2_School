/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.data_structures_exercise_7;

/**
 *
 * @author manu1
 */
public class Employee {
    private int id;
    private String nimi;
    private String ammattinimike;
    
    public Employee(int id, String nimi, String ammattinimike) {
        this.id = id;
        this.nimi = nimi;
        this.ammattinimike = ammattinimike;
    }
    
    @Override
    public int hashCode() {
        return (int) id * nimi.hashCode() * ammattinimike.hashCode();
    }
    
    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null) return false;
        if (this.getClass() != o.getClass()) return false;
        Employee employee = (Employee) o;
        return id == employee.id 
          && (nimi.equals(employee.nimi) 
          && ammattinimike.equals(employee.ammattinimike));
    }
    
    public int getId() {
        return this.id;
    }
    
    public String getNimi() {
        return this.nimi;
    }
    
    public String getAmmattinimike() {
        return this.ammattinimike;
    }
    
    @Override
    public String toString() {
        return "Id: " + this.id + ", nimi: " + this.nimi + ", ammattinimike: " + this.ammattinimike;
    }
}
