using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    ScoreManager scoreManager;

    [SerializeField] GameObject loseMenu;
    [SerializeField] float berriesScore;
    private Vector2 pos;

    private void Update()
    {
        pos = transform.position;
        if (pos.x < -10)
        {
            loseMenu.SetActive(true);
            Destroy(gameObject);
            ScoreManager.Instance.GameOver();
        }

        if (pos.y < 0)
        {
            loseMenu.SetActive(true);
            Destroy(gameObject);
            ScoreManager.Instance.GameOver();
        }

    }

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
