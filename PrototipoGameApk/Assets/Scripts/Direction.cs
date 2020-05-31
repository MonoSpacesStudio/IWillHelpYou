using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Direction : MonoBehaviour
{
    public float x=0, y=0;

    void Update()
    {
        transform.Translate(Vector3.up * y);
        transform.Translate(Vector3.right * x);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Paredes")
        {
            x = x * -1;
        }

        if (collision.gameObject.tag == "Chao" ||
            collision.gameObject.tag == "Topo")
        {
            y = y * -1;
        }
    }
}
