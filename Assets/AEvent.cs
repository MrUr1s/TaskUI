using System;
using System.Collections.Generic;

public class AEvent<T>
{
    protected readonly List<Action<T>> _callbacks = new List<Action<T>>();

    public void Subcribe(Action<T> callback)
    {
        _callbacks.Add(callback);
    }

    public void Publish(T value)
    {
        foreach (Action<T> callback in _callbacks)
            callback(value);
    }
}