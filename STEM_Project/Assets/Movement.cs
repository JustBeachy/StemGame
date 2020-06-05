using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public FixedJoystick joystick;
    public GameObject laptop;
    public GameObject createScreen;
    public GameObject LaptopLoginScreen;
    public GameObject PinScreen;
    public GameObject SwipeScreen;
    public bool canMove = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            gameObject.transform.position += transform.forward * Time.deltaTime * joystick.Vertical * 4;
            gameObject.transform.Rotate(new Vector3(0, joystick.Horizontal * Time.deltaTime * 80, 0));
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        
        /*if(other.gameObject.tag=="SnapToScreen")
        {
            Instantiate(createScreen, GameObject.FindGameObjectWithTag("Canvas").transform);
            canMove = false;
            gameObject.transform.position = laptop.transform.position - new Vector3(+.5f, -.5f, 0);
            gameObject.transform.LookAt(laptop.transform);
        }*/
        var g = GameObject.FindGameObjectWithTag("Controller");
        if (other.gameObject.name == g.GetComponent<CurrentDevice>().Devices[g.GetComponent<CurrentDevice>().currntDev].name)
        {
            g.GetComponent<Controller>().NextStep();
            canMove = false;
            if(other.name=="Laptop")
            {
                Instantiate(LaptopLoginScreen, GameObject.FindGameObjectWithTag("Canvas").transform);
            }
            if (other.name == "Phone")
            {
                Instantiate(PinScreen, GameObject.FindGameObjectWithTag("Canvas").transform);
            }
            if (other.name == "Tablet")
            {
                Instantiate(SwipeScreen, GameObject.FindGameObjectWithTag("Canvas").transform);
            }

        }

    }
}
