using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//скрипт для обработки клавиш в главном меню

public class Menu: MonoBehaviour
{
    /*
     * обработка кнопки startButton
     * загрузка первого уровня
     */
    public void start()
    {
        SceneManager.LoadScene(1);
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
