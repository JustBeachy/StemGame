using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lesson : MonoBehaviour
{
    public int lessonToDisplay;
    public GameObject textObject;
    public List<string> lessonText = new List<string>();

    // Start is called before the first frame update
    void Start()
    {
        //0
        lessonText.Add("add lesson 1 here. If there will be multiple screens for the definition (like the player has to click 'next', then...");
        //1
        lessonText.Add("split it up by adding another one of these lines of code. Label above each line with a number so we can keep track of their index in the list.");
        //2
        lessonText.Add("fsjkfd;ljsfdjs;la");






        FillText();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FillText()
    {
        textObject.GetComponent<Text>().text = lessonText[lessonToDisplay];
    }
}
