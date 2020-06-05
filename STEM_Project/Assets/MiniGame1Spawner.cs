using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGame1Spawner : MonoBehaviour
{
    float timer = 0;
    public GameObject Virus;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer>2)
        {
            timer = 0;
            int r = Random.Range(1, 4);
            for(int i =0; i<4;i++)
            Instantiate(Virus, new Vector3(-1000-Random.Range(0,500),Random.Range(0,1000)),Quaternion.identity,GameObject.FindGameObjectWithTag("Canvas").transform);
        }
    }
}
