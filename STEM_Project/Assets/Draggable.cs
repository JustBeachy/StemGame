using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour
{
    private bool dragging;
    public string AreaName;
    public Text correctTxt;
    public bool inCorrectSpot = false;
    float timer = -5;
    public GameObject toDestroy;
    public bool isLeader = false;
    List<RaycastResult> rayList = new List<RaycastResult>();
    

    private void Start()
    {
        
        if (AreaName == "none")
            inCorrectSpot = true;
    }
    public void Update()
    {


        if (dragging)
        {
            transform.position = Input.mousePosition;
        }

        if(Input.GetMouseButton(0))
        {
            var pointer = new PointerEventData(EventSystem.current);
            pointer.position = Input.mousePosition;
            EventSystem.current.RaycastAll(pointer, rayList);
            if (rayList.Count > 0 && rayList[0].gameObject==gameObject)
                dragging = true;

        }
        if(Input.GetMouseButtonUp(0))
        {
            dragging = false;
            CheckIfComplete();
        }

        if(timer>=0)
            timer -= Time.deltaTime;

        if (timer < 0 && timer > -5)
        {
            if (isLeader)
            {
                GameObject.FindGameObjectWithTag("Controller").GetComponent<Controller>().NextStep();
                Destroy(toDestroy);
            }
        }

    }

  

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag=="DragArea")
        {
            if (other.gameObject.GetComponent<DragArea>().AreaName == gameObject.GetComponent<Draggable>().AreaName)
                inCorrectSpot = true;
            if (AreaName=="none")
                inCorrectSpot = false;
        }

    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "DragArea")
        {
            if (AreaName == "none")
                inCorrectSpot = true;
            else
                inCorrectSpot = false;
        }
    }

    void CheckIfComplete()
    {
        if (isLeader)
        {
            var dragList = GameObject.FindGameObjectsWithTag("Draggable");
            bool allCorrect = true;
            for (int d = 0; d < dragList.Length; d++)
            {
                if (dragList[d].GetComponent<Draggable>().inCorrectSpot == false)
                {
                    allCorrect = false;
                    break;
                }
            }
            if (allCorrect)///////if all correct
            {
                if (correctTxt != null)
                {
                    correctTxt.text = "Correct!";
                    GetComponent<AudioSource>().Play();
                }
                timer = 2;

            }
        }
    }


}

