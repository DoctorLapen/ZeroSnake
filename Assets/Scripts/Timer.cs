using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// скрипт таймера задержи после выхода из паузы
public class Timer : MonoBehaviour
{
    public bool isActive = false;

    public float time = 3 * 1000f;
    public GameObject TimerPane;
    public Text TimerText;
    // ссылка на экземпляр основного класа управления змейки в текущей игре
    public SnakeMovement movement;
    private float snakeSpeed;
    private float time_;

    // инициализация таймера
    void Start()
    {
        time_ = time;
        snakeSpeed = movement.speed;
        TimerText.text = time.ToString(); ;
    }

    // основной рабочий метод таймера
    void Update()
    {
        if (isActive)
        {
            if (time > 0)
            {
                time -= Time.deltaTime ;
               
                TimerText.text = string.Format("{0:f0}", time);
            }
            else
            {
                TimerPane.SetActive(false);
                movement.speed = snakeSpeed;
                isActive = false;
            }
        }
        /*
         * установление времени отчета для следующего использования таймера
         * (возможность многократного использования таймера)
         */ 
        
        else {
            time = time_;
        }
    }
}
