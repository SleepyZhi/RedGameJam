using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreHandler : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreUI;

    ScoreManager gm;

    private void Start()
    {
        gm = ScoreManager.Instance;
    }

    private void OnGUI()
    {
        scoreUI.text = ScoreManager.Instance.PrettyScore();
    }
}