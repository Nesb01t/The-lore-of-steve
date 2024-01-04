using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    public float _health = 20.0f;

    private float _mana = 20.0f;

    public float getHealth()
    {
        return this._health;
    }
}