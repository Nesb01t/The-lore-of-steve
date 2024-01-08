using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MicroEvent
{
    private string name;

    public MicroEvent(string name)
    {
        this.name = name;
    }

    public void Fire()
    {
        // @TODO shall be implemented
        Debug.Log(this.name);
    }

    public string GetName()
    {
        return this.name;
    }

    public void SetName(string name)
    {
        this.name = name;
    }
}