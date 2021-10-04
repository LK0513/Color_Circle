using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{
    BoxCollider2D boxc;
    void Start()
    {
        boxc = GetComponent<BoxCollider2D>();
        boxc.isTrigger = true;
    }


    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        {
            Camera.main.transform.position = new Vector3(0, -154, -10);
            Camera.main.orthographicSize = 74;
        }
    }
}

  