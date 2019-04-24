using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadMenuScript : MonoBehaviour
{
    // Start is called before the first frame update
   public  void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // Update is called once per frame
    public void Exit()
    {
        Application.Quit();
    }
}
