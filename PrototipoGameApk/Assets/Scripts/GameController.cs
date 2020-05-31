using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject painelLivro;
    public GameObject lateralEsquerda, lateralDireita, topo, chao;
    private Vector2 topoDireita, fundoEsquerda;

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            RetornaInicio();
        }
    }

    private void Start()
    {
        fundoEsquerda = Camera.main.ScreenToWorldPoint(new Vector2(0, 0));
        topoDireita = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
        painelLivro.SetActive(false);
        lateralDireita.transform.position = new Vector2(topoDireita.x + lateralDireita.transform.localScale.x/2, 0);
        lateralEsquerda.transform.position = new Vector2(fundoEsquerda.x - lateralEsquerda.transform.localScale.x / 2, 0);
        topo.transform.position = new Vector2(0, topoDireita.y);
        chao.transform.position = new Vector2(0, fundoEsquerda.y - chao.transform.localScale.y / 2);
    }

    public void lerLivro()
    {
        painelLivro.SetActive(true);
    }

    public void GuardarLivro()
    {
        painelLivro.SetActive(false);
    }

    public void RetornaInicio()
    {
        SceneManager.LoadScene("Inicio");
    }
}
