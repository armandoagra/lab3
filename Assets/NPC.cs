using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour, IInterativo
{
    public void Interagir()
    {
        Debug.Log("Comecou o dialogo");
    }

    public void InteragirEspecial()
    {
        Debug.Log("N�o sei se confio nesse cara");
    }
}
