using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NamebarLookAt : MonoBehaviour
{ 
    public Transform tar;
    void Start()
    {
        
    }
 
    void Update()
    {
        transform.LookAt(tar);
    }
}
