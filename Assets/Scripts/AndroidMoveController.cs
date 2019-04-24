using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AndroidMoveController : MonoBehaviour
{
    public SnakeMovement movement;
    
    public void RightRotationHandler()
    {
        movement.rotationDirection = 1.0f;
    }
    public void LeftRotationHandler()
    {
        movement.rotationDirection = -1.0f;
    }
    public  void moveStraight()
    {
        movement.rotationDirection = 0;
    }
}
