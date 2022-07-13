using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeUpScript : MonoBehaviour
{
    [SerializeField]
    int hour, minute;
    public int Hour
    {
        get => hour;
        set
        {
            hour = value;
            if (hour < 0)
                hour = 23;
            else
            if (hour > 23)
                hour = 0;
            Event_system.timeEvent.Publish(hour,Minute);
        }
    }
    public int Minute { get => minute;

        set
        {
            minute = value;
            if(minute < 0)
                minute = 59;
            if (minute > 59)
                minute = 0;
            Event_system.timeEvent.Publish(Hour,minute);
        }
    }
    private void Start()
    {
        Event_system.timeEvent.Publish(hour, Minute);
    }
    public void MinuteDown() => Minute--;
    public void MinuteUp() => Minute++;

    public void HourDown() => Hour--;
    public void HourUp()
    {
        Hour++;
    }

}
