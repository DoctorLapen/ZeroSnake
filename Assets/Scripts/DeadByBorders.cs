using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class DeadByBorders : MonoBehaviour
{
    public SnakeMovement movement;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider snake)
    {
        if (snake.CompareTag("snakeHead") )
        {

            movement.Dead();
        }

    }
}
