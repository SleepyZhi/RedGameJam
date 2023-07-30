using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SlowDownTime : MonoBehaviour
{
    [SerializeField] AudioSource sfx;
    [SerializeField] AudioClip clip;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            sfx.PlayOneShot(clip);
            Time.timeScale = 0.5f;
            Destroy(gameObject);
        }
    }
}
