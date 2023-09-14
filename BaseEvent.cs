using System.Collections.Generic;
using UnityEngine;

public class BaseEvent<TEvent, TListener> : ScriptableObject
    where TEvent : BaseEvent<TEvent, TListener>
    where TListener : BaseEventListener<TEvent, TListener>
{
    List<TListener> listeners;

    public void Register(TListener listener)
    {
        listeners.Add(listener);
    }

    public void Unregister(TListener listener)
    {

        listeners.Remove(listener);
    }

    public void Raise()
    {
        foreach (var listener in listeners)
        {
            listener.Invoke();
        }
    }
}

public class BaseEvent<TEvent, TListener, T1> : ScriptableObject
    where TEvent : BaseEvent<TEvent, TListener, T1>
    where TListener : BaseEventListener<TEvent, TListener, T1>
{
    List<TListener> listeners;

    public void Register(TListener listener)
    {
        listeners.Add(listener);
    }

    public void Unregister(TListener listener)
    {

        listeners.Remove(listener);
    }

    public void Raise(T1 item)
    {

        foreach (var listener in listeners)
        {
            listener.Invoke(item);
        }
    }
}

public class BaseEvent<TEvent, TListener, T1, T2> : ScriptableObject
    where TEvent : BaseEvent<TEvent, TListener, T1, T2>
    where TListener : BaseEventListener<TEvent, TListener, T1, T2>
{
    List<TListener> listeners;

    public void Register(TListener listener)
    {
        listeners.Add(listener);
    }

    public void Unregister(TListener listener)
    {

        listeners.Remove(listener);
    }

    public void Raise(T1 item1, T2 item2)
    {
        foreach (var listener in listeners)
        {
            listener.Invoke(item1, item2);
        }
    }
}