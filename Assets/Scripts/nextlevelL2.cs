using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextlevelL2 : MonoBehaviour
{
    public void NGame()
    {
        SceneManager.LoadScene("Level3");
    }

    public void QGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
