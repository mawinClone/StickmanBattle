using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knockback : MonoBehaviour
{
    public Transform center;
    public Transform t;
    public Rigidbody2D rb;
    
    void Start()
    {
        Vector3 dir = center.position - t.position;
        rb.velocity = dir.normalized * 5;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
