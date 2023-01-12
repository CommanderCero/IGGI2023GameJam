using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private LevelManager levelManager;
    // Start is called before the first frame update
    void Start()
    {
        levelManager.IncreaseBallNum();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
