using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelL1 : MonoBehaviour
{
    public void PGame()
    {
        SceneManager.LoadScene("Level2");
    }

    public void QGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
