using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultMobBehavior : MonoBehaviour
{
    private Transform _tar;
    void Start()
    {
        _tar = GameObject.Find("Player").transform;
    }
    
    void Update()
    {
        if (!_tar) return;
        
        transform.LookAt(_tar);
    }
}
