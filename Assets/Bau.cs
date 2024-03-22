using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bau : MonoBehaviour, IInterativo
{
    public void Interagir()
    {
        Debug.Log("Abriu o baú");
    }

    public void InteragirEspecial()
    {
        Debug.Log("É um baú pequeno");
    }
}
