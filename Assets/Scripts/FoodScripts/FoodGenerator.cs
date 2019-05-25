using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodGenerator : MonoBehaviour
   
     // скрипт генератора еды в случайном месте в прямоугольнике с вершинами(xMin,xMax,zMin,zMax)
     
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
    private GameObject newFood;

    void Start() {
        newFood = foodPrefab;
        //передача ссылки на экземпляр основного класа управления змейки в текущей игре в обьект еды
        newFood.GetComponent<eatFood>().movement = movement;
        //передача значения growPerOneFood в  обьект еды
        newFood.GetComponent<eatFood>().growPerOneFood = growPerOneFood;
    }

    //метод добавления еды
    void addNewFood()
    {
        curFood = Instantiate(newFood, randomPos(),Quaternion.identity);  
    }
    //метод создание вектора со случайными координатами  в прямоугольнике с вершинами(xMin,xMax,zMin,zMax)
    Vector3 randomPos() {
        return new Vector3(Random.Range(xMin, xMax),y, Random.Range(zMin, zMax)); 
    }
    //метод который проверяет сьедина ли текущая еда,если да то вызывает метод  addNewFood()
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
