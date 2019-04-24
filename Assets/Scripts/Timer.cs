using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public bool isActive = false;

    public float time = 3 * 1000f;
    public GameObject TimerPane;
    public Text TimerText;
    public SnakeMovement movement;
    private float snakeSpeed;
    private float time_;

    // Start is called before the first frame update
    void Start()
    {
        time_ = time;
        snakeSpeed = movement.speed;
        TimerText.text = time.ToString(); ;
    }

    // Update is called once per frame
    void Update()
    {
        if (isActive)
        {
            if (time > 0)
            {
                time -= Time.deltaTime ;
                Debug.Log(time);
                Debug.Log(Time.deltaTime);
                TimerText.text = string.Format("{0:f0}", time);
            }
            else
            {
                TimerPane.SetActive(false);
                movement.speed = snakeSpeed;
                isActive = false;
            }
        }
        else {
            time = time_;
        }
    }
}
