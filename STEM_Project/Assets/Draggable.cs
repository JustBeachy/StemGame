using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour, IPointerDownHandler
{
    private bool dragging;
    public string AreaName;
    public Text correctTxt;
    public bool inCorrectSpot = false;
    float timer = -5;
    public GameObject toDestroy;
    public bool isLeader = false;

    private void Start()
    {
        
    }
    public void Update()
    {
        if (dragging)
        {
            transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        }

        if(Input.GetMouseButtonUp(0))
        {
            dragging = false;


            var dragList =GameObject.FindGameObjectsWithTag("Draggable");
            bool allCorrect = true;
            foreach (GameObject g in dragList)
            {
                if (!g.GetComponent<Draggable>().inCorrectSpot)
                {
                    allCorrect = false;
                    break;
                }
            }
            if (allCorrect)///////if all correct
            {
                if(correctTxt!=null)
                correctTxt.text = "Correct!";
                timer = 2;
                
            }
               
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

    public void OnPointerDown(PointerEventData eventData)
    {
        
            dragging = true;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag=="DragArea")
        {
            if (other.gameObject.GetComponent<DragArea>().AreaName == gameObject.GetComponent<Draggable>().AreaName)
                inCorrectSpot = true;
        }

    }
  
}

