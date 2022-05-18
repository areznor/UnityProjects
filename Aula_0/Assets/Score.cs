using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI display;
    public float scoreCurrent;

    public void Add() 
    {
        scoreCurrent = scoreCurrent + 1;
        display.text = scoreCurrent.ToString();
    }
}
