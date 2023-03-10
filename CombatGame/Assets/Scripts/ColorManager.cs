using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ColorName
{
    Red,
    Blue,
    Green
}

public static class ColorManager
{
    public static Dictionary<ColorName, Color> KeyMapping = new Dictionary<ColorName, Color>
    {
        { ColorName.Red, Color.red },
        { ColorName.Blue, Color.blue },
        { ColorName.Green, Color.green }
    };

    public static Color GetKey(ColorName name)
    {
        return KeyMapping[name];
    }

    public static Sprite GetLollipopSprite(ColorName name)
    {
        if (name == ColorName.Red)
        {
            return Resources.Load<Sprite>("Sprites/ball_lollipop");
        } 
        
        if (name == ColorName.Green)
        {
            return Resources.Load<Sprite>("Sprites/ball_lollipop_green");
        }
        
        return Resources.Load<Sprite>("Sprites/ball_lollipop_blue");
    }
    
    public static Sprite GetCrownSprite(ColorName name)
    {
        if (name == ColorName.Red)
        {
            return Resources.Load<Sprite>("Sprites/ball_clown");
        } 
        
        if (name == ColorName.Green)
        {
            return Resources.Load<Sprite>("Sprites/ball_clown_green");
        }
        
        return Resources.Load<Sprite>("Sprites/ball_clown_blue");
    }
    
    public static Sprite GetBasketBack(ColorName name)
    {
        if (name == ColorName.Red)
        {
            return Resources.Load<Sprite>("Sprites/basket_red_back");
        } 
        
        if (name == ColorName.Green)
        {
            return Resources.Load<Sprite>("Sprites/basket_green_back");
        }
        
        return Resources.Load<Sprite>("Sprites/basket_blue_back");
    }
    
    public static Sprite GetBasketTop(ColorName name)
    {
        if (name == ColorName.Red)
        {
            return Resources.Load<Sprite>("Sprites/basket_red_top");
        } 
        
        if (name == ColorName.Green)
        {
            return Resources.Load<Sprite>("Sprites/basket_green_top");
        }
        
        return Resources.Load<Sprite>("Sprites/basket_blue_top");
    }
}