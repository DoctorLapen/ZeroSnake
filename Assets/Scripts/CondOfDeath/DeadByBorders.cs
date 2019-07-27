using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
/* 
 * скрипт который отвечает за обработку столкновений змейки с бордером
 * если есть столкновение: то вызывает метод Dead  у змейки
 * устанавливается на префабы бордеров
 */
public class DeadByBorders : MonoBehaviour
{
    public SnakeMovement movement;
    
    private void OnTriggerEnter(Collider snake)
    {
        if (snake.CompareTag("snakeHead") )
        {

            movement.Dead();
        }

    }
}
