using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPause : MonoBehaviour
{
    public GameObject pauseMenu;
    private bool isPaused;

    public GameObject MotionBlurObject;
    public GameObject PaniniProjectionObject;
    public GameObject VignetteObject;
    public GameObject LensDistortionObject;
    public GameObject FilmGrainObject;

    public GameObject BackgroundMusicObject;


    void Start()
    {
        pauseMenu.SetActive(false);
        isPaused = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
    public void ResumeGame()
    {
        isPaused = false;
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void ToMenuButton()
    {
        SceneManager.LoadScene("Main Menu");
        Time.timeScale = 1f;
    }

    public void MotionBlurToggle()
    {
        if (MotionBlurObject.activeInHierarchy == true)
        {
            MotionBlurObject.SetActive(false);
        }
        else
        {
            MotionBlurObject.SetActive(true);
        }
    }

    public void PaniniProjectionToggle()
    {
        if (PaniniProjectionObject.activeInHierarchy == true)
        {
            PaniniProjectionObject.SetActive(false);
        }
        else
        {
            PaniniProjectionObject.SetActive(true);
        }
    }

    public void VignetteToggle()
    {
        if (VignetteObject.activeInHierarchy == true)
        {
            VignetteObject.SetActive(false);
        }
        else
        {
            VignetteObject.SetActive(true);
        }
    }

    public void LensDistortionToggle()
    {
        if (LensDistortionObject.activeInHierarchy == true)
        {
            LensDistortionObject.SetActive(false);
        }
        else
        {
            LensDistortionObject.SetActive(true);
        }
    }

    public void FilmGrainToggle()
    {
        if (FilmGrainObject.activeInHierarchy == true)
        {
            FilmGrainObject.SetActive(false);
        }
        else
        {
            FilmGrainObject.SetActive(true);
        }

    }

    public void BackgroundMusicToggle()
    {
        if (BackgroundMusicObject.activeInHierarchy == true)
        {
            BackgroundMusicObject.SetActive(false);
        }
        else
        {
            BackgroundMusicObject.SetActive(true);
        }
    }
}
