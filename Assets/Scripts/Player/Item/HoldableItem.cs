using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldableItem : MonoBehaviour
{
    public Vector3 posOffset;
    public Vector3 rotOffset;
    public Vector3 scaleOffset;

    void Start()
    {
    }

    void Update()
    {
        transform.SetLocalPositionAndRotation(posOffset, Quaternion.Euler(rotOffset));
        transform.localScale = scaleOffset;
    }
}