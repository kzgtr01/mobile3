using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameoverL1 : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene("Level1");
    }

    public void QGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
