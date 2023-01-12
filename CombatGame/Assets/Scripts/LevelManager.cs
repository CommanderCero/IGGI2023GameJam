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
            successPanel.SetActive(true);
        }
    }

    public void LoadNextLevel()
    {
        print("Load");
        SceneManager.LoadScene(nextLevelName);
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("TitleScreen");
    }

    public void ResetLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
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
