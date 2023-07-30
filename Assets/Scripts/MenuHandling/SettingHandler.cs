using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingHandler : MonoBehaviour
{
    [SerializeField] GameObject settingsTab;
    public void OnButtonPress()
    {
        if (settingsTab.activeSelf == true)
        {
            settingsTab.SetActive(false);
            Time.timeScale = 1;
        }
        else
        {
            settingsTab.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void OnResetButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

    public void OnHomeButton()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
}
