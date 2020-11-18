using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameover : MonoBehaviour
{
    public void PGame()
    {
        SceneManager.LoadScene("Level1");
    }

    public void QGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
