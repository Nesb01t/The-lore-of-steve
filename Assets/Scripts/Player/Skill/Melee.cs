using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Melee : MonoBehaviour
{
    public float Damage = 3.0f;
    public GameObject Debugger_Hitpoint;

    public EventHandler handler;

    private Animator animator;

    void Start()
    {
        // init
        animator = GetComponent<Animator>();
        handler = gameObject.AddComponent<EventHandler>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && animator.GetBool("Attack") == false)
        {
            animator.SetTrigger("Attack");
            Attack();
        }
    }

    private void Attack()
    {
        Transform t = GameObject.Find("Player").transform;
        Vector3 p = t.position;
        p.y += 0.3f;
        Ray ray = new Ray(p, t.forward);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 4.0f))
        {
            handler.HandleEvent(new MicroEvent("你好"));
            if (Debugger_Hitpoint)
            {
                Instantiate(Debugger_Hitpoint, hit.point, Quaternion.identity);
            }

            if (hit.collider.CompareTag("Enemy"))
            {
                hit.collider.GetComponent<MobHealth>().Hurt(Damage);
            }
        }
    }
}