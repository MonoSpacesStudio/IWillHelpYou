using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quartoPc : MonoBehaviour
{
    private Animator animation;

    private void Start()
    {
        animation = GetComponent<Animator>();
    }

    public void Click()
    {
        if (animation.GetBool("Data"))
        {
            animation.SetBool("Data", false);
        }
        else
        {
            animation.SetBool("Data", true);
        }
    }
}
