using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    public int Score=0;
    public GameObject Gameover;
    public GameObject Restart, highscore, home, score;
    public Text ScoreText, ScoreText1, HighScore;
    public AudioSource DieSound,PointSound,WingSound;

    public void MoveUp()
    {
        WingSound.Play();
        rb.velocity = new Vector2(0, 0);
        rb.AddForce(new Vector2(0,speed*Time.deltaTime));
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(!(collision.gameObject.CompareTag("top")))
        {
            DieSound.Play();
            Time.timeScale=0.0f;
            Gameover.SetActive(true);
            home.SetActive(true);
            Restart.SetActive(true);
            highscore.SetActive(true);
            score.SetActive(false);
            Destroy(gameObject);
        }    
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Point"))
        {
            PointSound.Play();
            Score++;
            Debug.Log(Score);
            if(Score>PlayerPrefs.GetInt("HighScore",0))
            {
                PlayerPrefs.SetInt("HighScore",Score);
                HighScore.text=Score.ToString();
            }
        }
    }

    
    // Start is called before the first frame update
    void Start()
    {
        HighScore.text=PlayerPrefs.GetInt("HighScore",0).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            MoveUp();
        ScoreText.text=Score.ToString();
        ScoreText1.text=Score.ToString();
    }

   
}
