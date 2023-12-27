using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLock : MonoBehaviour
{
    public Transform tar;
    void Start()
    {
        
    }

    void Update()
    {
        if (tar != null)
        {
            var x = tar.position.x;
            var y = tar.position.y;
            var z = tar.position.z;
            transform.position = new Vector3(x + 5, y + 10,z + 5);
        }
    }
}
