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
            gameObject.transform.position += (Camera.main.ScreenToWorldPoint(Input.mousePosition) - Camera.main.ScreenToWorldPoint(firstmouse));
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, startPoint.y, startPoint.z);
        }

        if (Input.GetMouseButtonUp(0) && (Input.mousePosition.x - 100) > firstmouse.x)
            Destroy(gameObject);
    }
}
