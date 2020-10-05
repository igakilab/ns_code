using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{
    public Text timerText;

    public float totalTime;
    public int seconds;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (seconds <= -2)
        {
            timerText.text = "";
            return;
        }
        totalTime -= Time.deltaTime;
        seconds = (int)totalTime;
        if (seconds <= 0)
        {
            timerText.text = "START";
        } else
        {
            timerText.text = seconds.ToString();
        }
    }
}