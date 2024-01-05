using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropedItem : MonoBehaviour
{
    public float floatSpeed = 1f; // 上下浮动的速度
    public float rotationSpeed = 90f; // 自旋转的速度
    public float floatHeight = 0.5f; // 上下浮动的高度

    private Vector3 _startPos;
    private GameObject _nearestPlayer;

    void Start()
    {
        InitRotationAnime();
        _nearestPlayer = GameObject.Find("Player");
    }

    void Update()
    {
        Transform t = UpdateGetNextChangedYAxis(transform);
        transform.position = UpdatePickScan(t).position;
    }

    void InitRotationAnime()
    {
        _startPos = transform.position;
    }

    Transform UpdatePickScan(Transform t)
    {
        Vector3 playerPos = _nearestPlayer.transform.position;
        Vector3 itemPos = transform.position;
        float dis = Vector3.Distance(playerPos, itemPos);

        if (dis < 1.5f)
        {
            // pickup items
            Destroy(gameObject);
        }

        if (dis < 5.0f)
        {
            // gravity simulation
            t.position = Vector3.Lerp(itemPos, playerPos, Time.deltaTime);
        }

        return t;
    }

    Transform UpdateGetNextChangedYAxis(Transform t)
    {
        Transform res = t;

        Vector3 pos = _startPos;
        pos.y += Math.Abs(Mathf.Sin(Time.time * floatSpeed)) * floatHeight;
        res.position = new Vector3(t.position.x, pos.y, t.position.z);
        res.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        return res;
    }
}