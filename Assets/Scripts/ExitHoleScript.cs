using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitHoleScript : MonoBehaviour
{
    void OnTriggerEnter(Collider ball) {
        BallControlScript.setYouWinToTrue ();
    }
}
