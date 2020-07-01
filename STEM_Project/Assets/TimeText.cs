using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class TimeText : MonoBehaviour
{
    DateTime DT;
    public Text timeText;
    // Start is called before the first frame update
    void Start()
    {
        DateTime DT = DateTime.Now;
        if (DT.Hour > 12)
            DT.AddHours(12);

        timeText.text = DT.ToString("h:mm");//DT.Hour + ":" + DT.Minute;


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
