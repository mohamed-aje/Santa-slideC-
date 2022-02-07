using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{

    private Text score;
    public static int scoreValue = 0;
    private int highscore;


    void Start()
    {
        scoreValue = 0;
        score = GetComponent<Text> ();
        highscore = PlayerPrefs.GetInt("highscore", 0);
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score: " + scoreValue.ToString();
        PlayerPrefs.SetInt("Score", scoreValue);

        if(highscore < scoreValue)
        {
            PlayerPrefs.SetInt("highscore", scoreValue);
        }
    }

}
