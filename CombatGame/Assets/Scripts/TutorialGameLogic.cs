using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialGameLogic : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit(0);
        }
        
        if (Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene("TitleScreen");
        }
    }
}
