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

    int score1 = 4; // karkkien määrä tasolla 1
    int scoremax = 9; // karkkine määrä tasolla 2 (5) + karkkien määrä tasolla 1 (4)

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
    public void TyöPaikka()
    {
        SceneManager.LoadScene("työpaikka");
    }
    public void TestiScene()
    {
        SceneManager.LoadScene("testiscene");
    }
    
    public void Quit()
    {
        print("Quit");
        Application.Quit();
    }


}
