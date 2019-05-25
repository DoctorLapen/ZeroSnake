using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eatFood : MonoBehaviour
{   /* 
       скрипт для поедания еды
       устанавливается на префабе еды
    */

    // ссылка на экземпляр основного класа управления змейки в текущей игре
    public SnakeMovement movement;
    public int growPerOneFood;
    /*
     * метод для поедания еды
     *  увеличения  размера змейки и очков
     *  
     * уничтожает сьеденую еду
     */
    private void OnTriggerEnter(Collider snake)
    {
        if (snake.CompareTag("snakeHead"))
        {
            movement.score++;
            //добавление сегментов змейки равное  growPerOneFood(скорость роста змейки)
            
            for (int i = 0; i < growPerOneFood; i++)
            {
                movement.addBodyPart();
            }
            Destroy(gameObject);
        }
        
    }
}
