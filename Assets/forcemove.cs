using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forcemove : MonoBehaviour
{
    public Rigidbody2D rb;
    bool moveleft = false;
    bool moveright;
    public float power = 5.0f;

    void MoveControl()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            moveleft = true;
        }
        else moveleft = false;

        moveright = Input.GetKey(KeyCode.RightArrow);
    }

    void Update()
    {
        MoveControl();
    }
    void FixedUpdate()
    {
        if (moveleft)
        {
            rb.AddForce(Vector2.left*5);
            //= rb.AddForce(new Vector2(0.0f,1.0f));
        }
        if (moveright)
        {
            rb.AddForce(Vector2.right * power);
        }
        else
        {
            moveleft = false;
            moveright = false;
        }

    }
}
