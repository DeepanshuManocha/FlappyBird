using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject RedBird, BlueBird, YellowBird, Pannel, Pipes, Score;
    
    

    public void Home()
    {
        SceneManager.LoadScene("Start");
    }
    
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale=1.0f;
    }

    public void Red()
    {
        RedBird.SetActive(true);
        Pannel.SetActive(false);
        Pipes.SetActive(true);
        Score.SetActive(true);
    }  

    public void Blue()
    {
        BlueBird.SetActive(true);
        Pannel.SetActive(false);
        Pipes.SetActive(true);
        Score.SetActive(true);
    }

    public void Yellow()
    {
        YellowBird.SetActive(true);
        Pannel.SetActive(false);
        Pipes.SetActive(true);
        Score.SetActive(true);
    }  
}
