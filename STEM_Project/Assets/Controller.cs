using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
    public List<int> ListOfLessons;
    public GameObject screenToCreate;
    public GameObject nextLesson;
    string directions;
    public GameObject Arrow;
    public int arrowPos=0;
    Text directionTxt;

    
    
    
    // Start is called before the first frame update
    void Start()
    {
        directionTxt = GameObject.FindGameObjectWithTag("Directions").GetComponent<Text>();
        
        SetArrowPos();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   

    public void NextStep()
    {
       // SetDirectionText();
        SetArrowPos();


        if (screenToCreate != null)
            Instantiate(screenToCreate, GameObject.FindGameObjectWithTag("Canvas").transform);
        else
            GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Movement>().canMove = true;


        gameObject.GetComponent<Controller>().ListOfLessons = nextLesson.GetComponent<Controller>().ListOfLessons;
        
        gameObject.GetComponent<Controller>().screenToCreate = nextLesson.GetComponent<Controller>().screenToCreate;
        gameObject.GetComponent<Controller>().nextLesson = nextLesson.GetComponent<Controller>().nextLesson;

       // gameObject.GetComponent<Controller>().directions = nextLesson.GetComponent<Controller>().directions;
        gameObject.GetComponent<Controller>().arrowPos = nextLesson.GetComponent<Controller>().arrowPos;

       

        
       

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
            directionTxt.text = "Walk to the whiteboard.";
        }
        if (arrowPos == 2)//laptop
        {
            Arrow.transform.position = new Vector3(-1.3f, 2f, 0.6f);
            GetComponent<CurrentDevice>().currntDev = 1;
            directionTxt.text = "Walk to the laptop.";
        }
            if (arrowPos == 3)//tablet
            {
                Arrow.transform.position = new Vector3(5f, 2f, 5.5f);
                GetComponent<CurrentDevice>().currntDev = 2;
                directionTxt.text = "Walk to the tablet.";
            }
            if (arrowPos == 4)//phone
            {
                Arrow.transform.position = new Vector3(1f, 2f, -7.3f);
                GetComponent<CurrentDevice>().currntDev = 3;
                directionTxt.text = "Walk to the phone.";
            }

            Arrow.GetComponent<ArrowBob>().startPos = Arrow.transform.position;
        }
    }
    

