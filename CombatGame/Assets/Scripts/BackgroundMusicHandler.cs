using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackgroundMusicHandler : MonoBehaviour
{
    public static BackgroundMusicHandler Instance;

    public AudioSource BackgroundMusic;
    public List<AudioClip> BackgroundVariants;

    private Dictionary<string, int> LevelTrackAssignment = new Dictionary<string, int>
    {
        {"level1", 0},
        {"level2", 1},
        {"level3", 1},
        {"level4", 2},
        {"level5", 3},
        {"level6", 4},
        {"level7", 4},
    };

    private void Awake()
    {
        if(Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        SceneManager.sceneLoaded += SceneManager_sceneLoaded;

        Instance = this;
        DontDestroyOnLoad(transform.gameObject);
        PlayTrack(0);
    }

    private void SceneManager_sceneLoaded(Scene arg0, LoadSceneMode arg1)
    {
        int trackId = LevelTrackAssignment.GetValueOrDefault(arg0.name, 0);
        PlayTrack(trackId);
        Debug.Log($"Playing track {trackId}");
    }

    public void PlayTrack(int index)
    {
        var currentTime = BackgroundMusic.time;
        BackgroundMusic.clip = BackgroundVariants[index];
        BackgroundMusic.time = currentTime;
        if (!BackgroundMusic.isPlaying)
        {
            BackgroundMusic.Play();
        }
    }

    public void StopMusic()
    {
        BackgroundMusic.Stop();
    }
}
