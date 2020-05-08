using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextButton : MonoBehaviour
{
    GameObject controller;
    // Start is called before the first frame update
    void Start()
    {
        controller = GameObject.FindGameObjectWithTag("Controller");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextStep()
    {
        controller.GetComponent<Controller>().NextStep();
    }
}
