using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Back : MonoBehaviour
{
    public List<GameObject> StepList;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoBack()
    {
        gameObject.GetComponent<Controller>().ListOfLessons = StepList[StepList.Count-3].GetComponent<Controller>().ListOfLessons;

        gameObject.GetComponent<Controller>().screenToCreate = StepList[StepList.Count - 3].GetComponent<Controller>().screenToCreate;

        gameObject.GetComponent<Controller>().nextLesson = StepList[StepList.Count - 3].GetComponent<Controller>().nextLesson;
        // gameObject.GetComponent<Controller>().directions = nextLesson.GetComponent<Controller>().directions;
        gameObject.GetComponent<Controller>().arrowPos = StepList[StepList.Count - 3].GetComponent<Controller>().arrowPos;

        gameObject.GetComponent<Controller>().NextStep(true);

        StepList.RemoveAt(StepList.Count - 1);
        StepList.TrimExcess();
    }
}
