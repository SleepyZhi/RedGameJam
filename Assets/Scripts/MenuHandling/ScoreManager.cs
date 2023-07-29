using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;
    public float currentScore = 0f;

    public bool isPlaying = true;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
    }

    public void Update()
    {   
        if (isPlaying)
            currentScore += Time.deltaTime;
    }

    public void GameOver()
    {
        currentScore = 0f;
        isPlaying = false;
    }

    public string PrettyScore()
    {
        return Mathf.RoundToInt(currentScore).ToString();
    }
    

}
