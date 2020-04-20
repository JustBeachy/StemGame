using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour, IPointerDownHandler
{
    private bool dragging;
    public string AreaName;

    public bool inCorrectSpot = false;
    

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
            if (allCorrect)
                print("correct");
               
        }


    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (Input.GetMouseButton(0))
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

