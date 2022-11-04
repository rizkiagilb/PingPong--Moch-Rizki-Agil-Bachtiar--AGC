using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Text scoreKanan;
    public Text scoreKiri;

    public ScoreManager manager;

    private void Update()
    {
        scoreKiri.text = manager.lScore.ToString();
        scoreKanan.text = manager.rScore.ToString();
    }
}

