using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * Скрипт управления движением змейки с помощью виртуальных кнопок rightRotation и leftRotation
 */
public class AndroidMoveController : MonoBehaviour
{   // ссылка на экземпляр основного класса управления змейки в текущей игре
    public SnakeMovement movement;

 /* 
  * метод для поворота в право
  * срабатывает при удержание виртуальной кнопки rightRotation 
  */

    public void RightRotationHandler()
    {
        movement.rotationDirection = 1.0f;
    }

  /* 
   * метод для поворота в лево
   * срабатывает при удержание виртуальной кнопки leftRotation
  */
    public void LeftRotationHandler()
    {
        movement.rotationDirection = -1.0f;
    }
    /* 
    * метод для движения прямо
    * срабатывает если не удерживается виртуальная кнопка rightRotation  или  leftRotation
    */
    public void moveStraight()
    {
        movement.rotationDirection = 0;
    }
}
