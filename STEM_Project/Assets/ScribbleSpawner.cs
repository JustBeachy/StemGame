using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScribbleSpawner : MonoBehaviour
{
    public GameObject scribble;
    public float timer=0;
    public float spawnTimer=1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(StaticVars.StartGame)
        timer += Time.deltaTime;

        StaticVars.MinigameSpeed *= 1 + (((int)timer % 10) / 10);

        
            if (timer > spawnTimer)
            {
                Instantiate(scribble, new Vector3(transform.position.x + 150, transform.position.y + Random.Range(-500, 400)), Quaternion.identity, transform);
            if(Random.Range(0,2)==0)
            {
                Instantiate(scribble, new Vector3(transform.position.x + 150, transform.position.y + Random.Range(-500, 400)), Quaternion.identity, transform); //chance to spawn multiple
            }
            if (Random.Range(0, 4) == 3)
            {
                Instantiate(scribble, new Vector3(transform.position.x + 150, transform.position.y + Random.Range(-500, 400)), Quaternion.identity, transform); //chance to spawn multiple
            }
            spawnTimer += 1 - (((int)timer % 10) / 20);
            }
        
    
    }
}
