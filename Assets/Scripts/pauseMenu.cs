using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseMenu: MonoBehaviour
{
    public GameObject PauseMenu;
    public GameObject ScoreMenu;
    public GameObject TimerPane;
    public SnakeMovement movement;
    
    public Timer timer;

    // Start is called before the first frame update
    public  void PauseGame()
    {
        ScoreMenu.SetActive(false);
        PauseMenu.SetActive(true);
        movement.speed = 0;
    }

    // Update is called once per frame
    public void ContinueGame()
    {
       // PauseMenu.SetActive(false);
        ScoreMenu.SetActive(true);
        TimerPane.SetActive(true);
        timer.isActive = true;
        PauseMenu.SetActive(false);
    }
    public void Exit()
    {
        Application.Quit();
    }
}
