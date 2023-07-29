using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;
    public float currentScore = 0f;
    public float highScore = 0f;
    public TextMeshProUGUI textHighScore;
    public TextMeshProUGUI textCurrentScore;

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

        if (currentScore > highScore)
        {
            highScore = currentScore;
        }
    }

    public void GameOver()
    {
        
        Time.timeScale = 0;
        isPlaying = false;

        textHighScore.text = "Highscore:\n" + Mathf.RoundToInt(highScore).ToString();
        textCurrentScore.text = "Score: " + Mathf.RoundToInt(currentScore).ToString();
    }

    public string PrettyScore()
    {
        return Mathf.RoundToInt(currentScore).ToString();
    }
    

}
