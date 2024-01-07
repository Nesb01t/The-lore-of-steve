using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultMobBehavior : MonoBehaviour
{
    private Transform _tar;

    private float _attack_cooldown = 0.0f;

    void Start()
    {
        _tar = GameObject.Find("Player").transform;
    }

    void Update()
    {
        if (!_tar) return;

        transform.LookAt(_tar);
        transform.Translate(Vector3.forward * Time.deltaTime);

        if (_attack_cooldown >= 0) _attack_cooldown -= Time.deltaTime;
        if (_attack_cooldown <= 0 && Vector3.Distance(_tar.position, transform.position) < 1.0f)
        {
            _attack_cooldown = 1.0f;
            _tar.Translate(transform.forward * 1.0f);
        }
    }
}