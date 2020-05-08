using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
    public int lessonNum;
    public GameObject screenToCreate;
    public GameObject nextLesson;
    public string directions;
    public GameObject Arrow;
    public int arrowPos=0;
    Text directionTxt;
    
    
    // Start is called before the first frame update
    void Start()
    {
        directionTxt = GameObject.FindGameObjectWithTag("Directions").GetComponent<Text>();
        SetDirectionText();
        SetArrowPos();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetDirectionText()
    {
        directionTxt.text = directions;
    }

    public void NextStep()
    {
        if (screenToCreate != null)
            Instantiate(screenToCreate, GameObject.FindGameObjectWithTag("Canvas").transform);
        else
            GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Movement>().canMove=true;

        gameObject.GetComponent<Controller>().lessonNum = nextLesson.GetComponent<Controller>().lessonNum;
        StaticVars.lessonCount = lessonNum;
        gameObject.GetComponent<Controller>().screenToCreate = nextLesson.GetComponent<Controller>().screenToCreate;
        gameObject.GetComponent<Controller>().nextLesson = nextLesson.GetComponent<Controller>().nextLesson;

        gameObject.GetComponent<Controller>().directions = nextLesson.GetComponent<Controller>().directions;
        gameObject.GetComponent<Controller>().arrowPos = nextLesson.GetComponent<Controller>().arrowPos;

        if(directions!="")
        SetDirectionText();
        SetArrowPos();

    }

    public void SetArrowPos()
    {

        if (arrowPos == 0)//nothing
        {
            Arrow.transform.position = new Vector3(0, -30, 0);
            
        }
        if (arrowPos == 1)//whiteboard
        {
            Arrow.transform.position = new Vector3(-7.5f, 2.5f, 0);
            GetComponent<CurrentDevice>().currntDev = 0;
        }
        if (arrowPos == 2)//laptop
        {
            Arrow.transform.position = new Vector3(-1.3f, 2f, 0.6f);
            GetComponent<CurrentDevice>().currntDev = 1;
        }
        if (arrowPos == 3)//tablet
        {
            Arrow.transform.position = new Vector3(5f, 2f, 5.5f);
            GetComponent<CurrentDevice>().currntDev = 2;
        }
        if (arrowPos == 4)//phone
        {
            Arrow.transform.position = new Vector3(1f, 1.5f, -7.3f);
            GetComponent<CurrentDevice>().currntDev = 3;
        }

        Arrow.GetComponent<ArrowBob>().startPos = Arrow.transform.position;
    }
}
