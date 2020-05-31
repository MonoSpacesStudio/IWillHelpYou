using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EspacoController : MonoBehaviour
{
    public GameObject lateralEsquerda, lateralDireita, topo, chao, painelAlimentar;
    private Vector2 topoDireita, fundoEsquerda;
    // Start is called before the first frame update
    void Start()
    {
        fechaPainel();
        fundoEsquerda = Camera.main.ScreenToWorldPoint(new Vector2(0, 0));
        topoDireita = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
        lateralDireita.transform.position = new Vector2(topoDireita.x + lateralDireita.transform.localScale.x / 2, 0);
        lateralEsquerda.transform.position = new Vector2(fundoEsquerda.x - lateralEsquerda.transform.localScale.x / 2, 0);
        topo.transform.position = new Vector2(0, topoDireita.y + topo.transform.localScale.y / 2);
        chao.transform.position = new Vector2(0, fundoEsquerda.y - chao.transform.localScale.y / 2);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            RetornaInicio();
        }
    }

    public void RetornaInicio()
    {
        SceneManager.LoadScene("Inicio");
    }

    public void abrePainel()
    {
        painelAlimentar.SetActive(true);
    }

    public void fechaPainel()
    {
        painelAlimentar.SetActive(false);
    }
}
