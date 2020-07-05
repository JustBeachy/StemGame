using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PencilLead : MonoBehaviour
{
    public GameObject Lead, LeadParent,EndGameScreen;
    int count = 0;
    GameObject Canvas;
    public GameObject ScreenToDestroy;
    
    
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

   
    private void OnCollisionEnter2D(Collision2D other)
    {
        
        if(other.gameObject.tag=="Enemy")
        {
            StaticVars.StartGame = false;
            StaticVars.MinigameSpeed = 600;
            EndGameScreen.SetActive(true);
            GetComponent<AudioSource>().Play();
            
        }
    }
}
