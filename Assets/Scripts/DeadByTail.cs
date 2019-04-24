using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadByTail : MonoBehaviour
{
    public SnakeMovement movement;
    void Update()
    {
      // Debug.Log(Time.timeSinceLevelLoad);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("snakeHead") && Time.timeSinceLevelLoad >= 20)
        {
            // Debug.Log("trigger");
            movement.Dead();
        }
    }

}
