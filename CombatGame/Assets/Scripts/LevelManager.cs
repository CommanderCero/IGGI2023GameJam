using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private string nextLevelName;
    [SerializeField] private GameObject successPanel;
    private int remainingBall = 0;

    private void Start()
    {
    }


    private void Update()
    {
        if (remainingBall == 0)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                LoadNextLevel();
                
            }
            successPanel.SetActive(true);
        }

        if (Input.GetKey(KeyCode.Escape))
        {
            QuitGame();
        }
        
    }

    public void LoadNextLevel()
    {
        if (nextLevelName == "None")
        {
            Application.Quit(0);
        }
        else
        {
            SceneManager.LoadScene(nextLevelName);
        }
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("TitleScreen");
    }

    public void ResetLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void QuitGame()
    {
        Application.Quit(0);
    }

    public void DecreaseBallNum()
    {
        remainingBall--;
    }

    public void IncreaseBallNum()
    {
        remainingBall++;
    }
}
