using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySelf : MonoBehaviour
{
    [SerializeField] AudioSource sfx;
    [SerializeField] AudioClip clip;
    [SerializeField] ScoreManager scoreManager;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            sfx.PlayOneShot(clip);
            scoreManager.currentScore += 10f;
            Destroy(gameObject);
        }
    }

}
