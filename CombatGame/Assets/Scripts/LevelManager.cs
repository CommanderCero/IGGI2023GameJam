using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private string nextLevelName;

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(nextLevelName);
    }

    public void ResetLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
