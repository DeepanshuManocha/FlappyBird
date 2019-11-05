using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectBackground : MonoBehaviour
{
    public GameObject Pipes, Background,playButton,FlappyBirdText,SelectBac;
    
    public void StartGame()
    {
        playButton.SetActive(false);
        Pipes.SetActive(false);
        FlappyBirdText.SetActive(false);
        Background.SetActive(true);
        SelectBac.SetActive(true);
        Time.timeScale=1.0f;
    }
    public void OnMouseDown() 
    {
        if(gameObject.CompareTag("Day"))
        SceneManager.LoadScene("Day");
        else
        {
            SceneManager.LoadScene("Night");
        }
    }
}
