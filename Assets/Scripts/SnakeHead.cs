using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeHead : MonoBehaviour
{
    public SnakeMovement movement;
     void onCollisionEnter(Collision col)
    {
        Debug.Log(col.gameObject.tag);
        if (col.gameObject.tag == "Food")
        {
            Debug.Log(col.gameObject.tag);
            movement.addBodyPart();
            Destroy(col.gameObject);
        }
        else {
            return;
        }
    }


}
