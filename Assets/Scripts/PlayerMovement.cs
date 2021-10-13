using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 5f;
    float d = 10.2f;
    float e = 10.3f;

    // Start is called before the first frame update
    void Start()
    {
        // print("the speed is: " + speed);
        CalcTwoNumbers(d, e);
    }

    void CalcTwoNumbers(float a, float b){
        // print("CalcTwoNumbers executed ..." + a + b);
        // print("CalcTwoNumbers executed ..." + (a + b));
        // print(a + b);
    }






    // Update is called once per frame
    void Update()
    {
        // A key, D key, horizontal movement
        // W key, S key, vertical movement
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Horizontal");

        Vector2 pos = transform.position;

        pos.x += h * speed * Time.deltaTime;
        pos.y += v * speed * Time.deltaTime;

        transform.position = pos;
    }

} //class
