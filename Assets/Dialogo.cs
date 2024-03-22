using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Dialogo", menuName ="Dialogos/Dialogo")]
public class Dialogo : ScriptableObject
{
    public Sprite spritePersonagem;
    public string nomePersonagem;
    [TextArea(3,10)]
    public string texto;
    public string evento;
    public float delayEvento;

}
