using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinscript : MonoBehaviour
{
    public AudioSource coinSound;
    
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Furry"))
        {
            ScoreTextScript.coinAmount += 1;
            coinSound.Play();
            Destroy(gameObject);
        }
    }
}
