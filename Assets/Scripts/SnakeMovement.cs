using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SnakeMovement : MonoBehaviour
{
    public List<Transform> bodyParts = new List<Transform>();
    public float minDis = 0.25f;
    public float speed = 2f;
    public float rotationSpeed = 50f;
    public int beginSize;
    public GameObject bodyPrefab;
    public GameObject gameOverScreen;
    public GameObject ScorePanel;
    public Text textScore;
    public Text finalScoreText;
    public int  score = 0;
    public float rotationDirection = 0;

    private float dis;
    private Transform curBodyPart;
    private Transform prevBodyPart;

    

    // Start is called before the first frame update
    void Start()
    {
        
        for (int i = 0; i < beginSize - 1; i++)
        {
            addBodyPart();
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        textScore.text = "score:" + score.ToString();
        Move();
        
        
    }
     void Move()
    {
        bodyParts[0].Translate(bodyParts[0].forward * speed* Time.deltaTime, Space.World);
   
        if (rotationDirection != 0) 
            bodyParts[0].Rotate(  Vector3.up *rotationSpeed * Time.deltaTime * rotationDirection);
       
            for (int i = 1; i < bodyParts.Count; i++) {
                curBodyPart = bodyParts[i];
                prevBodyPart = bodyParts[i - 1];
                dis = Vector3.Distance(prevBodyPart.position, curBodyPart.position);
                Vector3 newPos = prevBodyPart.position;
                float T = Time.deltaTime* dis / minDis * speed;
                if (T > 0.5f) T = 0.5f;
                curBodyPart.position = Vector3.Slerp(curBodyPart.position, prevBodyPart.position, T);
                curBodyPart.rotation = Quaternion.Slerp(curBodyPart.rotation, prevBodyPart.rotation, T);

            }
        
        
    }
    public void addBodyPart()
    {
        GameObject newBody = bodyPrefab;
        newBody.GetComponent<DeadByTail>().movement = this;
        Transform newPart = Instantiate(newBody, bodyParts[bodyParts.Count -1 ].position, bodyParts[bodyParts.Count - 1].rotation) .transform;
        newPart.SetParent(transform);
        bodyParts.Add(newPart);
    }
    public void Dead() {
        gameOverScreen.SetActive(true);
        finalScoreText.text = "Your score:" + score.ToString();

    }
}
