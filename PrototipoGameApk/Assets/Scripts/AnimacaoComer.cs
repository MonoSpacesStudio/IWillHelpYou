using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacaoComer : MonoBehaviour
{
    private Animator animation;

    void Start()
    {
        animation = GetComponent<Animator>();
    }

    public void Comer()
    {
        if (animation.GetBool("Comer") == false)
        {
            animation.SetBool("Comer", true);
        }
        
    }

    public void pararComer()
    {
        animation.SetBool("Comer", false);
    }
}
