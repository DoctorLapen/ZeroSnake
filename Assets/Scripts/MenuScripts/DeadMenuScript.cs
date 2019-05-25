using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/* скрипт обработки кнопок в меню смерти
*/
public class DeadMenuScript : MonoBehaviour
{
 /*
  *  обрабатывает кнопку restartButton
  *  перезагружает текущий уровень
  */
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

  /*
  * обработка кнопки ExitButton
  * выход из игры
  */
    public void Exit()
    {
        Application.Quit();
    }
}
