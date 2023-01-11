using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    [SerializeField] private LevelManager levelManager;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("ball"))
        {
            levelManager.ResetLevel();
        }
    }
}
