using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ColorName
{
    White,
    Red,
    Blue,
    Green
}

public static class ColorManager
{
    public static Dictionary<ColorName, Color> KeyMapping = new Dictionary<ColorName, Color>
    {
        { ColorName.White, Color.white },
        { ColorName.Red, Color.red },
        { ColorName.Blue, Color.blue },
        { ColorName.Green, Color.green }
    };

    public static Color GetKey(ColorName name)
    {
        return KeyMapping[name];
    }
}