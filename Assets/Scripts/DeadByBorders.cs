using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class DeadByBorders : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider snake)
    {
        if (snake.CompareTag("snakeHead") || snake.CompareTag("snake"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }
}
