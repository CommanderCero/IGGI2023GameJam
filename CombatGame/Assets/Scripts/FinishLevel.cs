using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLevel : MonoBehaviour
{
    [SerializeField] private LevelManager levelManager;
    [SerializeField] private ColorName colorName;
    
    void Start()
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = ColorManager.GetKey(colorName);
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("ball"))
        {
            ColorName ballColorName = col.gameObject.GetComponent<Ball>().colorName;
            if (ballColorName == colorName)
            {
                levelManager.DecreaseBallNum(); 
                Destroy(col.gameObject);
            }
            
        }
    }
}
