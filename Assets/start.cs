using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start : MonoBehaviour
{
    public Rigidbody2D rb;
    void Start()
    {
       
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb = GetComponent<Rigidbody2D>();
            rb.WakeUp();
        }
    }
}
