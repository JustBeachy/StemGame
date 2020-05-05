using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ABCD : MonoBehaviour
{
    public bool isAnswer = false;
    public string CorrectText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CheckIfAnswer()
    {
        if(isAnswer)
        {
            gameObject.GetComponent<Text>().color = Color.green;
            GetComponentInParent<Questions>().correctField.GetComponent<Text>().text ="Correct! "+ CorrectText; //display correct text

        }
        else
        {
            gameObject.GetComponent<Text>().color = Color.red;
        }
    }
}
