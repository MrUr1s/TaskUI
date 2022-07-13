using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimeLabel : MonoBehaviour
{
    [SerializeField]
    e_Time e_time;
    void Start()
    {
        Event_system.timeEvent.Subscribe(setText);
    }

    void setText(int hour, int munite)
    {
        if (e_time == e_Time.Hour)
            GetComponent<TextMeshPro>().text = hour.ToString();
        else
            GetComponent<TextMeshPro>().text = munite.ToString();
    }
}
enum e_Time { Hour,minute}