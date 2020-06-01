using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setPosition : MonoBehaviour
{
    private Vector2 fundoEsquerda, topoDireita;
    public bool esquerda;
    public GameObject collisor;

    void Start()
    {
        fundoEsquerda = Camera.main.ScreenToWorldPoint(new Vector2(0, 0));
        topoDireita = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));

        if (esquerda)
        {
            collisor.transform.position = new Vector2(fundoEsquerda.x, 0);
        }
        else
        {
            collisor.transform.position = new Vector2(topoDireita.x, 0);
        }
    }

    
}
