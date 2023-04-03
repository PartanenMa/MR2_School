/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.data_structures_exercise_3;

/**
 *
 * @author manu1
 */
public class Dequeue {
    int  arr;
    int front, rear; 
    int size;
    int SIZE;
    
    public Dequeue() {
        this.size = 0;
        this.SIZE = 5;
        this.arr = new int[SIZE];
        front = -1;
        rear = -1;
    }
    
    void push_front(int key) {
        if(full()) {
            System.out.println("Dequeue is full!");
        }else {
            if(front == -1) {
                front = rear = 0;
            }       
            else if(front == 0) {
                front = SIZE - 1;
            }               
            else{
                --front;
                arr[front] = key;
            }
            this.size++;
        }
    }
    
    void push_back(int key){
        if(full()) {
            System.out.println("Dequeue is full!");            
        }
        else {
            if(front == -1){
                front = rear = 0;
            }                      
            else if(rear == SIZE-1) {
                rear = 0;
            }
            else {
                ++rear;
                arr[rear] = key;
            } 
            this.size++;
        } 
    }
    
    void pop_front() {
        if(empty()) {
            System.out.println("Dequeue is empty!");
        }else {
            if(front == rear) {
                front = rear = -1;
            }
            else if(front == SIZE-1) {
                front = 0;
            }
            else {
                ++front;
            } 
            this.size--;
        }
    }
    
    void pop_back() {
        if(empty()) {
            System.out.println("Dequeue is empty!");
        }else {
            if(front == rear) {
                front = rear = -1;
            }       
            else if(rear == 0) {
                rear = SIZE-1;
            }
            else {
                --rear;
            } 
            this.size--;
        }
    }
    
    int get_front() {
        if(empty()) {   
            System.out.println("Dequeue is empty!");
            return -1;
        }else {
            return arr[front];
        }
    }
    
    int get_back() {
        if(empty()) {
            System.out.println("Dequeue is empty!");
            return -1;
        }else {
            return arr[rear];
        }
    }
    
    boolean full() {
        if((front == 0 && rear == SIZE - 1)  || (front == rear + 1)) {
            return true;
        }else {
            return false;
        }            
    }
    
    boolean empty() {
        if(front == -1) {
            return true;
        }else {
            return false;
        }           
    }
    
    public int size() {
        return this.size;
    }
};
