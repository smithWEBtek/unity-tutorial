using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningHowToProgram : MonoBehaviour
{
    Player warrior;
    Player archer;

    private void Start()
    {
        // creating warrior using Warrior class
        Warrior warrior = new Warrior(3, 5, "Warror");
        warrior.Info();
        warrior.Attack();

    }


    private void Update()
    {

    }
}
