using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eatFood : MonoBehaviour
{
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
            snake.GetComponent<Transform>().parent.GetComponent<SnakeMovement>().addBodyPart();
            Destroy(gameObject);
        }
        
    }
}
