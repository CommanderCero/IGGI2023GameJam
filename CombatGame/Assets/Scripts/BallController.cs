using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class BallController : MonoBehaviour
{
    public PlayerButtons PlayerButton;
    public float Force;

    private Rigidbody2D rig;

    void Start()
    {
        rig = GetComponent<Rigidbody2D>();   
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey(InputManager.GetKey(PlayerButton)))
        {
            rig.AddForce(Vector2.right * Time.fixedDeltaTime * Force);
        }
    }
}
