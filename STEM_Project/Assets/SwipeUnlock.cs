using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeUnlock : MonoBehaviour
{

    Vector2 firstmouse;
    Vector3 startPoint;
    // Start is called before the first frame update
    void Start()
    {
        startPoint = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            firstmouse = Input.mousePosition;

        if (Input.mousePosition.x > firstmouse.x&&Input.GetMouseButton(0))
        {
            gameObject.GetComponent<RectTransform>().offsetMin = new Vector2(Input.mousePosition.x-startPoint.x ,0);
           
            //gameObject.transform.position = new Vector3(gameObject.transform.position.x, startPoint.y, startPoint.z);
        }

        if (gameObject.GetComponent<RectTransform>().offsetMin.x > (Screen.width / 4) && !Input.GetMouseButton(0))
            Destroy(gameObject);
        else if(!Input.GetMouseButton(0))
            gameObject.GetComponent<RectTransform>().offsetMin = new Vector2(0, 0);

        //if (Input.GetMouseButtonUp(0) && (Input.mousePosition.x - 100) > firstmouse.x)
        //  Destroy(gameObject);
    }
}
