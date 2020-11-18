using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextlevelL1 : MonoBehaviour
{
    public void NGame()
    {
        SceneManager.LoadScene("Level2");
    }

    public void QGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
