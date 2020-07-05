using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PencilGame : MonoBehaviour
{
    public Text scoreText;
    float score=0;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (StaticVars.StartGame)
        {
            score += Time.deltaTime * 10;
            scoreText.text = "Score: " + score.ToString("0");
        }

        if (!StaticVars.StartGame && Input.GetMouseButtonDown(0))
            StaticVars.StartGame = true;


        if (StaticVars.StartGame)
        {
            if (Input.GetMouseButton(0))
            {
                transform.position += new Vector3(0, 800, 0) * Time.deltaTime;//rise
            }
            else
                transform.position += new Vector3(0, -800, 0) * Time.deltaTime;//fall

            if (transform.position.y > 1200)
                transform.position = new Vector2(transform.position.x, 1200);

            if (transform.position.y < 300)
                transform.position = new Vector2(transform.position.x, 300);
        }

    }
}
