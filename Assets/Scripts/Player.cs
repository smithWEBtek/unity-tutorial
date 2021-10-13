using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    int health;
    int power;
    string name;

    // a class is a blueprint for creating objects
    // a constructor, named same as class name
    public Player(int health, int power, string name){
        this.health = health;
        this.power = power;
        this.name = name;
    }
    
    public void Attack(){
        // same things
        // Debug.Log(this.name + " is attacking!");
        Debug.Log(name + " is attacking!");
    }

    public void Info(){
        Debug.Log("Health is: " + this.health);
        Debug.Log("Power is: " + this.power);
        Debug.Log("Name is: " + this.name);
    }

}
