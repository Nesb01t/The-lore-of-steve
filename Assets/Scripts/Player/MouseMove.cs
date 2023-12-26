using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMove : MonoBehaviour
{  
    public Animator animator;
    

    private void AnimatorTrigger()
    {
        if (Input.GetMouseButton(0))
        {
            animator.SetTrigger("Move");
        }
        else
        {
            animator.SetTrigger("Stop");
        }
    }
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 pos = GetClickPos();
            MoveTo(pos);
        }
        AnimatorTrigger();
    }
    
    private void MoveTo(Vector3 pos)
    { 
        // move
        Vector3 v = pos - transform.position;
        v.y = 0;
        transform.position += v.normalized * Time.deltaTime * 4.5f ;

        // face
        transform.forward = v;
    }

    private Vector3 GetClickPos()
    {  
        Vector3 mousePos = Input.mousePosition;
        Ray ray = Camera.main.ScreenPointToRay(mousePos);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            Debug.Log(hit.point);
            return hit.point;
        }
        return Vector3.zero;
    }
}
