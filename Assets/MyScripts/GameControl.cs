using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{
    public static GameControl instance;
    /**
    public GameObject livesHolder;

    int score = 0;
    int lives = 3;

    int score1 = 4; // karkkien m‰‰r‰ tasolla 1
    int scoremax = 9; // karkkine m‰‰r‰ tasolla 2 (5) + karkkien m‰‰r‰ tasolla 1 (4)

    public Text scoreText;
    /**/
    private void Awake()
    {
        instance = this;
    }

    public void Asunto()
    {
        SceneManager.LoadScene("asunto");
    }
    public void Office()
    {
        SceneManager.LoadScene("office");
    }
    public void VideoScene()
    {
        SceneManager.LoadScene("videoscene");
    }
    
    public void Quit()
    {
        print("Quit");
        Application.Quit();
    }


}
