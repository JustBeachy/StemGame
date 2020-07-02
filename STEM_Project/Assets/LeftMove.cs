using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (StaticVars.StartGame)
        {
            gameObject.transform.position -= new Vector3(StaticVars.MinigameSpeed, 0, 0) * Time.deltaTime;
        }
        if (transform.position.x < -50)
            Destroy(gameObject);
    }
}
