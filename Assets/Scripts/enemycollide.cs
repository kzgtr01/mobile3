using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemycollide : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D colEnemy)
    {
        if (colEnemy.CompareTag("Furry"))
        {
            Scene currentScene = SceneManager.GetActiveScene();

            // Retrieve the name of this scene.
            string sceneName = currentScene.name;

            if (sceneName == "Level1")
            {
                SceneManager.LoadScene("GameOverL1");
            }

            else if (sceneName == "Level2")
            {
                SceneManager.LoadScene("GameOverL2");
            }

            else if (sceneName == "Level3")
            {
                SceneManager.LoadScene("GameOverL3");
            }
        }
        
        
    }
}
