using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarLookAt : MonoBehaviour
{
    public Transform tar;

    private TextMesh _healthText;
    private MobHealth _mobHealth;
    private float _startScale;

    void Start()
    {
        _healthText = GetComponentInChildren<TextMesh>();
        _mobHealth = GetComponentInParent<MobHealth>();

        _startScale = transform.localScale.y;
    }

    void Update()
    {
        transform.LookAt(tar);
        _healthText.text = _mobHealth.Health + " / " + _mobHealth.GetMaxHealth();
    }
}