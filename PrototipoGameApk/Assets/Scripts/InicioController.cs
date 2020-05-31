using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InicioController : MonoBehaviour
{
    public void Terra()
    {
        SceneManager.LoadScene("FaseTerra");
    }

    public void Espaco()
    {
        SceneManager.LoadScene("FaseEspaco");
    }

    public void Sair()
    {
        Application.Quit();
    }
}
