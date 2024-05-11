using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrentTime : MonoBehaviour
{
    public Text timeTxt;
    string currentTime;

    void Update()
    {
        currentTime = DateTime.Now.ToString("HH:mm"); //현재시간을 string으로 변환
        timeTxt.text = currentTime;
    }
}
