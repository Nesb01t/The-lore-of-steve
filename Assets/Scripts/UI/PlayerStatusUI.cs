using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStatusUI : MonoBehaviour
{
    private float _health = -1.0f;

    private PlayerStatus status;
    private Text text;

    void Start()
    {
        status = GameObject.Find("Player").GetComponent<PlayerStatus>();
        text = GetComponent<Text>();
    }

    void Update()
    {
        _health = status.getHealth();
        text.text = _health.ToString();
    }
}