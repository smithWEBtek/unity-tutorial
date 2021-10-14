using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    private int _health;
    private int _power;
    private string _name;

    public int Health
    {
        get {
            return _health;
        }

        set {
            _health = value;
        }
    }

    public int Power
    {
        get
        {
            return _power;
        }
        set
        {
            _power = value;
        }
    }


    public string Name
    {
        set
        {
            _name = value;
        }
        get
        {
            return _name;
        }
    }

    // the public constructor
    public Player() { }

    public Player(int health, int power, string name){
        Health = health;
        Power = power;
        Name = name;
    }

    //public void Attack(){
    //    Debug.Log(Name + " is attacking!");
    //}

    public virtual void Attack()
    {
        Debug.Log("Player is attacking with fire!");
    }

    public void Info(){
        Debug.Log("Health is: " + Health);
        Debug.Log("Power is: " + Power);
        Debug.Log("Name is: " + Name);
    }

    //public void SetHealth(int health){
    //    this.health = health;
    //}

    //public int GetHealth(){
    //    //return this.health;
    //    return health;
    //}
}
