using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathHoleScript : MonoBehaviour
{
    void OnTriggerEnter(Collider col) {
        BallControlScript.setIsDeadTrue ();
    }
}
