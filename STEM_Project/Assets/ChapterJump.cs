using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChapterJump : MonoBehaviour
{
    public GameObject ChapterStartStep;
    GameObject Controller;
    // Start is called before the first frame update
    void Start()
    {
        Controller = GameObject.FindGameObjectWithTag("Controller");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoToChapter()
    {
        if (ChapterStartStep != null)
        {
            Controller.GetComponent<Controller>().screenToCreate = null;
            Controller.GetComponent<Controller>().nextLesson = ChapterStartStep;
            Controller.GetComponent<Controller>().arrowPos = ChapterStartStep.GetComponent<Controller>().arrowPos;

            Controller.GetComponent<Controller>().NextStep();
            Controller.GetComponent<Controller>().NextStep();
            //Controller.GetComponent<Controller>().SetArrowPos();

        }
    }
}
