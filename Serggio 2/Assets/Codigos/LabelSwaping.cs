using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LabelSwaping : MonoBehaviour
{

    public GameObject Etiqueta1;
    public GameObject Etiqueta2;
    public void VerEtiqueta1()
    {
        Etiqueta1.SetActive(true);
        Etiqueta2.SetActive(false);
    }

    public void VerEtiqueta2()
    {
        Etiqueta1.SetActive(false);
        Etiqueta2.SetActive(true);
    }
}
