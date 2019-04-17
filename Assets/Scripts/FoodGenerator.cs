using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodGenerator : MonoBehaviour
{
    public float xMin=13.1f;
    public float xMax=24.89f;
    public float zMin=0.2f;
    public float zMax = 38.2f;
    public float y = 0.39f;
    public GameObject curFood;
    public GameObject foodPrefab;
    public SnakeMovement movement;
    public int growPerOneFood = 3;
    private Vector3 curPos;


    // Start is called before the first frame update
    void addNewFood()
    {
        GameObject newFood = foodPrefab;
        newFood.GetComponent<eatFood>().movement = movement;
        newFood.GetComponent<eatFood>().growPerOneFood = growPerOneFood;

        curFood = Instantiate(newFood, randomPos(),Quaternion.identity);  
    }

    Vector3  randomPos() {
        return new Vector3(Random.Range(xMin, xMax),y, Random.Range(zMin, zMax)); 
    }
    // Update is called once per frame
    void Update()
    {
        if (!curFood)
        {
            addNewFood();
        }
        else {
            return;
        }
    }
}
