using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SimpleCreateDestroy : MonoBehaviour
{
    GameObject Canvas;
    public GameObject toCreate;
    public GameObject toDestroy;
    public bool isBackButton;
    // Start is called before the first frame update
    void Start()
    {
        Canvas = GameObject.FindGameObjectWithTag("Canvas");
    }

    // Update is called once per frame
    void Update()
    {
        if (isBackButton && GameObject.FindGameObjectWithTag("Controller").GetComponent<Back>().StepList.Count <= 2)
            gameObject.SetActive(false);//disable button if can't go back
    }

    public void CreateObject()
    {
        Instantiate(toCreate, Canvas.transform);
    }

   public void DestroyObject()
    {
        Destroy(toDestroy);
        
    }

    public void BackButton()
    {
        GameObject.FindGameObjectWithTag("Controller").GetComponent<Back>().GoBack(); //run the GoBack function
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("GameScene");
    }

}
