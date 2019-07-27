using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/* 
 * скрипт ,который отвечает за обработку столкновений головы змейки с остальными сегментами
 * если есть столкновение: то вызывает метод Dead  у змейки
 * устанавливается на префабы хвоста
 */
public class DeadByTail : MonoBehaviour
{
    public SnakeMovement movement;
    
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("snakeHead") && Time.timeSinceLevelLoad >= 20)
        {
            
            movement.Dead();
        }
    }

}
