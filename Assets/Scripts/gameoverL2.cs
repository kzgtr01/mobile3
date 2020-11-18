using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameoverL2 : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene("Level2");
    }

    public void QGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
