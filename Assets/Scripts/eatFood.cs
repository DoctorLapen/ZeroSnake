using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eatFood : MonoBehaviour
{
    public   SnakeMovement movement;
    public int growPerOneFood;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider snake)
    {
        if (snake.CompareTag("snakeHead"))
        {
            movement.score++;
            for (int i = 0; i < growPerOneFood; i++)
            {
                movement.addBodyPart();
            }
            Destroy(gameObject);
        }
        
    }
}
