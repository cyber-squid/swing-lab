using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Main Scene");
        Time.timeScale = 1f;
    }

    public void PlayTutorial()
    {
        SceneManager.LoadScene("Tutorial Scene");
        Time.timeScale = 1f;
    }

    public void QuitGame()
    {
        Application.Quit();
    }    
}
