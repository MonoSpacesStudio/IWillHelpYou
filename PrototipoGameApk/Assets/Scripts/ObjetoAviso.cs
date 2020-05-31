using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoAviso : MonoBehaviour
{
    public GameObject aviso;

    private void Start()
    {
        aviso.gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            aviso.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        aviso.gameObject.SetActive(false);
    }
}
