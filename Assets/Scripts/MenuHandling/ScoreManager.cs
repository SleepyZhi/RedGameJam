using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
    }

    public float currentScore = 0f;

    public bool isPlaying = false;

    private void Update()
    {   if (isPlaying)
            currentScore += Time.deltaTime;

        if (Input.GetKeyDown("k"))
        {
            isPlaying = true;
        }
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
