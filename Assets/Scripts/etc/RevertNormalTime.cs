using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevertNormalTime : MonoBehaviour
{
    void Update()
    {
        if (Time.timeScale < 1 && Time.timeScale != 0)
        {
            InvokeRepeating("IncreaseTimeScale", 1.5f, 1f);
        }
        else if (Time.timeScale >= 1)
        {
            Time.timeScale = 1;
            CancelInvoke("IncreaseTimeScale");
        }

    }

    //Not going to question why this just increase to 1 instantly but I'll take it
    private void IncreaseTimeScale()
    {
        Time.timeScale += 0.05f;
    }
}
