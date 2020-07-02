using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PencilLead : MonoBehaviour
{
    public GameObject Lead, LeadParent;
    int count = 0;
    GameObject Canvas;
    
    // Start is called before the first frame update
    void Start()
    {
        Canvas = GameObject.FindGameObjectWithTag("Canvas");
    }

    // Update is called once per frame
    void Update()
    {
        if (StaticVars.StartGame)
        {
            count++;
            if (count % 1 == 0)
            {
                var newLead = Instantiate(Lead,LeadParent.transform);
                //newLead.transform.SetAsFirstSibling();
                newLead.transform.position = transform.position;

            }
        }
    }
}
