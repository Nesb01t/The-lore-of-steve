using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Melee : MonoBehaviour
{
    public float Damage = 3.0f;
    
    private Animator animator;

    void Start()
    {
        // init
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && animator.GetBool("Attack") == false)
        {
            animator.SetTrigger("Attack");
            Attack();
        }
    }

    void Attack()
    {
        Debug.Log("attacked");
    }
}