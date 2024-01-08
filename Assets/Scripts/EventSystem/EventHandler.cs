using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventHandler : MonoBehaviour
{
    public virtual void Fire()
    {
        // @TODO shall be implemented
    }

    public void HandleEvent(MicroEvent e)
    {
        e.Fire();
        Debug.Log(e.GetName());
    }
}