using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goalhole : MonoBehaviour
{
    void OnTriggerEnter(Collider col) {
        BallControlScript.setYouWinToTrue ();
    }
}
