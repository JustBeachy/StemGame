using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleCreateDestroy : MonoBehaviour
{
    GameObject Canvas;
    public GameObject toCreate;
    public GameObject toDestroy;
    // Start is called before the first frame update
    void Start()
    {
        Canvas = GameObject.FindGameObjectWithTag("Canvas");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CreateObject()
    {
        Instantiate(toCreate, Canvas.transform);
    }

   public void DestroyObject()
    {
        Destroy(toDestroy);
        
    }

    public void CreateInfoScreen()
    {
        StaticVars.lessonCount++;
        var i= Instantiate(toCreate, Canvas.transform);
        i.GetComponent<Lesson>().lessonToDisplay = StaticVars.lessonCount;
    }

}
