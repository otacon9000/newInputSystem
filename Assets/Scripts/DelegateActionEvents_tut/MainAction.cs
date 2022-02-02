using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MainAction : MonoBehaviour
{
    public static Action<int> OnScoreChange;

    public int Score { get; set; }
    

    private void Start()
    {
        Score = 0;
    }

    void UpdateScore()
    {
        Score += 10;
        if (OnScoreChange != null)
            OnScoreChange(Score);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            UpdateScore();
        }
    }
}
