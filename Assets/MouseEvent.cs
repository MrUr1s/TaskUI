using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseEvent : MonoBehaviour
{
    [SerializeField]
    TimeUpScript TimeUpScript;
    [SerializeField]
    ButtonName ButtonName;
    Action click;
    private void Start()
    {
        TimeUpScript = GetComponentInParent<TimeUpScript>();
        if(TimeUpScript != null)
            switch (ButtonName)
            {
                case ButtonName.HourUp:
                    click = TimeUpScript.HourUp;
                    break;
                case ButtonName.HourDown:
                    click = TimeUpScript.HourDown;
                    break;
                case ButtonName.MuniteDown:
                    click = TimeUpScript.MinuteDown;
                    break;
                case ButtonName.MuniteUp:
                    click = TimeUpScript.MinuteUp;
                    break;
            }
    }
    private void OnMouseDown()
    {
        if (click != null)
            click.Invoke();
        else
            Debug.Log("Error");
    }
}
