using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{

    public int rScore;
    public int lScore;
    public BallControl ball;

    public int maxScore; 
    public void Add_rScore(int add)
    {
        rScore += add;
        ball.resetBall();
        if(rScore >= maxScore)
        {
            GameOver();
        }
    }
    public void Add_lScore(int add)
    {
        lScore += add;
        ball.resetBall();

        if (lScore >= maxScore)
        {
            GameOver();
        }
    }

    public void GameOver()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
