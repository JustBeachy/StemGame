using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ABCD : MonoBehaviour
{
    public bool isAnswer = false;
    public string CorrectText;
    float timer = -5;
    public GameObject toDestroy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer >= 0)
            timer -= Time.deltaTime;

        if (timer < 0 && timer > -5)
        {
            
                GameObject.FindGameObjectWithTag("Controller").GetComponent<Controller>().NextStep();
                Destroy(toDestroy);
         
        }
    }

    public void CheckIfAnswer()
    {
        if(isAnswer)
        {
            gameObject.GetComponent<Text>().color = Color.green;
            GetComponentInParent<Questions>().correctField.GetComponent<Text>().text ="Correct! "+ CorrectText; //display correct text
            timer = 5;

        }
        else
        {
            gameObject.GetComponent<Text>().color = Color.red;
        }
    }
}
