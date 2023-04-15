/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.data_structures_exercise_1;

/**
 *
 * @author manu1
 * @param <T>
 */
public class Stack<T> {
    private Stack<T> previous;
    private T value;
    
    Stack() {}
    
    Stack(T value) {
        this.value = value;
    }
    
    Stack(Stack<T> previous, T value) {
        this.previous = previous;
        this.value = value;
    }
    
    public void push(T value) {
        this.previous = new Stack<>(this.previous, this.value);
        this.value = value;
    }
    
    public void pop() {
        if(this.empty()) {
            throw new IllegalArgumentException("Stack is empty");
        }
        T top = this.value;
        this.value = this.previous.value;
        this.previous = this.previous.previous;
    }
    
    public int size() {
        return this.empty() ? 0 : 1 + this.previous.size();
    }
    
    public boolean empty() {
        return this.previous == null;
    }
}
