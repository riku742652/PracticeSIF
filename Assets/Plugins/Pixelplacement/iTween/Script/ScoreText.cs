using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour {

    public int score = 0;
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(score == 1)
        {
            this.GetComponent<Text>().text = "GOOD";

        }else if(score == 2)
        {
            this.GetComponent<Text>().text = "GREAT";
        }else if(score == 3)
        {
            this.GetComponent<Text>().text = "PERFECT";
        }
        else
        {
            this.GetComponent<Text>().text = "BAD";

        }

    }
}