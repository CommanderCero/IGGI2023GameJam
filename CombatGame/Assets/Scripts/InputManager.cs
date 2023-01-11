using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlayerButtons
{
    Player1Button1,
    Player1Button2,
    Player1Button3,
    Player1Button4,
    Player1Button5,
    Player1Button6,
    Player2Button1,
    Player2Button2,
    Player2Button3,
    Player2Button4,
    Player2Button5,
    Player2Button6
}

public static class InputManager
{
    public static Dictionary<PlayerButtons, KeyCode> KeyMapping = new Dictionary<PlayerButtons, KeyCode>
    {
        {PlayerButtons.Player1Button1, KeyCode.Q },
        {PlayerButtons.Player1Button2, KeyCode.W },
        {PlayerButtons.Player1Button3, KeyCode.E },
        {PlayerButtons.Player1Button4, KeyCode.A },
        {PlayerButtons.Player1Button5, KeyCode.S },
        {PlayerButtons.Player1Button6, KeyCode.D },
        {PlayerButtons.Player2Button1, KeyCode.U },
        {PlayerButtons.Player2Button2, KeyCode.I },
        {PlayerButtons.Player2Button3, KeyCode.O },
        {PlayerButtons.Player2Button4, KeyCode.J },
        {PlayerButtons.Player2Button5, KeyCode.K },
        {PlayerButtons.Player2Button6, KeyCode.L },
    };

    public static KeyCode GetKey(PlayerButtons button)
    {
        return KeyMapping[button];
    }
}
