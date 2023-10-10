using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizOneCodingChallenge : MonoBehaviour
{
    public int Score = 0;
    public string PlayerName = "Dustin";
    public int Health = 100;

    // Start is called before the first frame update
    void Start()
    {
        IncreseScore();
        PrintPlayerName();
        DecreseHealth();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void IncreseScore()
    {
        Score += 10;
        //Would be better if were Score += amount
    }

    private void PrintPlayerName()
    {
        Debug.Log(PlayerName);
    }

    private void DecreseHealth()
    {
        Health -= 20;
    }
}
