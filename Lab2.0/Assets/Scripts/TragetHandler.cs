using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TragetHandler : MonoBehaviour
{
    public LogicScript logicScript;
    void Start()
    {
        logicScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision");
        logicScript.AddScore();
    }
}
