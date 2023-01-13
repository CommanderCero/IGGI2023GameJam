using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusicHandler : MonoBehaviour
{
    public static BackgroundMusicHandler Instance;

    public AudioSource BackgroundMusic;
    private void Awake()
    {
        if(Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(transform.gameObject);
        PlayMusic();
    }

    public void PlayMusic()
    {
        if (BackgroundMusic.isPlaying)
            return;
        BackgroundMusic.Play();
    }

    public void StopMusic()
    {
        BackgroundMusic.Stop();
    }
}
