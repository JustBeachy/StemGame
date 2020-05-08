using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PinUnlock : MonoBehaviour
{
    public Text code;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddCode()
    {
        if (code.text.Length >= 3)
            Destroy(gameObject);
        code.text += "*";
    }
}
