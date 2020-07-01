using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MMAnimation : MonoBehaviour
{
    float timer = 0;
    int flip = -1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        gameObject.transform.position += new Vector3(0, (Screen.height/15)*flip, 0) * Time.deltaTime;

        if(timer>1)
        {
            flip *= -1;
            timer = 0;
        }
    }
}
