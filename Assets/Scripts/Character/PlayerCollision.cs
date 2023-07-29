using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    ScoreManager scoreManager;

    [SerializeField] GameObject loseMenu;
    [SerializeField] float berriesScore;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.tag == "Obstacles")
        {
            loseMenu.SetActive(true);
            Destroy(gameObject);
            ScoreManager.Instance.GameOver();
        }
    }
}
