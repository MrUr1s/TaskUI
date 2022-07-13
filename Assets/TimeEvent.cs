using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeEvent
{
    protected readonly List<Action<int,int>> _callbacks = new List<Action<int, int>>();
    public void Subscribe(Action<int, int> callback)
    {
        _callbacks.Add(callback);
    }

    public void Publish(int hour,int minute)
    {
        foreach (Action<int, int> callback in _callbacks)
            callback(hour,minute);
    }

}
