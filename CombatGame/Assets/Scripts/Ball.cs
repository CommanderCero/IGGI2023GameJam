using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    enum BallType
    {
        lollipop,
        crown
    }
    [SerializeField] private LevelManager levelManager;
    [SerializeField] private BallType ballType;
    [SerializeField] public ColorName colorName;
    // Start is called before the first frame update
    void Start()
    {
        levelManager.IncreaseBallNum();
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();

        if (ballType == BallType.lollipop)
        {
            spriteRenderer.sprite = ColorManager.GetLollipopSprite(colorName);
        }
        else
        {
            spriteRenderer.sprite = ColorManager.GetCrownSprite(colorName);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
