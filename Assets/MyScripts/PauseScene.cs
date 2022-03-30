using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScene : MonoBehaviour
{
    [System.Obsolete]
    void On()
    {
        Time.timeScale = 0; //pauses the current scene 
        Application.LoadLevelAdditive("VideoScene"); //loads your desired other scene
    }

    [System.Obsolete]
    void Off()
    {
        Time.timeScale = 1; //resumes the current scene 
        Application.LoadLevelAdditive("Asunto"); //loads your desired other scene
    }
}
