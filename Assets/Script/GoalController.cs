using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController : MonoBehaviour
{
    public Collider2D ball;
    public bool isRight;
    public ScoreManager score;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision == ball)
        {
            if (isRight)
            {
                score.Add_lScore(1);
            }
            if (!isRight)
            {
                score.Add_rScore(1);
            }
        }
    }
}
