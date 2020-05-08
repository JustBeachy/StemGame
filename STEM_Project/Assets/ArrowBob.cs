using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowBob : MonoBehaviour
{
    public Vector3 startPos;
    int flip = 1;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 1*flip, 0) * Time.deltaTime;

        if (Mathf.Abs(transform.position.y-startPos.y)>.8f)
        {
            flip *= -1;
        }
    }
}
