using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    private float elapsedTime;
    private bool inGame = true;

    [SerializeField] private GameObject gameOver;
    [SerializeField] private GameObject gameOverWithHighscore;
    [SerializeField] private TextMeshProUGUI highscoreText;

    private void Start()
    {
        EnemyManager.PlayerWonGame += GameEnded;
    }

    private void Update()
    {
        if (inGame)
        {
            elapsedTime += Time.deltaTime;
        }
    }

    private void GameEnded()
    {
        inGame = false;
        float previousScore = PlayerPrefs.GetFloat("MinimumTime", -1);
        
        // If I have never played the game before, theres no score
        if (previousScore < 0)
        {
            PlayerPrefs.SetFloat("MinimumTime", elapsedTime);
            gameOver.SetActive(false);
            gameOverWithHighscore.SetActive(true);
            highscoreText.text = "Congrats! new highscore: " + ((int) elapsedTime);
        }
        else
        {
            if (previousScore < elapsedTime)
            {
                gameOver.SetActive(true);
                gameOverWithHighscore.SetActive(false);
                // didnt hit a new highscore
            }
            else
            {
                gameOver.SetActive(false);
                gameOverWithHighscore.SetActive(true);

                PlayerPrefs.SetFloat("MinimumTime", elapsedTime);
                highscoreText.text = "Congrats! new highscore: " + ((int)elapsedTime);
            }
        }

    }
}
