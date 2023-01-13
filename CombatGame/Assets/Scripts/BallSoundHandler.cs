using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSoundHandler : MonoBehaviour
{
    public AudioSource CollisionSfx;
    public float MinimumSpeed = 1.0f;
    public float MaximumSpeed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Hardcoded check for colliding with the camera edges
        if (collision.gameObject.GetComponent<Camera>() != null)
            return;

        float speed = collision.relativeVelocity.magnitude;
        if (collision.relativeVelocity.magnitude > MinimumSpeed)
        {
            float volume = (speed - MinimumSpeed) / (MaximumSpeed - MinimumSpeed);
            volume = Mathf.Clamp01(volume);
            CollisionSfx.PlayOneShot(CollisionSfx.clip, volume);
        }
    }
}
