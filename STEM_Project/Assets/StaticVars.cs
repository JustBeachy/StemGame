using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StaticVars : MonoBehaviour
{
    public static float TypeSpeed = .025f;
    public static float MinigameSpeed = 600;
    public static bool StartGame = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AdjustSpeed()
    {
        TypeSpeed = .0125f/GetComponent<Slider>().value;
    }
}
