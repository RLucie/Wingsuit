using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public bool gameHasEnded;

    public float score;

    public FinishTrigger finishTrigger;

    public GameObject GameOverUI;
    public GameObject WinUI;
    public GameObject LoseUI;

    private void Start()
    {
        gameHasEnded = false;
    }

    public void GameOver()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            GameOverUI.SetActive(true);
        }

    }

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            if (finishTrigger.hasFinished == true)
            {
                if (score == 4)
                {
                    WinUI.SetActive(true);
                }
                else
                {
                    LoseUI.SetActive(true);
                }
            }
        }
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Debug.Log(SceneManager.GetActiveScene().name);
    }
}
