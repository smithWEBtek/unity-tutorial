using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningHowToProgram : MonoBehaviour
{
    // decimal with many places
    double mana = 15.5;
    
    // holds single character, but rarely used
    // uses single quote
    char oneChar = 'a';


    // a decimal point number
    float speed = 5.0f;

    // a whole number
    int health = 100;

    // a string, using double quotes
    string playerName = "Warrior";

    // boolean true or false
    bool isDead = false;

    // a comment
        /* a multiline
        comment ...
    */


    // second function executed ( awake is first)
    private void Start()
    {

        int a = 10;
        int b = 5;
        int c = a + b;
        string firstName = "Brad";
        string lastName = "Smith";
        string fullName = firstName + " " + lastName;

        // print("isDead: " + isDead);

        // Debug.Log("this is from debug.log");
        // Debug.Log("c: " + c);
        // Debug.Log("A + B = " + c);

        // Debug.Log("fullname is: " + fullName);
    }


}
