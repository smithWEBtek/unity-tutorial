using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningHowToProgram : MonoBehaviour
{
    Player warrior;
    Player archer;

    private void Start()
    {
        // Player warrior = new Player();
        warrior = new Player(30, 22, "Fred");
        // archer = new Player(20, 31, "Archer");

        warrior.Info();
        warrior.Attack();
        //Debug.Log("warrior.health is: " + warrior.GetHealth());

        warrior.Health = 201;
        Debug.Log("warrior health is: " + warrior.Health);

        warrior.Power = 32;
        Debug.Log("warrior power is: " + warrior.Power);

        warrior.Name = "Charlie";
        Debug.Log("warror name is: " + warrior.Name);

    }
}
