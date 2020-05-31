using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movements : MonoBehaviour
{
    public float vRotatation = 0f;

    void Update()
    {
        transform.Rotate(0, 0, vRotatation);   
    }
}
