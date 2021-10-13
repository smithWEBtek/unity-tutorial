using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoRouting1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

      // Debug.Log("Start executed ... ");
      // ExecuteSomething();
      // StartCoroutine(ExecuteAnotherThing(2));
      // StartCoroutine("ExecuteAnotherThing");
      // StopCoroutine("ExecuteAnotherThing");
    }

    void ExecuteSomething(){
      Debug.Log("Somthing executed ... ");
    }


    // coroutines need 'IEnumerator' and 'yield return'
    IEnumerator ExecuteAnotherThing(float time){
      yield return new WaitForSeconds(time);
      
      Debug.Log("Another thing execuded as a coRoutine");

      yield return new WaitForSeconds(time);
      // more code;
      print("more returned ...");
      
      yield return new WaitForSeconds(time);
    }

    // Update is called once per frame
    void Update()
    {

    }

}
