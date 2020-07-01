using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PasswordText : MonoBehaviour
{
    public InputField textToConvert;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
        string newText="";
        for(int i=0; i<textToConvert.text.Length;i++)
        {
            newText += "*";
        }
        textToConvert.text = newText;
        
    }
}
