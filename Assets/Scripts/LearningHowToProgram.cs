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
    }
}
