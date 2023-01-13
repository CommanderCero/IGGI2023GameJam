using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSoundHandler : MonoBehaviour
{
    [Header("Collision")]
    public AudioSource CollisionSfx;
    public float MinimumSpeed = 1.0f;
    public float MaximumSpeed = 10.0f;

    [Header("Rolling")]
    public AudioSource RollingSfx;
    public float FadeOutTime = 0.1f;
    public float RollingMinimumVolume = 0.1f;
    public float RollingMinimumSpeed = 1.0f;
    public float RollingMaximumSpeed = 10.0f;

    private Coroutine fadeOutCoroutine;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Hardcoded check for colliding with the camera edges
        if (collision.gameObject.GetComponent<Camera>() != null)
            return;

        float speed = collision.relativeVelocity.magnitude;
        if (speed > MinimumSpeed)
        {
            float volume = (speed - MinimumSpeed) / (MaximumSpeed - MinimumSpeed);
            volume = Mathf.Clamp01(volume);
            CollisionSfx.PlayOneShot(CollisionSfx.clip, volume);
        }

        if(speed > RollingMinimumSpeed)
        {
            if(fadeOutCoroutine != null)
                StopCoroutine(fadeOutCoroutine);
            RollingSfx.Play();
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        // Hardcoded check for colliding with the camera edges
        if (collision.gameObject.GetComponent<Camera>() != null)
            return;

        float speed = collision.relativeVelocity.magnitude;
        float volume = RollingMinimumVolume;
        volume += (1f - volume) * (speed - RollingMinimumSpeed) / (RollingMaximumSpeed - RollingMinimumSpeed);
        volume = Mathf.Clamp01(volume);
        RollingSfx.volume = volume;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        // Hardcoded check for colliding with the camera edges
        if (collision.gameObject.GetComponent<Camera>() != null)
            return;

       fadeOutCoroutine = StartCoroutine(FadeOutRolling());
    }

    private IEnumerator FadeOutRolling()
    {
        float startVolume = RollingSfx.volume;
        float time = FadeOutTime;
        while(time > 0)
        {
            RollingSfx.volume = startVolume * (time / FadeOutTime);
            time -= Time.deltaTime;
            yield return null;
        }

        RollingSfx.Stop();
    }
}
