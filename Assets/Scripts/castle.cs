using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class castle : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        //if (other.tag == "Furry")
        if (other.CompareTag("Furry"))
        {
            Scene currentScene = SceneManager.GetActiveScene();

            // Retrieve the name of this scene.
            string sceneName = currentScene.name;

            if (sceneName == "Level1")
            {
                SceneManager.LoadScene("nextlevelL1");
            }

            else if (sceneName == "Level2")
            {
                SceneManager.LoadScene("nextlevelL2");
            }

            else if (sceneName == "Level3")
            {
                SceneManager.LoadScene("Win");
            }
        }
    }
}
