using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventEmitter : MonoBehaviour
{
    private static List<EventHandler> handlers = new List<EventHandler>();

    public static void RegisterEventHandler(EventHandler handler)
    {
        handlers.Add(handler);
    }

    public static void SendEvent(MicroEvent e)
    {
        foreach (EventHandler handler in handlers)
        {
            handler.HandleEvent(e);
        }
    }
}