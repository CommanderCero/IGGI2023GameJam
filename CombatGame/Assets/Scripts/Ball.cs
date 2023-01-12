using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private LevelManager levelManager;

    [SerializeField] public ColorName colorName;
    // Start is called before the first frame update
    void Start()
    {
        levelManager.IncreaseBallNum();
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = ColorManager.GetKey(colorName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
