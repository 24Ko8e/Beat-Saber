using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    int score;
    public Text scoreTxt;

    private void Start()
    {
        score = 0;
    }

    private void Update()
    {
        scoreTxt.text = score.ToString();
    }

    public void updateScore()
    {
        score++;
    }
}
