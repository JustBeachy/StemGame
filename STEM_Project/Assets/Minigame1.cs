using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Minigame1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.position += new Vector3(700, Random.Range(-500, 500), 0)*Time.deltaTime;
    }

    
}
