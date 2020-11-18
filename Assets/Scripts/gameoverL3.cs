using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameoverL3 : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene("Level3");
    }

    public void QGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
