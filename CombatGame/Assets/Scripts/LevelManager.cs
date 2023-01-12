using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private string nextLevelName;
    [SerializeField] private int remainingBall;


    private void Update()
    {
        if (remainingBall == 0)
        {
            print("Update");
            LoadNextLevel();
        }
    }

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(nextLevelName);
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
