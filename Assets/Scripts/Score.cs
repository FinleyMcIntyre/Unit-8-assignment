using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Text scoreText;
    public float scoreAmount;
    public float pointsIncreasedPerSecond;

    void Start()
    {
        scoreAmount = 0f;
        pointsIncreasedPerSecond = 5f;
    }

    void Update()
    {
        scoreText.text = "Score - " + (int)scoreAmount; 
        scoreAmount += pointsIncreasedPerSecond  * Time.deltaTime;
    }

}
