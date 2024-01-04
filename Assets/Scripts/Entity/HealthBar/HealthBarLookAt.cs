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
        _healthText.text = _mobHealth.Health.ToString() + " / " + _mobHealth.GetMaxHealth().ToString();
        transform.localScale = new Vector3(transform.localScale.x,
            _startScale * _mobHealth.Health / _mobHealth.GetMaxHealth(), transform.localScale.z);
    }
}