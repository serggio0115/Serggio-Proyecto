using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlEscenas : MonoBehaviour
{
    public void CargarEscenaInicio()
    {
        SceneManager.LoadScene("Interfaz inicial Serggio");
    }

    public void CargarEscenaPrincipal()
    {
        SceneManager.LoadScene("App Serggio");
    }
}
