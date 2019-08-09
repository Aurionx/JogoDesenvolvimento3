using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{

    public bool pause;
    public GameObject pauseUI;


    private void Start()
    {
        Time.timeScale = 1;
        pause = false;
        pauseUI.SetActive(false);
    }

    public void PauseOn()
    {
        pauseUI.SetActive(true);
        Time.timeScale = 0;
        pause = true;
    }

    public void PauseOff()
    {
        pauseUI.SetActive(false);
        Time.timeScale = 1;
        pause = false;
    }



    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.P))
        {
            if (!pause)
            {
                PauseOn();
            }
            else
            {
                PauseOff();
            }
        }

    }

    public void LoadMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Menu");
    }

    public void Sair()
    {
        Application.Quit();
    }

}
