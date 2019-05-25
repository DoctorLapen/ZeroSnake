using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//скрипт для обработки клавиш в меню паузы
public class pauseMenu: MonoBehaviour
{
    public GameObject PauseMenu;
    public GameObject ScoreMenu;
    public GameObject TimerPane;
    // ссылка на экземпляр основного класа управления змейки в текущей игре
    public SnakeMovement movement;
    // ссылка на скрипт текущего таймера
    public Timer timer;

    /*
     * обраьатывает кнопку паузы во время игры
     * вызывает меню паузы 
     * останавливает змейку
     */
    public  void PauseGame()
    {
        ScoreMenu.SetActive(false);
        PauseMenu.SetActive(true);
        movement.speed = 0;
    }

    /*
     * обрабатывает кнопку ContinuetButton
     * возвращает в игру
     * активирует таймер задержки(подробнее в скрипте Timer)
     */

    public void ContinueGame()
    {
       
        ScoreMenu.SetActive(true);
        TimerPane.SetActive(true);
        timer.isActive = true;
        PauseMenu.SetActive(false);
    }
  /*
   * обработка кнопки ExitButton
   * выход из игры
   */
    public void Exit()
    {
        Application.Quit();
    }
}
