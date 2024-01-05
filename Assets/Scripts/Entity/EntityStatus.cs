using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobHealth : MonoBehaviour
{
    public float Health = 10.0f;

    private float _maxHealth;

    void Start()
    {
        _maxHealth = Health;
    }

    void Update()
    {
    }

    public void Hurt(float dmg)
    {
        Health -= dmg;
        if (Health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }

    public float GetMaxHealth()
    {
        return _maxHealth;
    }

    public void SetMaxHealth(float f)
    {
        if (f < 0) return;
        _maxHealth = f;
    }
}