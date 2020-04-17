using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Questions : MonoBehaviour
{
    public int questionToDisplay;
    public GameObject questionTitle;
    public GameObject aField;
    public GameObject bField;
    public GameObject cField;
    public GameObject dField;

    public List<string> questionList = new List<string>(100);
    public List<string> aList = new List<string>(100);
    public List<string> bList = new List<string>(100);
    public List<string> cList = new List<string>(100);
    public List<string> dList = new List<string>(100);
    public List<string> answerList = new List<string>(100);
    // Start is called before the first frame update
    void Start()
    {
        //Question 0 (multiple choice)
        questionList.Add("What is...");
        aList.Add("a thing");
        bList.Add("b thing");
        cList.Add("c thing");
        dList.Add("d thing");
        answerList.Add("b");

        
        //Question 1 (true/false)
        questionList.Add("jkfdhjhdjkjkg");
        aList.Add("a thing");
        bList.Add("b thing");
        answerList.Add("b");



        FillQuestion();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FillQuestion() //fill the text elements with the questions and answers
    {
        questionTitle.GetComponent<Text>().text = questionList[questionToDisplay];
        aField.GetComponent<Text>().text = aList[questionToDisplay];
        bField.GetComponent<Text>().text = bList[questionToDisplay];
        cField.GetComponent<Text>().text = cList[questionToDisplay];
        dField.GetComponent<Text>().text = dList[questionToDisplay];
    }
}
