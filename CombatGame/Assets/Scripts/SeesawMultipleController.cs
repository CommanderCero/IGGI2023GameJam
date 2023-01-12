using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class SeesawMultipleController : MonoBehaviour
{
    [SerializeField] PlayerButtons player1Button;
    [SerializeField] PlayerButtons player2Button;
    [SerializeField] float force;

    private Rigidbody2D rigidbody2d;

    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();   
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        bool player1Pressed = Input.GetKey(InputManager.GetKey(player1Button));
        bool player2Pressed = Input.GetKey(InputManager.GetKey(player2Button));
        if (player1Pressed && player2Pressed)
        {
            rigidbody2d.AddTorque(force);
        }
        
    }
}
