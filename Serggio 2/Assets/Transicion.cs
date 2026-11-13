using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transicion : MonoBehaviour
{
    public Animator _animator;
    public GameObject Bloqueo;

    public void CambiarEscenaConTransicion()
    {
        Bloqueo.SetActive(true);
        _animator.SetTrigger("CambiarEscena");
    }
}
