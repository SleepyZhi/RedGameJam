using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelTransition : MonoBehaviour
{
    public void OnPressNexLevel()
    {
        if (Input.touchCount > 0)
        {
            SceneManager.LoadScene(1);
        }
        SceneManager.LoadScene(1);
    }
}
