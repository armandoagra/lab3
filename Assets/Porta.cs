using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Porta : MonoBehaviour, IInterativo
{

    public void Interagir()
    {
        Debug.Log("Abriu a porta");
    }

    public void InteragirEspecial()
    {
        Debug.Log("É uma porta de madeira");
    }
}
