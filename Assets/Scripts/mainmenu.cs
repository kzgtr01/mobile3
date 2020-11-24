using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void Play()
    {
        SceneManager.LoadScene("GameMode");
    }

    // Update is called once per frame
    public void Howtoplay()
    {   
        SceneManager.LoadScene("HowToPlay");
    }
    public void Setting()
    {   
        SceneManager.LoadScene("Setting");
    }
}
