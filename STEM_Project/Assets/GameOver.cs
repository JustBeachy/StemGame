using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject screenToDestroy;
    float timer = 0;
    bool startTimer = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (startTimer)
        {
            timer += Time.deltaTime;

            if (timer >= 2.5)
                Destroy(screenToDestroy);
        }
        
    }
    private void OnEnable()
    {
        startTimer = true;
    }
}
