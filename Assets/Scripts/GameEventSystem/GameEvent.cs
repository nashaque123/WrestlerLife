using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class GameEvent : ScriptableObject
{
    private List<GameEventListener> _listeners = new List<GameEventListener>();

    public void EventOccurred()
    {
        for (int i = _listeners.Count - 1; i >= 0; i--)
        {
            _listeners[i].OnEventOccurred();
        }
    }

    public void AddListener(GameEventListener listener)
    {
        if (!_listeners.Contains(listener))
        {
            _listeners.Add(listener);
        }
        else
        {
            Debug.LogError(listener.name + " is already in the list and cannot be added again");
        }
    }

    public void RemoveListener(GameEventListener listener)
    {
        if (_listeners.Contains(listener))
        {
            _listeners.Remove(listener);
        }
        else
        {
            Debug.LogError(listener.name + " is not in the list so cannot be removed");
        }
    }
}
