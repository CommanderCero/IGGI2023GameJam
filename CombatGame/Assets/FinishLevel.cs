using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLevel : MonoBehaviour
{
    [SerializeField] private LevelManager levelManager;

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("ball"))
        {
            levelManager.LoadNextLevel();
        }
    }
}
