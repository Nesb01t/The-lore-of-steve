using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropedItem : MonoBehaviour
{
    public float floatSpeed = 1f; // 上下浮动的速度
    public float rotationSpeed = 90f; // 自旋转的速度
    public float floatHeight = 0.5f; // 上下浮动的高度

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        Vector3 newPosition = startPos;
        newPosition.y += Math.Abs(Mathf.Sin(Time.time * floatSpeed)) * floatHeight;

        transform.position = newPosition;
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}