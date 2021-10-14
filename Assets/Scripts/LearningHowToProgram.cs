using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningHowToProgram : MonoBehaviour
{
    Player warrior;
    Player archer;

    private Rigidbody2D myBody;
    private BoxCollider2D myCollider;
    private AudioSource audioSource;
    private Animator anim;
    //private Transform myTransform;


    //  1st function catlledd
    private void Awake()
    {
       
    }

    // 2nd function called
    private void OnEnable()
    {
        
    }

    // 3rd function called
    private void Start()
    {
        // creating warrior using Warrior class
        //Warrior warrior = new Warrior(3, 5, "Warror");
        //warrior.Info();
        //warrior.Attack();

        Transform transform = GetComponent<Transform>();
        Debug.Log("transform: " + transform);
        transform.position = new Vector3(100, 200, 300);

        myBody = GetComponent<Rigidbody2D>();
        Debug.Log(myBody.bodyType);

        myCollider = GetComponent<BoxCollider2D>();
        Debug.Log(myCollider);

        audioSource = GetComponent<AudioSource>();
        Debug.Log(audioSource);

        anim = GetComponent<Animator>();
        Debug.Log(anim);

    }

    // called after every frame render
    private void Update()
    {

    }
}
