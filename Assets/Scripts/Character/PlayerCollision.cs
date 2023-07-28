using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField] GameObject loseMenu;
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
