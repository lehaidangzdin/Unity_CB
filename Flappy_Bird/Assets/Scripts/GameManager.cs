using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    private int score;
    public Text scoreText;
    public Player player;
    public GameObject playButton;
    public GameObject gameOver;

    private void Awake()
    {
        Application.targetFrameRate = 60;
        Pause();
    }
    public void Play()
    {
        

        score = 0;
        scoreText.text = score.ToString();
        playButton.SetActive(false);
        gameOver.SetActive(false);
        Time.timeScale = 1f;
        player.enabled = true;
        Tubes[] tubes = FindObjectsOfType<Tubes>();
        for(int i =0; i< tubes.Length; i++)
        {
            Destroy(tubes[i].gameObject);
        }
    }

    public void Pause()
    {
        Time.timeScale = 0f;
        player.enabled = false;
    }
    public void GameOver()
    {
        gameOver.SetActive(true);
        playButton.SetActive(true);
        Pause();
    }
    public void IncreateSorce()
    {
        score++;
        scoreText.text = score.ToString();
    }
}
