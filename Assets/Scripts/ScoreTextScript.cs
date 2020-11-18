using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTextScript : MonoBehaviour
{
    Text text;
    public static int coinAmount;

    private void Start()
    {
        text = GetComponent<Text>();

    }

    private void Update()
    {
        text.text = coinAmount.ToString();
    }
}
